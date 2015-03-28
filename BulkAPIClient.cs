using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using SalesforceClient;

namespace SalesforceRest
{
    public partial class BulkAPIClient : Form
    {
        public BulkAPIClient()
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

        private void BulkAPITest_Load(object sender, EventArgs e)
        {
            this.CB_Method.Text = "GET";
            this.CB_Accept.Text = "application/json";
            this.CB_ContentType.Text = "application/json;charset=UTF-8";
            this.TB_URI.Text = "/services/data";
        }

        private void BulkAPIClient_Shown(object sender, EventArgs e)
        {
            this.BTN_GO.Focus();
        }

        private void BTN_GO_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://" + this.TB_Host.Text + this.TB_URI.Text;
                HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
                request.Method = this.CB_Method.Text;
                request.Headers.Add("X-SFDC-Session", this.TB_SessionID.Text);
                request.Accept = this.CB_Accept.Text;
                if (!string.IsNullOrEmpty(this.RTB_RequestBody.Text))
                {
                    request.ContentType = this.CB_ContentType.Text;
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
