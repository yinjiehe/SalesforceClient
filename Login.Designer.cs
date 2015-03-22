namespace SalesforceRest
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_URL = new System.Windows.Forms.TextBox();
            this.BulkAPI = new System.Windows.Forms.RadioButton();
            this.RestAIP = new System.Windows.Forms.RadioButton();
            this.TableLayoutPanel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(92, 22);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(343, 21);
            this.TB_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(92, 52);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(343, 21);
            this.TB_Password.TabIndex = 3;
            // 
            // TableLayoutPanel_Buttons
            // 
            this.TableLayoutPanel_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel_Buttons.ColumnCount = 2;
            this.TableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Buttons.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel_Buttons.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel_Buttons.Location = new System.Drawing.Point(289, 163);
            this.TableLayoutPanel_Buttons.Name = "TableLayoutPanel_Buttons";
            this.TableLayoutPanel_Buttons.RowCount = 1;
            this.TableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Buttons.Size = new System.Drawing.Size(146, 27);
            this.TableLayoutPanel_Buttons.TabIndex = 5;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 21);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 21);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL:";
            // 
            // TB_URL
            // 
            this.TB_URL.Location = new System.Drawing.Point(92, 81);
            this.TB_URL.Name = "TB_URL";
            this.TB_URL.Size = new System.Drawing.Size(343, 21);
            this.TB_URL.TabIndex = 7;
            // 
            // BulkAPI
            // 
            this.BulkAPI.AutoSize = true;
            this.BulkAPI.Checked = true;
            this.BulkAPI.Location = new System.Drawing.Point(92, 110);
            this.BulkAPI.Name = "BulkAPI";
            this.BulkAPI.Size = new System.Drawing.Size(71, 16);
            this.BulkAPI.TabIndex = 8;
            this.BulkAPI.TabStop = true;
            this.BulkAPI.Text = "Bulk API";
            this.BulkAPI.UseVisualStyleBackColor = true;
            // 
            // RestAIP
            // 
            this.RestAIP.AutoSize = true;
            this.RestAIP.Location = new System.Drawing.Point(173, 110);
            this.RestAIP.Name = "RestAIP";
            this.RestAIP.Size = new System.Drawing.Size(71, 16);
            this.RestAIP.TabIndex = 9;
            this.RestAIP.Text = "REST API";
            this.RestAIP.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(461, 212);
            this.Controls.Add(this.RestAIP);
            this.Controls.Add(this.BulkAPI);
            this.Controls.Add(this.TB_URL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableLayoutPanel_Buttons);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Salesforce";
            this.TableLayoutPanel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Password;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Buttons;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_URL;
        private System.Windows.Forms.RadioButton BulkAPI;
        private System.Windows.Forms.RadioButton RestAIP;
    }
}