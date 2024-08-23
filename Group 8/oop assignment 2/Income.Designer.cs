namespace oop_assignment_2
{
    partial class Income
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
            this.Serv2Lbl = new System.Windows.Forms.Label();
            this.Data2Table = new System.Windows.Forms.DataGridView();
            this.BckBtn = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data2Table)).BeginInit();
            this.Sign.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serv2Lbl
            // 
            this.Serv2Lbl.AutoSize = true;
            this.Serv2Lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv2Lbl.Location = new System.Drawing.Point(220, 38);
            this.Serv2Lbl.Name = "Serv2Lbl";
            this.Serv2Lbl.Size = new System.Drawing.Size(182, 54);
            this.Serv2Lbl.TabIndex = 0;
            this.Serv2Lbl.Text = "INCOME";
            // 
            // Data2Table
            // 
            this.Data2Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2Table.Location = new System.Drawing.Point(47, 116);
            this.Data2Table.Name = "Data2Table";
            this.Data2Table.RowHeadersWidth = 51;
            this.Data2Table.RowTemplate.Height = 29;
            this.Data2Table.Size = new System.Drawing.Size(550, 147);
            this.Data2Table.TabIndex = 1;
            this.Data2Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data2Table_CellContentClick);
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BckBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BckBtn.Location = new System.Drawing.Point(249, 386);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(128, 35);
            this.BckBtn.TabIndex = 3;
            this.BckBtn.Text = "BACK TO MENU";
            this.BckBtn.UseVisualStyleBackColor = false;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // TotalBtn
            // 
            this.TotalBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TotalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalBtn.Location = new System.Drawing.Point(269, 341);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(94, 29);
            this.TotalBtn.TabIndex = 4;
            this.TotalBtn.Text = "TOTAL";
            this.TotalBtn.UseVisualStyleBackColor = false;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(42, 38);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(27, 20);
            this.Total.TabIndex = 6;
            this.Total.Text = "---";
            // 
            // Sign
            // 
            this.Sign.Controls.Add(this.Total);
            this.Sign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sign.Location = new System.Drawing.Point(459, 289);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(117, 81);
            this.Sign.TabIndex = 7;
            this.Sign.TabStop = false;
            this.Sign.Text = "Total";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.TotalBtn);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.Data2Table);
            this.Controls.Add(this.Serv2Lbl);
            this.Name = "Income";
            this.Text = "Monthly income";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data2Table)).EndInit();
            this.Sign.ResumeLayout(false);
            this.Sign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Serv2Lbl;
        private DataGridView Data2Table;
        private Button BckBtn;
        private Button TotalBtn;
        private Label Total;
        private GroupBox Sign;
    }
}