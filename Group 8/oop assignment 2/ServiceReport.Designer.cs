namespace oop_assignment_2
{
    partial class ServiceReport
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
            this.ServLbl = new System.Windows.Forms.Label();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.BckBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ServLbl
            // 
            this.ServLbl.AutoSize = true;
            this.ServLbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServLbl.Location = new System.Drawing.Point(161, 40);
            this.ServLbl.Name = "ServLbl";
            this.ServLbl.Size = new System.Drawing.Size(317, 50);
            this.ServLbl.TabIndex = 0;
            this.ServLbl.Text = "SERVICE REPORT";
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(56, 169);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 29;
            this.DataTable.Size = new System.Drawing.Size(553, 188);
            this.DataTable.TabIndex = 1;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BckBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BckBtn.Location = new System.Drawing.Point(259, 390);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(128, 35);
            this.BckBtn.TabIndex = 2;
            this.BckBtn.Text = "BACK TO MENU";
            this.BckBtn.UseVisualStyleBackColor = false;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // ServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.ServLbl);
            this.Name = "ServiceReport";
            this.Text = "Monthly report";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ServLbl;
        private DataGridView DataTable;
        private Button BckBtn;
    }
}