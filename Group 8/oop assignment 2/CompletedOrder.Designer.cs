namespace oop_assignment_2
{
    partial class CompletedOrder
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GenRecbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(63, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 79);
            this.listBox1.TabIndex = 0;
            // 
            // GenRecbtn
            // 
            this.GenRecbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GenRecbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenRecbtn.Location = new System.Drawing.Point(255, 158);
            this.GenRecbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GenRecbtn.Name = "GenRecbtn";
            this.GenRecbtn.Size = new System.Drawing.Size(135, 30);
            this.GenRecbtn.TabIndex = 19;
            this.GenRecbtn.Text = "GENERATE RECEIPT";
            this.GenRecbtn.UseVisualStyleBackColor = false;
            this.GenRecbtn.Click += new System.EventHandler(this.GenRecbtn_Click);
            // 
            // CompletedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.GenRecbtn);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CompletedOrder";
            this.Text = "CompletedOrder";
            this.Load += new System.EventHandler(this.CompletedOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button GenRecbtn;
    }
}