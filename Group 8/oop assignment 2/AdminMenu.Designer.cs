namespace oop_assignment_2
{
    partial class AdminMenu
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
            this.welLbl = new System.Windows.Forms.Label();
            this.RegTBtn = new System.Windows.Forms.Button();
            this.RegRBtn = new System.Windows.Forms.Button();
            this.MrepBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welLbl
            // 
            this.welLbl.AutoSize = true;
            this.welLbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welLbl.Location = new System.Drawing.Point(63, 43);
            this.welLbl.Name = "welLbl";
            this.welLbl.Size = new System.Drawing.Size(409, 41);
            this.welLbl.TabIndex = 0;
            this.welLbl.Text = "WELCOME TO ADMIN ROLE";
            // 
            // RegTBtn
            // 
            this.RegTBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegTBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegTBtn.Location = new System.Drawing.Point(206, 116);
            this.RegTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegTBtn.Name = "RegTBtn";
            this.RegTBtn.Size = new System.Drawing.Size(129, 39);
            this.RegTBtn.TabIndex = 1;
            this.RegTBtn.Text = "REGISTER FOR TECHNICIAN";
            this.RegTBtn.UseVisualStyleBackColor = false;
            this.RegTBtn.Click += new System.EventHandler(this.RegTBtn_Click);
            // 
            // RegRBtn
            // 
            this.RegRBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegRBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegRBtn.Location = new System.Drawing.Point(206, 160);
            this.RegRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegRBtn.Name = "RegRBtn";
            this.RegRBtn.Size = new System.Drawing.Size(129, 36);
            this.RegRBtn.TabIndex = 2;
            this.RegRBtn.Text = "REGISTER FOR RECEPTION";
            this.RegRBtn.UseVisualStyleBackColor = false;
            this.RegRBtn.Click += new System.EventHandler(this.RegRBtn_Click);
            // 
            // MrepBtn
            // 
            this.MrepBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MrepBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MrepBtn.Location = new System.Drawing.Point(206, 200);
            this.MrepBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MrepBtn.Name = "MrepBtn";
            this.MrepBtn.Size = new System.Drawing.Size(129, 36);
            this.MrepBtn.TabIndex = 3;
            this.MrepBtn.Text = "MONTHLY REPORT";
            this.MrepBtn.UseVisualStyleBackColor = false;
            this.MrepBtn.Click += new System.EventHandler(this.MrepBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MinBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinBtn.Location = new System.Drawing.Point(206, 241);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(129, 39);
            this.MinBtn.TabIndex = 4;
            this.MinBtn.Text = "MONTHLY INCOME";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 338);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.MrepBtn);
            this.Controls.Add(this.RegRBtn);
            this.Controls.Add(this.RegTBtn);
            this.Controls.Add(this.welLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMenu";
            this.Text = "Admin menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welLbl;
        private Button RegTBtn;
        private Button RegRBtn;
        private Button MrepBtn;
        private Button MinBtn;
    }
}