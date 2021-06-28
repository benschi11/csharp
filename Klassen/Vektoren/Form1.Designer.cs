
namespace Vektoren
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
            this.m_btnCreate = new System.Windows.Forms.Button();
            this.m_tbX = new System.Windows.Forms.TextBox();
            this.m_tbY = new System.Windows.Forms.TextBox();
            this.m_lbVectors = new System.Windows.Forms.ListBox();
            this.m_btnLength = new System.Windows.Forms.Button();
            this.m_lblLength = new System.Windows.Forms.Label();
            this.m_tbFactor = new System.Windows.Forms.TextBox();
            this.m_btnScale = new System.Windows.Forms.Button();
            this.m_lblScaled = new System.Windows.Forms.Label();
            this.m_cbVector1 = new System.Windows.Forms.ComboBox();
            this.m_cbOperation = new System.Windows.Forms.ComboBox();
            this.m_cbVector2 = new System.Windows.Forms.ComboBox();
            this.m_lblResult = new System.Windows.Forms.Label();
            this.m_btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnCreate
            // 
            this.m_btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnCreate.Location = new System.Drawing.Point(348, 53);
            this.m_btnCreate.Name = "m_btnCreate";
            this.m_btnCreate.Size = new System.Drawing.Size(132, 32);
            this.m_btnCreate.TabIndex = 0;
            this.m_btnCreate.Text = "&Erstellen";
            this.m_btnCreate.UseVisualStyleBackColor = true;
            this.m_btnCreate.Click += new System.EventHandler(this.m_btnCreate_Click);
            // 
            // m_tbX
            // 
            this.m_tbX.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbX.Location = new System.Drawing.Point(56, 53);
            this.m_tbX.Name = "m_tbX";
            this.m_tbX.Size = new System.Drawing.Size(100, 32);
            this.m_tbX.TabIndex = 1;
            // 
            // m_tbY
            // 
            this.m_tbY.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbY.Location = new System.Drawing.Point(210, 53);
            this.m_tbY.Name = "m_tbY";
            this.m_tbY.Size = new System.Drawing.Size(100, 32);
            this.m_tbY.TabIndex = 2;
            // 
            // m_lbVectors
            // 
            this.m_lbVectors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lbVectors.FormattingEnabled = true;
            this.m_lbVectors.ItemHeight = 25;
            this.m_lbVectors.Location = new System.Drawing.Point(56, 105);
            this.m_lbVectors.Name = "m_lbVectors";
            this.m_lbVectors.Size = new System.Drawing.Size(254, 204);
            this.m_lbVectors.TabIndex = 4;
            // 
            // m_btnLength
            // 
            this.m_btnLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnLength.Location = new System.Drawing.Point(348, 105);
            this.m_btnLength.Name = "m_btnLength";
            this.m_btnLength.Size = new System.Drawing.Size(132, 32);
            this.m_btnLength.TabIndex = 5;
            this.m_btnLength.Text = "&Länge";
            this.m_btnLength.UseVisualStyleBackColor = true;
            this.m_btnLength.Click += new System.EventHandler(this.m_btnLength_Click);
            // 
            // m_lblLength
            // 
            this.m_lblLength.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_lblLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblLength.Location = new System.Drawing.Point(503, 105);
            this.m_lblLength.Name = "m_lblLength";
            this.m_lblLength.Size = new System.Drawing.Size(132, 32);
            this.m_lblLength.TabIndex = 6;
            this.m_lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_tbFactor
            // 
            this.m_tbFactor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tbFactor.Location = new System.Drawing.Point(348, 158);
            this.m_tbFactor.Name = "m_tbFactor";
            this.m_tbFactor.Size = new System.Drawing.Size(132, 32);
            this.m_tbFactor.TabIndex = 7;
            // 
            // m_btnScale
            // 
            this.m_btnScale.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnScale.Location = new System.Drawing.Point(503, 157);
            this.m_btnScale.Name = "m_btnScale";
            this.m_btnScale.Size = new System.Drawing.Size(132, 32);
            this.m_btnScale.TabIndex = 8;
            this.m_btnScale.Text = "Skaliere";
            this.m_btnScale.UseVisualStyleBackColor = true;
            this.m_btnScale.Click += new System.EventHandler(this.m_btnScale_Click);
            // 
            // m_lblScaled
            // 
            this.m_lblScaled.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_lblScaled.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblScaled.Location = new System.Drawing.Point(657, 157);
            this.m_lblScaled.Name = "m_lblScaled";
            this.m_lblScaled.Size = new System.Drawing.Size(132, 33);
            this.m_lblScaled.TabIndex = 9;
            this.m_lblScaled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cbVector1
            // 
            this.m_cbVector1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_cbVector1.FormattingEnabled = true;
            this.m_cbVector1.Location = new System.Drawing.Point(56, 382);
            this.m_cbVector1.Name = "m_cbVector1";
            this.m_cbVector1.Size = new System.Drawing.Size(121, 33);
            this.m_cbVector1.TabIndex = 10;
            // 
            // m_cbOperation
            // 
            this.m_cbOperation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_cbOperation.FormattingEnabled = true;
            this.m_cbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.m_cbOperation.Location = new System.Drawing.Point(227, 382);
            this.m_cbOperation.Name = "m_cbOperation";
            this.m_cbOperation.Size = new System.Drawing.Size(60, 33);
            this.m_cbOperation.TabIndex = 11;
            this.m_cbOperation.Text = "+";
            // 
            // m_cbVector2
            // 
            this.m_cbVector2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_cbVector2.FormattingEnabled = true;
            this.m_cbVector2.Location = new System.Drawing.Point(339, 382);
            this.m_cbVector2.Name = "m_cbVector2";
            this.m_cbVector2.Size = new System.Drawing.Size(121, 33);
            this.m_cbVector2.TabIndex = 12;
            // 
            // m_lblResult
            // 
            this.m_lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_lblResult.Location = new System.Drawing.Point(523, 382);
            this.m_lblResult.Name = "m_lblResult";
            this.m_lblResult.Size = new System.Drawing.Size(132, 33);
            this.m_lblResult.TabIndex = 14;
            this.m_lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_btnCalc
            // 
            this.m_btnCalc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_btnCalc.Location = new System.Drawing.Point(466, 381);
            this.m_btnCalc.Name = "m_btnCalc";
            this.m_btnCalc.Size = new System.Drawing.Size(51, 34);
            this.m_btnCalc.TabIndex = 15;
            this.m_btnCalc.Text = "=";
            this.m_btnCalc.UseVisualStyleBackColor = true;
            this.m_btnCalc.Click += new System.EventHandler(this.m_btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 502);
            this.Controls.Add(this.m_btnCalc);
            this.Controls.Add(this.m_lblResult);
            this.Controls.Add(this.m_cbVector2);
            this.Controls.Add(this.m_cbOperation);
            this.Controls.Add(this.m_cbVector1);
            this.Controls.Add(this.m_lblScaled);
            this.Controls.Add(this.m_btnScale);
            this.Controls.Add(this.m_tbFactor);
            this.Controls.Add(this.m_lblLength);
            this.Controls.Add(this.m_btnLength);
            this.Controls.Add(this.m_lbVectors);
            this.Controls.Add(this.m_tbY);
            this.Controls.Add(this.m_tbX);
            this.Controls.Add(this.m_btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnCreate;
        private System.Windows.Forms.TextBox m_tbX;
        private System.Windows.Forms.TextBox m_tbY;
        private System.Windows.Forms.ListBox m_lbVectors;
        private System.Windows.Forms.Button m_btnLength;
        private System.Windows.Forms.Label m_lblLength;
        private System.Windows.Forms.TextBox m_tbFactor;
        private System.Windows.Forms.Button m_btnScale;
        private System.Windows.Forms.Label m_lblScaled;
        private System.Windows.Forms.ComboBox m_cbVector1;
        private System.Windows.Forms.ComboBox m_cbOperation;
        private System.Windows.Forms.ComboBox m_cbVector2;
        private System.Windows.Forms.Label m_lblResult;
        private System.Windows.Forms.Button m_btnCalc;
    }
}

