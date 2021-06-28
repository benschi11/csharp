
namespace Notenschnitt
{
    partial class Form1
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
            this.m_btnAddGrade = new System.Windows.Forms.Button();
            this.m_tbGrade = new System.Windows.Forms.TextBox();
            this.m_lbGrades = new System.Windows.Forms.ListBox();
            this.m_lblGradeAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btnDeleteGrade = new System.Windows.Forms.Button();
            this.m_tbFach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_btnEdit = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnAddGrade
            // 
            this.m_btnAddGrade.BackColor = System.Drawing.Color.Indigo;
            this.m_btnAddGrade.Enabled = false;
            this.m_btnAddGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnAddGrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btnAddGrade.Location = new System.Drawing.Point(347, 119);
            this.m_btnAddGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_btnAddGrade.Name = "m_btnAddGrade";
            this.m_btnAddGrade.Size = new System.Drawing.Size(139, 48);
            this.m_btnAddGrade.TabIndex = 0;
            this.m_btnAddGrade.Text = "Add";
            this.m_btnAddGrade.UseVisualStyleBackColor = false;
            this.m_btnAddGrade.Click += new System.EventHandler(this.m_btnAddGrade_Click);
            // 
            // m_tbGrade
            // 
            this.m_tbGrade.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbGrade.Location = new System.Drawing.Point(146, 127);
            this.m_tbGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tbGrade.MaxLength = 1;
            this.m_tbGrade.Name = "m_tbGrade";
            this.m_tbGrade.Size = new System.Drawing.Size(114, 43);
            this.m_tbGrade.TabIndex = 1;
            this.m_tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_tbGrade.TextChanged += new System.EventHandler(this.m_tbGrade_TextChanged);
            // 
            // m_lbGrades
            // 
            this.m_lbGrades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lbGrades.FormattingEnabled = true;
            this.m_lbGrades.ItemHeight = 28;
            this.m_lbGrades.Location = new System.Drawing.Point(66, 261);
            this.m_lbGrades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_lbGrades.Name = "m_lbGrades";
            this.m_lbGrades.Size = new System.Drawing.Size(265, 172);
            this.m_lbGrades.TabIndex = 2;
            this.m_lbGrades.SelectedIndexChanged += new System.EventHandler(this.m_lbGrades_SelectedIndexChanged);
            // 
            // m_lblGradeAverage
            // 
            this.m_lblGradeAverage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.m_lblGradeAverage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblGradeAverage.Location = new System.Drawing.Point(66, 493);
            this.m_lblGradeAverage.Name = "m_lblGradeAverage";
            this.m_lblGradeAverage.Size = new System.Drawing.Size(420, 71);
            this.m_lblGradeAverage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notenrechner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_btnDeleteGrade
            // 
            this.m_btnDeleteGrade.BackColor = System.Drawing.Color.Indigo;
            this.m_btnDeleteGrade.Enabled = false;
            this.m_btnDeleteGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnDeleteGrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btnDeleteGrade.Location = new System.Drawing.Point(347, 206);
            this.m_btnDeleteGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_btnDeleteGrade.Name = "m_btnDeleteGrade";
            this.m_btnDeleteGrade.Size = new System.Drawing.Size(139, 48);
            this.m_btnDeleteGrade.TabIndex = 5;
            this.m_btnDeleteGrade.Text = "Delete";
            this.m_btnDeleteGrade.UseVisualStyleBackColor = false;
            this.m_btnDeleteGrade.Click += new System.EventHandler(this.m_btnDeleteGrade_Click);
            // 
            // m_tbFach
            // 
            this.m_tbFach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbFach.Location = new System.Drawing.Point(146, 205);
            this.m_tbFach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tbFach.MaxLength = 1000;
            this.m_tbFach.Name = "m_tbFach";
            this.m_tbFach.Size = new System.Drawing.Size(185, 43);
            this.m_tbFach.TabIndex = 6;
            this.m_tbFach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fach:";
            // 
            // m_btnEdit
            // 
            this.m_btnEdit.BackColor = System.Drawing.Color.Indigo;
            this.m_btnEdit.Enabled = false;
            this.m_btnEdit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btnEdit.Location = new System.Drawing.Point(347, 262);
            this.m_btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_btnEdit.Name = "m_btnEdit";
            this.m_btnEdit.Size = new System.Drawing.Size(139, 48);
            this.m_btnEdit.TabIndex = 9;
            this.m_btnEdit.Text = "Edit";
            this.m_btnEdit.UseVisualStyleBackColor = false;
            this.m_btnEdit.Click += new System.EventHandler(this.m_btnEdit_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.BackColor = System.Drawing.Color.Indigo;
            this.m_btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btnCancel.Location = new System.Drawing.Point(347, 318);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(139, 48);
            this.m_btnCancel.TabIndex = 10;
            this.m_btnCancel.Text = "&Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = false;
            this.m_btnCancel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 625);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_tbFach);
            this.Controls.Add(this.m_btnDeleteGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lblGradeAverage);
            this.Controls.Add(this.m_lbGrades);
            this.Controls.Add(this.m_tbGrade);
            this.Controls.Add(this.m_btnAddGrade);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnAddGrade;
        private System.Windows.Forms.TextBox m_tbGrade;
        private System.Windows.Forms.ListBox m_lbGrades;
        private System.Windows.Forms.Label m_lblGradeAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btnDeleteGrade;
        private System.Windows.Forms.TextBox m_tbFach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_btnEdit;
        private System.Windows.Forms.Button m_btnCancel;
    }
}

