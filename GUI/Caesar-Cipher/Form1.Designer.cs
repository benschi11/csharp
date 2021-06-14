
namespace Caesar_Cipher
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
            this.m_tbOutput = new System.Windows.Forms.TextBox();
            this.m_btnRun = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tbInput
            // 
            this.m_tbInput.Location = new System.Drawing.Point(12, 131);
            this.m_tbInput.Multiline = true;
            this.m_tbInput.Name = "m_tbInput";
            this.m_tbInput.Size = new System.Drawing.Size(882, 224);
            this.m_tbInput.TabIndex = 0;
            // 
            // m_tbOutput
            // 
            this.m_tbOutput.Location = new System.Drawing.Point(12, 410);
            this.m_tbOutput.Multiline = true;
            this.m_tbOutput.Name = "m_tbOutput";
            this.m_tbOutput.Size = new System.Drawing.Size(882, 224);
            this.m_tbOutput.TabIndex = 1;
            // 
            // m_btnRun
            // 
            this.m_btnRun.Location = new System.Drawing.Point(12, 361);
            this.m_btnRun.Name = "m_btnRun";
            this.m_btnRun.Size = new System.Drawing.Size(882, 43);
            this.m_btnRun.TabIndex = 2;
            this.m_btnRun.Text = "Do magic";
            this.m_btnRun.UseVisualStyleBackColor = true;
            this.m_btnRun.Click += new System.EventHandler(this.m_btnRun_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Verschlüsseln";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Entschlüsseln";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(693, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methode";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnRun);
            this.Controls.Add(this.m_tbOutput);
            this.Controls.Add(this.m_tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbInput;
        private System.Windows.Forms.TextBox m_tbOutput;
        private System.Windows.Forms.Button m_btnRun;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

