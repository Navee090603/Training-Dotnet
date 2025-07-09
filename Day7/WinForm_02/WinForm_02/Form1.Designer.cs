
namespace WinForm_02
{
    partial class Form1
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
            this.studentName = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.studentMark = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.rank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(219, 198);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(112, 20);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Student Name";
            this.studentName.Click += new System.EventHandler(this.studentName_Click);
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(227, 155);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(87, 20);
            this.studentId.TabIndex = 1;
            this.studentId.Text = "Student ID";
            this.studentId.Click += new System.EventHandler(this.studentId_Click);
            // 
            // studentMark
            // 
            this.studentMark.AutoSize = true;
            this.studentMark.Location = new System.Drawing.Point(227, 243);
            this.studentMark.Name = "studentMark";
            this.studentMark.Size = new System.Drawing.Size(96, 20);
            this.studentMark.TabIndex = 2;
            this.studentMark.Text = "Stdent Mark";
            this.studentMark.Click += new System.EventHandler(this.studentMark_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(433, 155);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(127, 26);
            this.id.TabIndex = 3;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(433, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(127, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(433, 243);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(127, 26);
            this.mark.TabIndex = 5;
            this.mark.TextChanged += new System.EventHandler(this.mark_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(293, 297);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(220, 37);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "ADD";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.ForeColor = System.Drawing.SystemColors.Control;
            this.view.Location = new System.Drawing.Point(583, 258);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(161, 76);
            this.view.TabIndex = 7;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // rank
            // 
            this.rank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rank.ForeColor = System.Drawing.SystemColors.Control;
            this.rank.Location = new System.Drawing.Point(583, 149);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(161, 81);
            this.rank.TabIndex = 8;
            this.rank.Text = "Rank";
            this.rank.UseVisualStyleBackColor = false;
            this.rank.Click += new System.EventHandler(this.rank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 546);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.view);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.studentMark);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.studentName);
            this.Name = "Form1";
            this.Text = "Rank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label studentMark;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button rank;
    }
}

