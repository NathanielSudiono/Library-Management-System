namespace oop_assignment_2
{
    partial class cusProfile
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.cusNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.cusBackbtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(144, 125);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(63, 15);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // cusNameLbl
            // 
            this.cusNameLbl.AutoSize = true;
            this.cusNameLbl.Location = new System.Drawing.Point(115, 77);
            this.cusNameLbl.Name = "cusNameLbl";
            this.cusNameLbl.Size = new System.Drawing.Size(94, 15);
            this.cusNameLbl.TabIndex = 2;
            this.cusNameLbl.Text = "Customer Name";
            this.cusNameLbl.Click += new System.EventHandler(this.cusNameLbl_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(144, 151);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(60, 15);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(167, 187);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(39, 15);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxt.Location = new System.Drawing.Point(214, 119);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(323, 23);
            this.usernameTxt.TabIndex = 9;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Location = new System.Drawing.Point(214, 149);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(323, 23);
            this.passwordTxt.TabIndex = 10;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.Location = new System.Drawing.Point(214, 185);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(323, 23);
            this.emailTxt.TabIndex = 13;
            // 
            // cusBackbtn
            // 
            this.cusBackbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cusBackbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cusBackbtn.Location = new System.Drawing.Point(117, 304);
            this.cusBackbtn.Name = "cusBackbtn";
            this.cusBackbtn.Size = new System.Drawing.Size(136, 22);
            this.cusBackbtn.TabIndex = 16;
            this.cusBackbtn.Text = "Back";
            this.cusBackbtn.UseVisualStyleBackColor = false;
            this.cusBackbtn.Click += new System.EventHandler(this.cusBackbtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Location = new System.Drawing.Point(442, 304);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(136, 22);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cusProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cusBackbtn);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.cusNameLbl);
            this.Controls.Add(this.usernameLbl);
            this.Name = "cusProfile";
            this.Text = "cusProfile";
            this.Load += new System.EventHandler(this.cusProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label cusNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button cusBackbtn;
        private System.Windows.Forms.Button updateBtn;
    }
}