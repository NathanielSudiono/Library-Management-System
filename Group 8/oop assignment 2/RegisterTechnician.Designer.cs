namespace oop_assignment_2
{
    partial class RegisterTechnichian
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
            this.RegLbl = new System.Windows.Forms.Label();
            this.ConBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BirthTxt = new System.Windows.Forms.TextBox();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.MailLbl = new System.Windows.Forms.Label();
            this.BirthLbl = new System.Windows.Forms.Label();
            this.NmaeLbl = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegLbl.Location = new System.Drawing.Point(51, 34);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(427, 41);
            this.RegLbl.TabIndex = 1;
            this.RegLbl.Text = "REGISTER NEW TECHNICIAN";
            // 
            // ConBtn
            // 
            this.ConBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConBtn.ForeColor = System.Drawing.Color.White;
            this.ConBtn.Location = new System.Drawing.Point(395, 286);
            this.ConBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(82, 26);
            this.ConBtn.TabIndex = 24;
            this.ConBtn.Text = "CONFIRM";
            this.ConBtn.UseVisualStyleBackColor = false;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackBtn.Location = new System.Drawing.Point(66, 286);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 26);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BirthTxt
            // 
            this.BirthTxt.Location = new System.Drawing.Point(206, 160);
            this.BirthTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthTxt.Name = "BirthTxt";
            this.BirthTxt.Size = new System.Drawing.Size(272, 23);
            this.BirthTxt.TabIndex = 22;
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(206, 191);
            this.MailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(272, 23);
            this.MailTxt.TabIndex = 20;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(206, 127);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(272, 23);
            this.NameTxt.TabIndex = 19;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(206, 95);
            this.userTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(272, 23);
            this.userTxt.TabIndex = 18;
            // 
            // MailLbl
            // 
            this.MailLbl.AutoSize = true;
            this.MailLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MailLbl.Location = new System.Drawing.Point(66, 191);
            this.MailLbl.Name = "MailLbl";
            this.MailLbl.Size = new System.Drawing.Size(93, 15);
            this.MailLbl.TabIndex = 16;
            this.MailLbl.Text = "Email                  :";
            // 
            // BirthLbl
            // 
            this.BirthLbl.AutoSize = true;
            this.BirthLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthLbl.Location = new System.Drawing.Point(66, 160);
            this.BirthLbl.Name = "BirthLbl";
            this.BirthLbl.Size = new System.Drawing.Size(93, 15);
            this.BirthLbl.TabIndex = 15;
            this.BirthLbl.Text = "Birthday            :";
            // 
            // NmaeLbl
            // 
            this.NmaeLbl.AutoSize = true;
            this.NmaeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NmaeLbl.Location = new System.Drawing.Point(66, 127);
            this.NmaeLbl.Name = "NmaeLbl";
            this.NmaeLbl.Size = new System.Drawing.Size(93, 15);
            this.NmaeLbl.TabIndex = 14;
            this.NmaeLbl.Text = "Full name          :";
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLbl.Location = new System.Drawing.Point(66, 95);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(94, 15);
            this.UserLbl.TabIndex = 13;
            this.UserLbl.Text = "Username         :";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(206, 220);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(272, 23);
            this.PassTxt.TabIndex = 26;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassLbl.Location = new System.Drawing.Point(66, 220);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(92, 15);
            this.PassLbl.TabIndex = 25;
            this.PassLbl.Text = "Password          :";
            // 
            // RegisterTechnichian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 338);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.ConBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BirthTxt);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.MailLbl);
            this.Controls.Add(this.BirthLbl);
            this.Controls.Add(this.NmaeLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.RegLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterTechnichian";
            this.Text = "Register new technician";
            this.Load += new System.EventHandler(this.RegisterTechnichian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RegLbl;
        private Button ConBtn;
        private Button BackBtn;
        private TextBox BirthTxt;
        private TextBox MailTxt;
        private TextBox NameTxt;
        private TextBox userTxt;
        private Label MailLbl;
        private Label BirthLbl;
        private Label NmaeLbl;
        private Label UserLbl;
        private TextBox PassTxt;
        private Label PassLbl;
    }
}