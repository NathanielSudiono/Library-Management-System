namespace oop_assignment_2
{
    partial class cusChangeServices
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
            this.cusNameLbl = new System.Windows.Forms.Label();
            this.changeToLbl = new System.Windows.Forms.Label();
            this.changeToLb = new System.Windows.Forms.ListBox();
            this.cusBackbtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cusNameLbl
            // 
            this.cusNameLbl.AutoSize = true;
            this.cusNameLbl.Location = new System.Drawing.Point(67, 49);
            this.cusNameLbl.Name = "cusNameLbl";
            this.cusNameLbl.Size = new System.Drawing.Size(94, 15);
            this.cusNameLbl.TabIndex = 3;
            this.cusNameLbl.Text = "Customer Name";
            // 
            // changeToLbl
            // 
            this.changeToLbl.AutoSize = true;
            this.changeToLbl.Location = new System.Drawing.Point(67, 107);
            this.changeToLbl.Name = "changeToLbl";
            this.changeToLbl.Size = new System.Drawing.Size(66, 15);
            this.changeToLbl.TabIndex = 5;
            this.changeToLbl.Text = "Change To:";
            // 
            // changeToLb
            // 
            this.changeToLb.FormattingEnabled = true;
            this.changeToLb.ItemHeight = 15;
            this.changeToLb.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshoot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.changeToLb.Location = new System.Drawing.Point(140, 107);
            this.changeToLb.Name = "changeToLb";
            this.changeToLb.Size = new System.Drawing.Size(439, 124);
            this.changeToLb.TabIndex = 6;
            this.changeToLb.SelectedIndexChanged += new System.EventHandler(this.changeToLb_SelectedIndexChanged);
            // 
            // cusBackbtn
            // 
            this.cusBackbtn.Location = new System.Drawing.Point(70, 236);
            this.cusBackbtn.Name = "cusBackbtn";
            this.cusBackbtn.Size = new System.Drawing.Size(136, 22);
            this.cusBackbtn.TabIndex = 17;
            this.cusBackbtn.Text = "Back";
            this.cusBackbtn.UseVisualStyleBackColor = true;
            this.cusBackbtn.Click += new System.EventHandler(this.cusBackbtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(442, 236);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(136, 22);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cusChangeServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cusBackbtn);
            this.Controls.Add(this.changeToLb);
            this.Controls.Add(this.changeToLbl);
            this.Controls.Add(this.cusNameLbl);
            this.Name = "cusChangeServices";
            this.Text = "cusChangeServices";
            this.Load += new System.EventHandler(this.cusChangeServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cusNameLbl;
        private System.Windows.Forms.Label changeToLbl;
        private System.Windows.Forms.ListBox changeToLb;
        private System.Windows.Forms.Button cusBackbtn;
        private System.Windows.Forms.Button updateBtn;
    }
}