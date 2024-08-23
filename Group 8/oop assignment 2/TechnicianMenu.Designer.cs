namespace oop_assignment_2
{
    partial class TechnicianMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnUpdaterder = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(256, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TECHNICIAN MENU";
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewOrder.Location = new System.Drawing.Point(291, 94);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(217, 52);
            this.btnViewOrder.TabIndex = 1;
            this.btnViewOrder.Text = "VIEW SERVICE ORDERS";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnUpdaterder
            // 
            this.btnUpdaterder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdaterder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdaterder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdaterder.Location = new System.Drawing.Point(291, 174);
            this.btnUpdaterder.Name = "btnUpdaterder";
            this.btnUpdaterder.Size = new System.Drawing.Size(217, 52);
            this.btnUpdaterder.TabIndex = 2;
            this.btnUpdaterder.Text = "UPDATE SERVICE ORDER";
            this.btnUpdaterder.UseVisualStyleBackColor = false;
            this.btnUpdaterder.Click += new System.EventHandler(this.btnUpdaterder_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateProfile.Location = new System.Drawing.Point(291, 254);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(217, 52);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "UPDATE PROFILE";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // TechnicianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnUpdaterder);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.lblTitle);
            this.Name = "TechnicianMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TechnicianMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnViewOrder;
        private Button btnUpdaterder;
        private Button btnUpdateProfile;
    }
}