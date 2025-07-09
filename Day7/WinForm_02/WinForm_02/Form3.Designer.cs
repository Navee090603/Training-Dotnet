
namespace WinForm_02
{
    partial class Form3
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
            this.dataGridViewRanks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRanks
            // 
            this.dataGridViewRanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanks.Location = new System.Drawing.Point(47, 122);
            this.dataGridViewRanks.Name = "dataGridViewRanks";
            this.dataGridViewRanks.ReadOnly = true;
            this.dataGridViewRanks.RowHeadersWidth = 62;
            this.dataGridViewRanks.RowTemplate.Height = 28;
            this.dataGridViewRanks.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewRanks.TabIndex = 0;
            this.dataGridViewRanks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRanks_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 480);
            this.Controls.Add(this.dataGridViewRanks);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRanks;
    }
}