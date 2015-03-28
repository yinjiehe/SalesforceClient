namespace SalesforceRest
{
    partial class BulkAPIClient
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
            this.RTB_Response = new System.Windows.Forms.RichTextBox();
            this.TB_SessionID = new System.Windows.Forms.TextBox();
            this.TB_Host = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_GO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_URI = new System.Windows.Forms.TextBox();
            this.CB_Method = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_ContentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Accept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RTB_RequestBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTB_Response
            // 
            this.RTB_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Response.Location = new System.Drawing.Point(14, 250);
            this.RTB_Response.Name = "RTB_Response";
            this.RTB_Response.Size = new System.Drawing.Size(798, 173);
            this.RTB_Response.TabIndex = 16;
            this.RTB_Response.Text = "";
            // 
            // TB_SessionID
            // 
            this.TB_SessionID.Location = new System.Drawing.Point(330, 21);
            this.TB_SessionID.Name = "TB_SessionID";
            this.TB_SessionID.Size = new System.Drawing.Size(192, 21);
            this.TB_SessionID.TabIndex = 3;
            // 
            // TB_Host
            // 
            this.TB_Host.Location = new System.Drawing.Point(65, 22);
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.Size = new System.Drawing.Size(148, 21);
            this.TB_Host.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Host:";
            // 
            // BTN_GO
            // 
            this.BTN_GO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_GO.Location = new System.Drawing.Point(737, 194);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(75, 21);
            this.BTN_GO.TabIndex = 14;
            this.BTN_GO.Text = "Get Data";
            this.BTN_GO.UseVisualStyleBackColor = true;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Request Body (Optional):";
            // 
            // TB_URI
            // 
            this.TB_URI.Location = new System.Drawing.Point(603, 56);
            this.TB_URI.Name = "TB_URI";
            this.TB_URI.Size = new System.Drawing.Size(209, 21);
            this.TB_URI.TabIndex = 11;
            // 
            // CB_Method
            // 
            this.CB_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Method.FormattingEnabled = true;
            this.CB_Method.Items.AddRange(new object[] {
            "HEAD",
            "GET",
            "POST",
            "PATCH",
            "DELETE"});
            this.CB_Method.Location = new System.Drawing.Point(603, 21);
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.Size = new System.Drawing.Size(209, 20);
            this.CB_Method.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "SessionID:";
            // 
            // CB_ContentType
            // 
            this.CB_ContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ContentType.FormattingEnabled = true;
            this.CB_ContentType.Items.AddRange(new object[] {
            "text/csv;charset=UTF-8",
            "application/xml;charset=UTF-8",
            "application/json;charset=UTF-8"});
            this.CB_ContentType.Location = new System.Drawing.Point(330, 56);
            this.CB_ContentType.Name = "CB_ContentType";
            this.CB_ContentType.Size = new System.Drawing.Size(192, 20);
            this.CB_ContentType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Content Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "URI:";
            // 
            // CB_Accept
            // 
            this.CB_Accept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Accept.FormattingEnabled = true;
            this.CB_Accept.Items.AddRange(new object[] {
            "application/xml",
            "application/json"});
            this.CB_Accept.Location = new System.Drawing.Point(65, 56);
            this.CB_Accept.Name = "CB_Accept";
            this.CB_Accept.Size = new System.Drawing.Size(148, 20);
            this.CB_Accept.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Accept:";
            // 
            // RTB_RequestBody
            // 
            this.RTB_RequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_RequestBody.Location = new System.Drawing.Point(14, 104);
            this.RTB_RequestBody.Name = "RTB_RequestBody";
            this.RTB_RequestBody.Size = new System.Drawing.Size(798, 84);
            this.RTB_RequestBody.TabIndex = 13;
            this.RTB_RequestBody.Text = "";
            // 
            // BulkAPIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 442);
            this.Controls.Add(this.RTB_RequestBody);
            this.Controls.Add(this.CB_Accept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_ContentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RTB_Response);
            this.Controls.Add(this.TB_SessionID);
            this.Controls.Add(this.TB_Host);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_GO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_URI);
            this.Controls.Add(this.CB_Method);
            this.Controls.Add(this.label1);
            this.Name = "BulkAPIClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk API Client";
            this.Load += new System.EventHandler(this.BulkAPITest_Load);
            this.Shown += new System.EventHandler(this.BulkAPIClient_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Response;
        private System.Windows.Forms.TextBox TB_SessionID;
        private System.Windows.Forms.TextBox TB_Host;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_GO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_URI;
        private System.Windows.Forms.ComboBox CB_Method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_ContentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Accept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox RTB_RequestBody;

    }
}