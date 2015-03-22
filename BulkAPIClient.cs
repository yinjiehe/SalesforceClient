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

        private void BTN_GO_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://" + this.TB_Host.Text + this.TB_URI.Text;
                HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
                request.Method = this.CB_Method.Text;
                request.Headers.Add("X-SFDC-Session", this.TB_SessionID.Text);
                request.Accept = this.CB_Accept.Text;
                if (!string.IsNullOrEmpty(this.TB_RequestBody.Text))
                {
                    request.ContentType = this.CB_ContentType.Text;
                    SetBody(request, this.TB_RequestBody.Text);
                }

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
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
