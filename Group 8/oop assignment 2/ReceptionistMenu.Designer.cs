namespace oop_assignment_2
{
    partial class ReceptionistMenu
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
            this.RegCustbtn = new System.Windows.Forms.Button();
            this.CompOrderbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegCustbtn
            // 
            this.RegCustbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegCustbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RegCustbtn.Location = new System.Drawing.Point(142, 61);
            this.RegCustbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RegCustbtn.Name = "RegCustbtn";
            this.RegCustbtn.Size = new System.Drawing.Size(143, 30);
            this.RegCustbtn.TabIndex = 0;
            this.RegCustbtn.Text = "REGISTER CUSTOMER";
            this.RegCustbtn.UseVisualStyleBackColor = false;
            this.RegCustbtn.Click += new System.EventHandler(this.RegCustbtn_Click);
            // 
            // CompOrderbtn
            // 
            this.CompOrderbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CompOrderbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CompOrderbtn.Location = new System.Drawing.Point(142, 107);
            this.CompOrderbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CompOrderbtn.Name = "CompOrderbtn";
            this.CompOrderbtn.Size = new System.Drawing.Size(143, 30);
            this.CompOrderbtn.TabIndex = 1;
            this.CompOrderbtn.Text = "GENERATE RECEIPT";
            this.CompOrderbtn.UseVisualStyleBackColor = false;
            this.CompOrderbtn.Click += new System.EventHandler(this.CompOrderbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Updatebtn.Location = new System.Drawing.Point(142, 155);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(143, 30);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "UPDATE PROFILE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "RECEPTIONIST MENU";
            // 
            // ReceptionistMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.CompOrderbtn);
            this.Controls.Add(this.RegCustbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ReceptionistMenu";
            this.Text = "Receptionist Menu Form";
            this.Load += new System.EventHandler(this.ReceptionistMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegCustbtn;
        private Button CompOrderbtn;
        private Button Updatebtn;
        private Label label1;
    }
}