
namespace KlickMich
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
            this.m_btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnClickMe
            // 
            this.m_btnClickMe.Location = new System.Drawing.Point(72, 126);
            this.m_btnClickMe.Name = "m_btnClickMe";
            this.m_btnClickMe.Size = new System.Drawing.Size(145, 63);
            this.m_btnClickMe.TabIndex = 0;
            this.m_btnClickMe.Text = "Klick mich";
            this.m_btnClickMe.UseVisualStyleBackColor = true;
            this.m_btnClickMe.Click += new System.EventHandler(this.m_btnClickMe_Click);
            this.m_btnClickMe.MouseEnter += new System.EventHandler(this.m_btnClickMe_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 518);
            this.Controls.Add(this.m_btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnClickMe;
    }
}

