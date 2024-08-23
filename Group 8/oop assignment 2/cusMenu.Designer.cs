namespace oop_assignment_2
{
    partial class cusMenu
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
            this.cusProfileBtn = new System.Windows.Forms.Button();
            this.cusNameLbl = new System.Windows.Forms.Label();
            this.cusViewBtn = new System.Windows.Forms.Button();
            this.cusBackbtn = new System.Windows.Forms.Button();
            this.cusChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cusProfileBtn
            // 
            this.cusProfileBtn.Location = new System.Drawing.Point(83, 61);
            this.cusProfileBtn.Name = "cusProfileBtn";
            this.cusProfileBtn.Size = new System.Drawing.Size(83, 46);
            this.cusProfileBtn.TabIndex = 0;
            this.cusProfileBtn.Text = "Change Profile";
            this.cusProfileBtn.UseVisualStyleBackColor = true;
            this.cusProfileBtn.Click += new System.EventHandler(this.cusProfileBtn_Click);
            // 
            // cusNameLbl
            // 
            this.cusNameLbl.AutoSize = true;
            this.cusNameLbl.Location = new System.Drawing.Point(172, 76);
            this.cusNameLbl.Name = "cusNameLbl";
            this.cusNameLbl.Size = new System.Drawing.Size(104, 16);
            this.cusNameLbl.TabIndex = 1;
            this.cusNameLbl.Text = "Customer Name";
            this.cusNameLbl.Click += new System.EventHandler(this.cusNameLbl_Click);
            // 
            // cusViewBtn
            // 
            this.cusViewBtn.Location = new System.Drawing.Point(83, 133);
            this.cusViewBtn.Name = "cusViewBtn";
            this.cusViewBtn.Size = new System.Drawing.Size(616, 91);
            this.cusViewBtn.TabIndex = 2;
            this.cusViewBtn.Text = "Service Description";
            this.cusViewBtn.UseVisualStyleBackColor = true;
            this.cusViewBtn.Click += new System.EventHandler(this.cusViewBtn_Click);
            // 
            // cusBackbtn
            // 
            this.cusBackbtn.Location = new System.Drawing.Point(83, 271);
            this.cusBackbtn.Name = "cusBackbtn";
            this.cusBackbtn.Size = new System.Drawing.Size(156, 23);
            this.cusBackbtn.TabIndex = 3;
            this.cusBackbtn.Text = "Back";
            this.cusBackbtn.UseVisualStyleBackColor = true;
            this.cusBackbtn.Click += new System.EventHandler(this.cusBackbtn_Click);
            // 
            // cusChangeBtn
            // 
            this.cusChangeBtn.Location = new System.Drawing.Point(543, 271);
            this.cusChangeBtn.Name = "cusChangeBtn";
            this.cusChangeBtn.Size = new System.Drawing.Size(156, 23);
            this.cusChangeBtn.TabIndex = 4;
            this.cusChangeBtn.Text = "Change Service";
            this.cusChangeBtn.UseVisualStyleBackColor = true;
            this.cusChangeBtn.Click += new System.EventHandler(this.cusChangeBtn_Click);
            // 
            // cusMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cusChangeBtn);
            this.Controls.Add(this.cusBackbtn);
            this.Controls.Add(this.cusViewBtn);
            this.Controls.Add(this.cusNameLbl);
            this.Controls.Add(this.cusProfileBtn);
            this.Name = "cusMenu";
            this.Text = "cusMenu";
            this.Load += new System.EventHandler(this.cusMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cusProfileBtn;
        private System.Windows.Forms.Label cusNameLbl;
        private System.Windows.Forms.Button cusViewBtn;
        private System.Windows.Forms.Button cusBackbtn;
        private System.Windows.Forms.Button cusChangeBtn;
    }
}

