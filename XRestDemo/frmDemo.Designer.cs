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
            this.SuspendLayout();
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(12, 25);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.PlaceholderText = "https://example.com/api/";
            this.txtBaseUrl.Size = new System.Drawing.Size(433, 23);
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
            this.txtSubUri.Location = new System.Drawing.Point(12, 109);
            this.txtSubUri.Name = "txtSubUri";
            this.txtSubUri.PlaceholderText = "methodname/{id}";
            this.txtSubUri.Size = new System.Drawing.Size(189, 23);
            this.txtSubUri.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
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
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 4);
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
            this.cboMethod.Location = new System.Drawing.Point(207, 109);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(154, 23);
            this.cboMethod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "HTTP method:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(232, 414);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(154, 38);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(419, 109);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(369, 343);
            this.txtResult.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Result:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 165);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(376, 243);
            this.txtInput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Input:";
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
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
    }
}

