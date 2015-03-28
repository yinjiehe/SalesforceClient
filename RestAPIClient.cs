using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;
using SalesforceClient;

namespace SalesforceRest
{
    public partial class RestAPIClient : Form
    {
        public RestAPIClient()
        {
            InitializeComponent();
        }

        public void SetLoginInfo(Login dlg)
        {
            if (dlg != null)
            {
                this.TB_Host.Text = dlg.Host;
                this.TB_SessionID.Text = dlg.SessionID;
            }
        }

        private void RestClient_Load(object sender, EventArgs e)
        {
            this.CB_Method.Text = "GET";
            this.TB_URI.Text = "/services/data";
        }

        private void RestAPIClient_Shown(object sender, EventArgs e)
        {
            this.BTN_GO.Focus();
        }

        private void BTN_GO_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://" + this.TB_Host.Text + this.TB_URI.Text;
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = this.CB_Method.Text;
                request.Headers.Add("Authorization", "OAuth " + this.TB_SessionID.Text);
                request.Headers.Add("X-PrettyPrint", "1");
                request.Accept = "application/json";
                if (!string.IsNullOrEmpty(this.RTB_RequestBody.Text))
                {
                    request.ContentType = "application/json";
                    RequestHelper.SetBody(request, this.RTB_RequestBody.Text);
                }

                this.RTB_Response.Text = RequestHelper.GetResponse(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
