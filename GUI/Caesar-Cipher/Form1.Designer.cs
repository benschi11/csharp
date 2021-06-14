
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
            this.m_rbEncrypt = new System.Windows.Forms.RadioButton();
            this.m_rbDecrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.m_tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tbInput
            // 
            this.m_tbInput.Location = new System.Drawing.Point(10, 98);
            this.m_tbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_tbInput.Multiline = true;
            this.m_tbInput.Name = "m_tbInput";
            this.m_tbInput.Size = new System.Drawing.Size(772, 169);
            this.m_tbInput.TabIndex = 0;
            // 
            // m_tbOutput
            // 
            this.m_tbOutput.Location = new System.Drawing.Point(10, 308);
            this.m_tbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_tbOutput.Multiline = true;
            this.m_tbOutput.Name = "m_tbOutput";
            this.m_tbOutput.Size = new System.Drawing.Size(772, 169);
            this.m_tbOutput.TabIndex = 1;
            // 
            // m_btnRun
            // 
            this.m_btnRun.Location = new System.Drawing.Point(10, 271);
            this.m_btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btnRun.Name = "m_btnRun";
            this.m_btnRun.Size = new System.Drawing.Size(772, 32);
            this.m_btnRun.TabIndex = 2;
            this.m_btnRun.Text = "Do magic";
            this.m_btnRun.UseVisualStyleBackColor = true;
            this.m_btnRun.Click += new System.EventHandler(this.m_btnRun_Click);
            // 
            // m_rbEncrypt
            // 
            this.m_rbEncrypt.AutoSize = true;
            this.m_rbEncrypt.Location = new System.Drawing.Point(16, 20);
            this.m_rbEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_rbEncrypt.Name = "m_rbEncrypt";
            this.m_rbEncrypt.Size = new System.Drawing.Size(95, 19);
            this.m_rbEncrypt.TabIndex = 3;
            this.m_rbEncrypt.TabStop = true;
            this.m_rbEncrypt.Text = "Verschlüsseln";
            this.m_rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // m_rbDecrypt
            // 
            this.m_rbDecrypt.AutoSize = true;
            this.m_rbDecrypt.Location = new System.Drawing.Point(16, 42);
            this.m_rbDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_rbDecrypt.Name = "m_rbDecrypt";
            this.m_rbDecrypt.Size = new System.Drawing.Size(96, 19);
            this.m_rbDecrypt.TabIndex = 4;
            this.m_rbDecrypt.TabStop = true;
            this.m_rbDecrypt.Text = "Entschlüsseln";
            this.m_rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rbEncrypt);
            this.groupBox1.Controls.Add(this.m_rbDecrypt);
            this.groupBox1.Location = new System.Drawing.Point(606, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(158, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methode";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // m_tbKey
            // 
            this.m_tbKey.Location = new System.Drawing.Point(474, 51);
            this.m_tbKey.Name = "m_tbKey";
            this.m_tbKey.Size = new System.Drawing.Size(100, 23);
            this.m_tbKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnRun);
            this.Controls.Add(this.m_tbOutput);
            this.Controls.Add(this.m_tbInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RadioButton m_rbEncrypt;
        private System.Windows.Forms.RadioButton m_rbDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox m_tbKey;
        private System.Windows.Forms.Label label1;
    }
}

