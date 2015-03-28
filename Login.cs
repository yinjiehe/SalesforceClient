using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using SalesforceClient;
using System.Threading;

namespace SalesforceRest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool BulkAPIChecked
        {
            get { return this.BulkAPI.Checked; }
        }

        public bool RestAIPChecked
        {
            get { return this.RestAIP.Checked; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.TB_URL.Text = "https://login.salesforce.com/services/Soap/u/33.0";
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.TB_UserName.Text))
                {
                    MessageBox.Show("Please input user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TB_UserName.Focus();
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }
                if (string.IsNullOrEmpty(this.TB_Password.Text))
                {
                    MessageBox.Show("Please input password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TB_Password.Focus();
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }

                SoapLogin(this.TB_UserName.Text, this.TB_Password.Text);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string _sessionID = null;
        private string _serverURL = null;
        private string _host = null;

        public string SessionID
        {
            get { return _sessionID; }
        }

        public string ServerURL
        {
            get { return _serverURL; }
        }

        public string Host
        {
            get { return _host; }
        }

        private void SoapLogin(string userName, string password)
        {
            string content = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<soap:Envelope xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
                "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                "xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                "<soap:Body>" +
                "<n1:login xmlns:n1=\"urn:partner.soap.sforce.com\">" +
                "<n1:username>" + userName + "</n1:username>" +
                "<n1:password>" + password + "</n1:password>" +
                "</n1:login>" +
                "</soap:Body>" +
                "</soap:Envelope>";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.TB_URL.Text);
            request.Method = "POST";
            request.Headers.Add("SOAPAction", "login");
            request.ContentType = "text/xml;charset=\"UTF-8\"";
            request.Accept = "text/xml";
            RequestHelper.SetBody(request, content);
            string result = RequestHelper.GetResponse(request);

            // Get information from response
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(result);
            XmlNamespaceManager xmlManager = new XmlNamespaceManager(xmlDoc.NameTable);
            xmlManager.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlManager.AddNamespace("df", "urn:partner.soap.sforce.com");

            XmlNode xmlNode = xmlDoc.DocumentElement.SelectSingleNode("/soapenv:Envelope/soapenv:Body/df:loginResponse/df:result/df:sessionId", xmlManager);
            _sessionID = xmlNode.FirstChild.Value;

            xmlNode = xmlDoc.DocumentElement.SelectSingleNode("/soapenv:Envelope/soapenv:Body/df:loginResponse/df:result/df:serverUrl", xmlManager);
            _serverURL = xmlNode.FirstChild.Value;

            Uri uri = new Uri(_serverURL);
            _host = uri.Host;
        }

    }
}
