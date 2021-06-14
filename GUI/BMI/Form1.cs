using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnCalc_Click(object sender, EventArgs e)
        {
            double weight = 0;
            double height = 0;

            try
            {
                weight = Convert.ToDouble(m_tbWeight.Text);
                height = Convert.ToDouble(m_tbHeight.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }

            if(weight > 0 && height > 0)
            {
                double bmi = weight / Math.Pow(height, 2);

                m_lblOutput.Text = bmi.ToString();

                if (bmi < 18.5)
                    m_lblOutputTxt.Text = "Untergewicht";
                else if (bmi < 25)
                    m_lblOutputTxt.Text = "Normalgewicht";
                else if (bmi >= 25)
                    m_lblOutputTxt.Text = "Übergewicht";
                
            }


        }
    }
}
