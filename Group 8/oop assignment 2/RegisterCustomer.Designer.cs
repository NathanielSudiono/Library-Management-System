namespace oop_assignment_2
{
    partial class RegisterCustomer
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
            this.lblUser = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.fullTxt = new System.Windows.Forms.TextBox();
            this.lblFull = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.birthdayTxt = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.serviceList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnRegister2 = new System.Windows.Forms.Button();
            this.servicesTxt = new System.Windows.Forms.TextBox();
            this.urgencyLbl = new System.Windows.Forms.Label();
            this.urgencyTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(47, 31);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username :";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(122, 31);
            this.userTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(121, 23);
            this.userTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(122, 60);
            this.passTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(121, 23);
            this.passTxt.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(47, 60);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(63, 15);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password :";
            // 
            // fullTxt
            // 
            this.fullTxt.Location = new System.Drawing.Point(122, 89);
            this.fullTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fullTxt.Name = "fullTxt";
            this.fullTxt.Size = new System.Drawing.Size(121, 23);
            this.fullTxt.TabIndex = 5;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(41, 89);
            this.lblFull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(67, 15);
            this.lblFull.TabIndex = 4;
            this.lblFull.Text = "Full Name :";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(122, 116);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(121, 23);
            this.emailTxt.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(64, 116);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail :";
            // 
            // birthdayTxt
            // 
            this.birthdayTxt.Location = new System.Drawing.Point(122, 146);
            this.birthdayTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.birthdayTxt.Name = "birthdayTxt";
            this.birthdayTxt.Size = new System.Drawing.Size(121, 23);
            this.birthdayTxt.TabIndex = 11;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(47, 146);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(57, 15);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "Birthday :";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(5, 175);
            this.lblServices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(95, 15);
            this.lblServices.TabIndex = 12;
            this.lblServices.Text = "Service number :";
            this.lblServices.Click += new System.EventHandler(this.lblServices_Click);
            // 
            // serviceList
            // 
            this.serviceList.FormattingEnabled = true;
            this.serviceList.ItemHeight = 15;
            this.serviceList.Items.AddRange(new object[] {
            "1. Remove virus, malware or spyware",
            "2. Troubleshoot and fix computer running slow",
            "3. Laptop screen replacement",
            "4. Laptop keyboard replacement",
            "5. Laptop battery replacement",
            "6. Operating System Format and Installation",
            "7. Data backup and recovery",
            "8. Internet connectivity issues"});
            this.serviceList.Location = new System.Drawing.Point(294, 31);
            this.serviceList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(292, 124);
            this.serviceList.TabIndex = 13;
            this.serviceList.SelectedIndexChanged += new System.EventHandler(this.serviceList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "REGISTER CUSTOMER";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(70, 283);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 30);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // btnRegister2
            // 
            this.btnRegister2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegister2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegister2.Location = new System.Drawing.Point(272, 283);
            this.btnRegister2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRegister2.Name = "btnRegister2";
            this.btnRegister2.Size = new System.Drawing.Size(81, 30);
            this.btnRegister2.TabIndex = 18;
            this.btnRegister2.Text = "REGISTER";
            this.btnRegister2.UseVisualStyleBackColor = false;
            this.btnRegister2.Click += new System.EventHandler(this.btnRegister2_Click);
            // 
            // servicesTxt
            // 
            this.servicesTxt.Location = new System.Drawing.Point(122, 175);
            this.servicesTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.servicesTxt.Name = "servicesTxt";
            this.servicesTxt.Size = new System.Drawing.Size(121, 23);
            this.servicesTxt.TabIndex = 19;
            // 
            // urgencyLbl
            // 
            this.urgencyLbl.AutoSize = true;
            this.urgencyLbl.Location = new System.Drawing.Point(47, 204);
            this.urgencyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urgencyLbl.Name = "urgencyLbl";
            this.urgencyLbl.Size = new System.Drawing.Size(57, 15);
            this.urgencyLbl.TabIndex = 20;
            this.urgencyLbl.Text = "Urgency :";
            // 
            // urgencyTxt
            // 
            this.urgencyTxt.Location = new System.Drawing.Point(122, 204);
            this.urgencyTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.urgencyTxt.Name = "urgencyTxt";
            this.urgencyTxt.Size = new System.Drawing.Size(121, 23);
            this.urgencyTxt.TabIndex = 21;
            this.urgencyTxt.TextChanged += new System.EventHandler(this.urgencyTxt_TextChanged);
            // 
            // RegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 338);
            this.Controls.Add(this.urgencyTxt);
            this.Controls.Add(this.urgencyLbl);
            this.Controls.Add(this.servicesTxt);
            this.Controls.Add(this.btnRegister2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.birthdayTxt);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.fullTxt);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "RegisterCustomer";
            this.Text = "Register Customer Form";
            this.Load += new System.EventHandler(this.RegisterCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUser;
        private TextBox userTxt;
        private TextBox passTxt;
        private Label lblPass;
        private TextBox fullTxt;
        private Label lblFull;
        private TextBox emailTxt;
        private Label lblEmail;
        private TextBox birthdayTxt;
        private Label lblBirthday;
        private Label lblServices;
        private ListBox serviceList;
        private Label label8;
        private Button cancelBtn;
        private Button btnRegister2;
        private TextBox servicesTxt;
        private Label urgencyLbl;
        private TextBox urgencyTxt;
    }
}