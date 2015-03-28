namespace SalesforceRest
{
    partial class RestAPIClient
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
            this.CB_Method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_URI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_GO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Host = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_SessionID = new System.Windows.Forms.TextBox();
            this.RTB_Response = new System.Windows.Forms.RichTextBox();
            this.RTB_RequestBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method:";
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
            this.CB_Method.Location = new System.Drawing.Point(66, 56);
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.Size = new System.Drawing.Size(139, 20);
            this.CB_Method.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "URI:";
            // 
            // TB_URI
            // 
            this.TB_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_URI.Location = new System.Drawing.Point(313, 56);
            this.TB_URI.Name = "TB_URI";
            this.TB_URI.Size = new System.Drawing.Size(492, 21);
            this.TB_URI.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Request Body (Optional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Response:";
            // 
            // BTN_GO
            // 
            this.BTN_GO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_GO.Location = new System.Drawing.Point(731, 185);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(75, 21);
            this.BTN_GO.TabIndex = 10;
            this.BTN_GO.Text = "Get Data";
            this.BTN_GO.UseVisualStyleBackColor = true;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Host:";
            // 
            // TB_Host
            // 
            this.TB_Host.Location = new System.Drawing.Point(66, 22);
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.Size = new System.Drawing.Size(139, 21);
            this.TB_Host.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "SessionID:";
            // 
            // TB_SessionID
            // 
            this.TB_SessionID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_SessionID.Location = new System.Drawing.Point(313, 22);
            this.TB_SessionID.Name = "TB_SessionID";
            this.TB_SessionID.Size = new System.Drawing.Size(492, 21);
            this.TB_SessionID.TabIndex = 3;
            // 
            // RTB_Response
            // 
            this.RTB_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Response.Location = new System.Drawing.Point(13, 243);
            this.RTB_Response.Name = "RTB_Response";
            this.RTB_Response.Size = new System.Drawing.Size(793, 172);
            this.RTB_Response.TabIndex = 12;
            this.RTB_Response.Text = "";
            // 
            // RTB_RequestBody
            // 
            this.RTB_RequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_RequestBody.Location = new System.Drawing.Point(14, 105);
            this.RTB_RequestBody.Name = "RTB_RequestBody";
            this.RTB_RequestBody.Size = new System.Drawing.Size(791, 73);
            this.RTB_RequestBody.TabIndex = 9;
            this.RTB_RequestBody.Text = "";
            // 
            // RestAPIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 442);
            this.Controls.Add(this.RTB_RequestBody);
            this.Controls.Add(this.RTB_Response);
            this.Controls.Add(this.TB_SessionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Host);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_GO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_URI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Method);
            this.Controls.Add(this.label1);
            this.Name = "RestAPIClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest API Client";
            this.Load += new System.EventHandler(this.RestClient_Load);
            this.Shown += new System.EventHandler(this.RestAPIClient_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_URI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_GO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Host;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_SessionID;
        private System.Windows.Forms.RichTextBox RTB_Response;
        private System.Windows.Forms.RichTextBox RTB_RequestBody;
    }
}

