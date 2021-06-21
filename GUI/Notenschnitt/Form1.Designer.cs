
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
            this.SuspendLayout();
            // 
            // m_btnAddGrade
            // 
            this.m_btnAddGrade.BackColor = System.Drawing.Color.Indigo;
            this.m_btnAddGrade.Enabled = false;
            this.m_btnAddGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnAddGrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btnAddGrade.Location = new System.Drawing.Point(176, 90);
            this.m_btnAddGrade.Name = "m_btnAddGrade";
            this.m_btnAddGrade.Size = new System.Drawing.Size(122, 36);
            this.m_btnAddGrade.TabIndex = 0;
            this.m_btnAddGrade.Text = "Add";
            this.m_btnAddGrade.UseVisualStyleBackColor = false;
            this.m_btnAddGrade.Click += new System.EventHandler(this.m_btnAddGrade_Click);
            // 
            // m_tbGrade
            // 
            this.m_tbGrade.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbGrade.Location = new System.Drawing.Point(58, 90);
            this.m_tbGrade.MaxLength = 1;
            this.m_tbGrade.Name = "m_tbGrade";
            this.m_tbGrade.Size = new System.Drawing.Size(100, 36);
            this.m_tbGrade.TabIndex = 1;
            this.m_tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_tbGrade.TextChanged += new System.EventHandler(this.m_tbGrade_TextChanged);
            // 
            // m_lbGrades
            // 
            this.m_lbGrades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lbGrades.FormattingEnabled = true;
            this.m_lbGrades.ItemHeight = 21;
            this.m_lbGrades.Location = new System.Drawing.Point(58, 148);
            this.m_lbGrades.Name = "m_lbGrades";
            this.m_lbGrades.Size = new System.Drawing.Size(240, 130);
            this.m_lbGrades.TabIndex = 2;
            this.m_lbGrades.SelectedIndexChanged += new System.EventHandler(this.m_lbGrades_SelectedIndexChanged);
            // 
            // m_lblGradeAverage
            // 
            this.m_lblGradeAverage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.m_lblGradeAverage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblGradeAverage.Location = new System.Drawing.Point(58, 307);
            this.m_lblGradeAverage.Name = "m_lblGradeAverage";
            this.m_lblGradeAverage.Size = new System.Drawing.Size(240, 53);
            this.m_lblGradeAverage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 38);
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
            this.m_btnDeleteGrade.Location = new System.Drawing.Point(304, 148);
            this.m_btnDeleteGrade.Name = "m_btnDeleteGrade";
            this.m_btnDeleteGrade.Size = new System.Drawing.Size(122, 36);
            this.m_btnDeleteGrade.TabIndex = 5;
            this.m_btnDeleteGrade.Text = "Delete";
            this.m_btnDeleteGrade.UseVisualStyleBackColor = false;
            this.m_btnDeleteGrade.Click += new System.EventHandler(this.m_btnDeleteGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 383);
            this.Controls.Add(this.m_btnDeleteGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lblGradeAverage);
            this.Controls.Add(this.m_lbGrades);
            this.Controls.Add(this.m_tbGrade);
            this.Controls.Add(this.m_btnAddGrade);
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
    }
}

