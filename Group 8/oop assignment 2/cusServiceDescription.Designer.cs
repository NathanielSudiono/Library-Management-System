namespace oop_assignment_2
{
    partial class cusServiceDescription
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
            this.cusNameLbl = new System.Windows.Forms.Label();
            this.cusBackbtn = new System.Windows.Forms.Button();
            this.dgvServiceDescription = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // cusNameLbl
            // 
            this.cusNameLbl.AutoSize = true;
            this.cusNameLbl.Location = new System.Drawing.Point(88, 45);
            this.cusNameLbl.Name = "cusNameLbl";
            this.cusNameLbl.Size = new System.Drawing.Size(94, 15);
            this.cusNameLbl.TabIndex = 2;
            this.cusNameLbl.Text = "Customer Name";
            this.cusNameLbl.Click += new System.EventHandler(this.cusNameLbl_Click);
            // 
            // cusBackbtn
            // 
            this.cusBackbtn.Location = new System.Drawing.Point(88, 304);
            this.cusBackbtn.Name = "cusBackbtn";
            this.cusBackbtn.Size = new System.Drawing.Size(136, 22);
            this.cusBackbtn.TabIndex = 4;
            this.cusBackbtn.Text = "Back";
            this.cusBackbtn.UseVisualStyleBackColor = true;
            this.cusBackbtn.Click += new System.EventHandler(this.cusBackbtn_Click);
            // 
            // dgvServiceDescription
            // 
            this.dgvServiceDescription.AllowUserToAddRows = false;
            this.dgvServiceDescription.AllowUserToDeleteRows = false;
            this.dgvServiceDescription.AllowUserToResizeColumns = false;
            this.dgvServiceDescription.AllowUserToResizeRows = false;
            this.dgvServiceDescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceDescription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvServiceDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDescription.Location = new System.Drawing.Point(167, 128);
            this.dgvServiceDescription.MultiSelect = false;
            this.dgvServiceDescription.Name = "dgvServiceDescription";
            this.dgvServiceDescription.ReadOnly = true;
            this.dgvServiceDescription.RowTemplate.Height = 25;
            this.dgvServiceDescription.Size = new System.Drawing.Size(394, 64);
            this.dgvServiceDescription.TabIndex = 22;
            // 
            // cusServiceDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.dgvServiceDescription);
            this.Controls.Add(this.cusBackbtn);
            this.Controls.Add(this.cusNameLbl);
            this.Name = "cusServiceDescription";
            this.Text = "cusServiceDescription";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cusNameLbl;
        private System.Windows.Forms.Button cusBackbtn;
        private DataGridView dgvServiceDescription;
    }
}