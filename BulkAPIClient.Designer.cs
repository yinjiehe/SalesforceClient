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
            this.TB_RequestBody = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // RTB_Response
            // 
            this.RTB_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Response.Location = new System.Drawing.Point(14, 261);
            this.RTB_Response.Name = "RTB_Response";
            this.RTB_Response.Size = new System.Drawing.Size(730, 154);
            this.RTB_Response.TabIndex = 23;
            this.RTB_Response.Text = "";
            // 
            // TB_SessionID
            // 
            this.TB_SessionID.Location = new System.Drawing.Point(251, 35);
            this.TB_SessionID.Name = "TB_SessionID";
            this.TB_SessionID.Size = new System.Drawing.Size(160, 21);
            this.TB_SessionID.TabIndex = 15;
            // 
            // TB_Host
            // 
            this.TB_Host.Location = new System.Drawing.Point(49, 35);
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.Size = new System.Drawing.Size(125, 21);
            this.TB_Host.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Host:";
            // 
            // BTN_GO
            // 
            this.BTN_GO.Location = new System.Drawing.Point(669, 67);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(75, 21);
            this.BTN_GO.TabIndex = 19;
            this.BTN_GO.Text = "Get Data";
            this.BTN_GO.UseVisualStyleBackColor = true;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Response:";
            // 
            // TB_RequestBody
            // 
            this.TB_RequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_RequestBody.Location = new System.Drawing.Point(12, 116);
            this.TB_RequestBody.Multiline = true;
            this.TB_RequestBody.Name = "TB_RequestBody";
            this.TB_RequestBody.Size = new System.Drawing.Size(732, 116);
            this.TB_RequestBody.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "Request Body (Optional):";
            // 
            // TB_URI
            // 
            this.TB_URI.Location = new System.Drawing.Point(310, 68);
            this.TB_URI.Name = "TB_URI";
            this.TB_URI.Size = new System.Drawing.Size(354, 21);
            this.TB_URI.TabIndex = 18;
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
            this.CB_Method.Location = new System.Drawing.Point(475, 35);
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.Size = new System.Drawing.Size(74, 20);
            this.CB_Method.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Method:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 24;
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
            this.CB_ContentType.Location = new System.Drawing.Point(91, 67);
            this.CB_ContentType.Name = "CB_ContentType";
            this.CB_ContentType.Size = new System.Drawing.Size(180, 20);
            this.CB_ContentType.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "Content Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "URI:";
            // 
            // CB_Accept
            // 
            this.CB_Accept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Accept.FormattingEnabled = true;
            this.CB_Accept.Items.AddRange(new object[] {
            "application/xml",
            "application/json"});
            this.CB_Accept.Location = new System.Drawing.Point(619, 34);
            this.CB_Accept.Name = "CB_Accept";
            this.CB_Accept.Size = new System.Drawing.Size(125, 20);
            this.CB_Accept.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "Accept:";
            // 
            // BulkAPIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 434);
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
            this.Controls.Add(this.TB_RequestBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_URI);
            this.Controls.Add(this.CB_Method);
            this.Controls.Add(this.label1);
            this.Name = "BulkAPIClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk API Client";
            this.Load += new System.EventHandler(this.BulkAPITest_Load);
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
        private System.Windows.Forms.TextBox TB_RequestBody;
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

    }
}