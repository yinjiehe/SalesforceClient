using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesforceRest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Login loginDlg = new Login();
            if (loginDlg.ShowDialog() == DialogResult.OK)
            {
                if (loginDlg.BulkAPIChecked)
                {
                    RestAPIClient dlg = new RestAPIClient();
                    dlg.SetLoginInfo(loginDlg);
                    Application.Run(dlg);
                }
                else
                {
                    BulkAPIClient dlg = new BulkAPIClient();
                    dlg.SetLoginInfo(loginDlg);
                    Application.Run(dlg);
                }
            }
        }
    }
}
