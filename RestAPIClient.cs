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
                if (!string.IsNullOrEmpty(this.TB_RequestBody.Text))
                {
                    request.ContentType = "application/json";
                    SetBody(request, this.TB_RequestBody.Text);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                this.RTB_Response.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SetBody(HttpWebRequest request, string requestBody)
        {
            if (requestBody.Length > 0)
            {
                using (Stream requestStream = request.GetRequestStream())
                using (StreamWriter writer = new StreamWriter(requestStream))
                {
                    writer.Write(requestBody);
                }
            }
        }

    }
}
