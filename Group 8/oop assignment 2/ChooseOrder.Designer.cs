namespace oop_assignment_2
{
    partial class ChooseOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbPendingService = new System.Windows.Forms.ComboBox();
            this.lblServiceResult = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblPendingService = new System.Windows.Forms.Label();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUrgencyResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(207, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "UPDATE SERVICE ORDERS";
            // 
            // cmbPendingService
            // 
            this.cmbPendingService.FormattingEnabled = true;
            this.cmbPendingService.Location = new System.Drawing.Point(416, 107);
            this.cmbPendingService.Name = "cmbPendingService";
            this.cmbPendingService.Size = new System.Drawing.Size(121, 23);
            this.cmbPendingService.TabIndex = 17;
            this.cmbPendingService.SelectedIndexChanged += new System.EventHandler(this.cmbPendingService_SelectedIndexChanged);
            // 
            // lblServiceResult
            // 
            this.lblServiceResult.AutoSize = true;
            this.lblServiceResult.Location = new System.Drawing.Point(416, 193);
            this.lblServiceResult.Name = "lblServiceResult";
            this.lblServiceResult.Size = new System.Drawing.Size(0, 15);
            this.lblServiceResult.TabIndex = 16;
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Location = new System.Drawing.Point(416, 152);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(0, 15);
            this.lblNameResult.TabIndex = 15;
            // 
            // lblPendingService
            // 
            this.lblPendingService.AutoSize = true;
            this.lblPendingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingService.Location = new System.Drawing.Point(163, 106);
            this.lblPendingService.Name = "lblPendingService";
            this.lblPendingService.Size = new System.Drawing.Size(225, 20);
            this.lblPendingService.TabIndex = 14;
            this.lblPendingService.Text = "Choose a pending service :";
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrgency.Location = new System.Drawing.Point(163, 227);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(132, 20);
            this.lblUrgency.TabIndex = 13;
            this.lblUrgency.Text = "Urgency Level :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblService.Location = new System.Drawing.Point(163, 188);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(78, 20);
            this.lblService.TabIndex = 12;
            this.lblService.Text = "Service :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(163, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name :";
            // 
            // lblUrgencyResult
            // 
            this.lblUrgencyResult.AutoSize = true;
            this.lblUrgencyResult.Location = new System.Drawing.Point(416, 231);
            this.lblUrgencyResult.Name = "lblUrgencyResult";
            this.lblUrgencyResult.Size = new System.Drawing.Size(0, 15);
            this.lblUrgencyResult.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(25, 357);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinue.Location = new System.Drawing.Point(647, 357);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(121, 37);
            this.btnContinue.TabIndex = 20;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // ChooseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUrgencyResult);
            this.Controls.Add(this.cmbPendingService);
            this.Controls.Add(this.lblServiceResult);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblPendingService);
            this.Controls.Add(this.lblUrgency);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "ChooseOrder";
            this.Text = "ChooseOrder";
            this.Load += new System.EventHandler(this.ChooseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbPendingService;
        private Label lblServiceResult;
        private Label lblNameResult;
        private Label lblPendingService;
        private Label lblUrgency;
        private Label lblService;
        private Label lblName;
        private Label lblUrgencyResult;
        private Button btnBack;
        private Button btnContinue;
    }
}