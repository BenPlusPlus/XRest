namespace XRestDemo
{
    partial class frmDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubUri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTokenUrl = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.btnTokenTest = new System.Windows.Forms.Button();
            this.txtClientResource = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(12, 25);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.PlaceholderText = "https://example.com/api/";
            this.txtBaseUrl.Size = new System.Drawing.Size(374, 23);
            this.txtBaseUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base URL:";
            // 
            // txtSubUri
            // 
            this.txtSubUri.Location = new System.Drawing.Point(13, 238);
            this.txtSubUri.Name = "txtSubUri";
            this.txtSubUri.PlaceholderText = "methodname/{id}";
            this.txtSubUri.Size = new System.Drawing.Size(189, 23);
            this.txtSubUri.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub URI:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 10);
            this.label3.TabIndex = 2;
            // 
            // cboMethod
            // 
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cboMethod.Location = new System.Drawing.Point(205, 238);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(154, 23);
            this.cboMethod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "HTTP method:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(234, 436);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(154, 38);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(419, 238);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(369, 235);
            this.txtResult.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Result:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 282);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(376, 148);
            this.txtInput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Input:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Authentication:";
            // 
            // txtTokenUrl
            // 
            this.txtTokenUrl.Location = new System.Drawing.Point(419, 25);
            this.txtTokenUrl.Name = "txtTokenUrl";
            this.txtTokenUrl.PlaceholderText = "https://example.com/oauth2/token/";
            this.txtTokenUrl.Size = new System.Drawing.Size(369, 23);
            this.txtTokenUrl.TabIndex = 0;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(503, 54);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(285, 23);
            this.txtClientId.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Client ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Client secret:";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(503, 83);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(285, 23);
            this.txtClientSecret.TabIndex = 0;
            // 
            // btnTokenTest
            // 
            this.btnTokenTest.Location = new System.Drawing.Point(689, 155);
            this.btnTokenTest.Name = "btnTokenTest";
            this.btnTokenTest.Size = new System.Drawing.Size(99, 34);
            this.btnTokenTest.TabIndex = 7;
            this.btnTokenTest.Text = "Token test";
            this.btnTokenTest.UseVisualStyleBackColor = true;
            this.btnTokenTest.Click += new System.EventHandler(this.btnTokenTest_Click);
            // 
            // txtClientResource
            // 
            this.txtClientResource.Location = new System.Drawing.Point(503, 112);
            this.txtClientResource.Name = "txtClientResource";
            this.txtClientResource.Size = new System.Drawing.Size(285, 23);
            this.txtClientResource.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Resource:";
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.txtClientResource);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTokenTest);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtTokenUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubUri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaseUrl);
            this.Name = "frmDemo";
            this.Text = "XRest Library Demo";
            this.Load += new System.EventHandler(this.frmDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubUri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTokenUrl;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Button btnTokenTest;
        private System.Windows.Forms.TextBox txtClientResource;
        private System.Windows.Forms.Label label10;
    }
}

