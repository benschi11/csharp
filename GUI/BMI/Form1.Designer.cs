
namespace BMI
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
            this.m_btnCalc = new System.Windows.Forms.Button();
            this.m_tbWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lblOutput = new System.Windows.Forms.Label();
            this.m_lblOutputTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnCalc
            // 
            this.m_btnCalc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnCalc.Location = new System.Drawing.Point(12, 227);
            this.m_btnCalc.Name = "m_btnCalc";
            this.m_btnCalc.Size = new System.Drawing.Size(776, 91);
            this.m_btnCalc.TabIndex = 0;
            this.m_btnCalc.Text = "Berechne BMI";
            this.m_btnCalc.UseVisualStyleBackColor = true;
            this.m_btnCalc.Click += new System.EventHandler(this.m_btnCalc_Click);
            // 
            // m_tbWeight
            // 
            this.m_tbWeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbWeight.Location = new System.Drawing.Point(222, 117);
            this.m_tbWeight.Name = "m_tbWeight";
            this.m_tbWeight.Size = new System.Drawing.Size(125, 39);
            this.m_tbWeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gewicht (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(436, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Größe (m):";
            // 
            // m_tbHeight
            // 
            this.m_tbHeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbHeight.Location = new System.Drawing.Point(567, 117);
            this.m_tbHeight.Name = "m_tbHeight";
            this.m_tbHeight.Size = new System.Drawing.Size(125, 39);
            this.m_tbHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 89);
            this.label3.TabIndex = 5;
            this.label3.Text = "BMI Rechner";
            // 
            // m_lblOutput
            // 
            this.m_lblOutput.BackColor = System.Drawing.SystemColors.HotTrack;
            this.m_lblOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.m_lblOutput.Location = new System.Drawing.Point(13, 342);
            this.m_lblOutput.Name = "m_lblOutput";
            this.m_lblOutput.Size = new System.Drawing.Size(783, 54);
            this.m_lblOutput.TabIndex = 6;
            this.m_lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lblOutputTxt
            // 
            this.m_lblOutputTxt.BackColor = System.Drawing.Color.Brown;
            this.m_lblOutputTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblOutputTxt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.m_lblOutputTxt.Location = new System.Drawing.Point(12, 407);
            this.m_lblOutputTxt.Name = "m_lblOutputTxt";
            this.m_lblOutputTxt.Size = new System.Drawing.Size(783, 54);
            this.m_lblOutputTxt.TabIndex = 7;
            this.m_lblOutputTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.m_lblOutputTxt);
            this.Controls.Add(this.m_lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_tbHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbWeight);
            this.Controls.Add(this.m_btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnCalc;
        private System.Windows.Forms.TextBox m_tbWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_lblOutput;
        private System.Windows.Forms.Label m_lblOutputTxt;
    }
}

