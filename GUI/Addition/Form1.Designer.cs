
namespace Addition
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
            this.m_tbA = new System.Windows.Forms.TextBox();
            this.m_tbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblSum = new System.Windows.Forms.Label();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_tbA
            // 
            this.m_tbA.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbA.Location = new System.Drawing.Point(25, 69);
            this.m_tbA.Name = "m_tbA";
            this.m_tbA.Size = new System.Drawing.Size(100, 52);
            this.m_tbA.TabIndex = 0;
            this.m_tbA.TextChanged += new System.EventHandler(this.m_tbA_TextChanged);
            // 
            // m_tbB
            // 
            this.m_tbB.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbB.Location = new System.Drawing.Point(201, 69);
            this.m_tbB.Name = "m_tbB";
            this.m_tbB.Size = new System.Drawing.Size(100, 52);
            this.m_tbB.TabIndex = 1;
            this.m_tbB.TextChanged += new System.EventHandler(this.m_tbB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(307, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // m_lblSum
            // 
            this.m_lblSum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_lblSum.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblSum.Location = new System.Drawing.Point(356, 69);
            this.m_lblSum.Name = "m_lblSum";
            this.m_lblSum.Size = new System.Drawing.Size(156, 52);
            this.m_lblSum.TabIndex = 4;
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Enabled = false;
            this.m_btnAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnAdd.Location = new System.Drawing.Point(25, 140);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(487, 55);
            this.m_btnAdd.TabIndex = 6;
            this.m_btnAdd.Text = "Addiere";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Super toller Addierer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_btnAdd);
            this.Controls.Add(this.m_lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbB);
            this.Controls.Add(this.m_tbA);
            this.Name = "Form1";
            this.Text = "Addierer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbA;
        private System.Windows.Forms.TextBox m_tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblSum;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Label label4;
    }
}

