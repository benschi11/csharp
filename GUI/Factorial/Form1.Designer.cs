
namespace Factorial
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
            this.m_tbInput = new System.Windows.Forms.TextBox();
            this.m_btnCalc = new System.Windows.Forms.Button();
            this.m_lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_tbInput
            // 
            this.m_tbInput.Location = new System.Drawing.Point(12, 33);
            this.m_tbInput.Name = "m_tbInput";
            this.m_tbInput.Size = new System.Drawing.Size(130, 27);
            this.m_tbInput.TabIndex = 0;
            // 
            // m_btnCalc
            // 
            this.m_btnCalc.Location = new System.Drawing.Point(160, 33);
            this.m_btnCalc.Name = "m_btnCalc";
            this.m_btnCalc.Size = new System.Drawing.Size(155, 29);
            this.m_btnCalc.TabIndex = 1;
            this.m_btnCalc.Text = "Berechne";
            this.m_btnCalc.UseVisualStyleBackColor = true;
            this.m_btnCalc.Click += new System.EventHandler(this.m_btnCalc_Click);
            // 
            // m_lblOutput
            // 
            this.m_lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_lblOutput.Location = new System.Drawing.Point(335, 33);
            this.m_lblOutput.Name = "m_lblOutput";
            this.m_lblOutput.Size = new System.Drawing.Size(437, 27);
            this.m_lblOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 106);
            this.Controls.Add(this.m_lblOutput);
            this.Controls.Add(this.m_btnCalc);
            this.Controls.Add(this.m_tbInput);
            this.Name = "Form1";
            this.Text = "Fakultätsrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbInput;
        private System.Windows.Forms.Button m_btnCalc;
        private System.Windows.Forms.Label m_lblOutput;
    }
}

