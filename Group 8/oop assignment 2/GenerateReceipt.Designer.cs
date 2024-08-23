namespace oop_assignment_2
{
    partial class GenerateReceipt
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
            this.button1 = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.ServiceTxt = new System.Windows.Forms.Label();
            this.servicesTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(287, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(164, 18);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(110, 23);
            this.textUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fee :";
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(164, 114);
            this.feeTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(110, 23);
            this.feeTxt.TabIndex = 3;
            // 
            // ServiceTxt
            // 
            this.ServiceTxt.AutoSize = true;
            this.ServiceTxt.Location = new System.Drawing.Point(82, 82);
            this.ServiceTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceTxt.Name = "ServiceTxt";
            this.ServiceTxt.Size = new System.Drawing.Size(55, 15);
            this.ServiceTxt.TabIndex = 6;
            this.ServiceTxt.Text = "Services :";
            // 
            // servicesTxt
            // 
            this.servicesTxt.Location = new System.Drawing.Point(164, 82);
            this.servicesTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.servicesTxt.Name = "servicesTxt";
            this.servicesTxt.Size = new System.Drawing.Size(110, 23);
            this.servicesTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Full name :";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Location = new System.Drawing.Point(164, 50);
            this.fullnameTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(110, 23);
            this.fullnameTxt.TabIndex = 7;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.printBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.printBtn.Location = new System.Drawing.Point(287, 172);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(81, 22);
            this.printBtn.TabIndex = 9;
            this.printBtn.Text = "PRINT";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // GenerateReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullnameTxt);
            this.Controls.Add(this.ServiceTxt);
            this.Controls.Add(this.servicesTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GenerateReceipt";
            this.Text = "Generate Receipt Form";
            this.Load += new System.EventHandler(this.GenerateReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textUsername;
        private Label label1;
        private Label label2;
        private TextBox feeTxt;
        private Label ServiceTxt;
        private TextBox servicesTxt;
        private Label label4;
        private TextBox fullnameTxt;
        private Button printBtn;
    }
}