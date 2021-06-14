using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Eingabe
            double a = Convert.ToDouble(m_tbA.Text);
            double b = Convert.ToDouble(m_tbB.Text);

            // Verarbeitung
            double sum = a + b;

            // Ausgabe
            m_lblSum.Text = Convert.ToString(sum);
        }

        private Boolean InputCorrect()
        {
            Boolean inputCorrect = true;

            try
            {
                double a = Convert.ToDouble(m_tbA.Text);
                double b = Convert.ToDouble(m_tbB.Text);
            }
            catch(Exception exc)
            {
                inputCorrect = false;
            }

            return inputCorrect;
        }

        private void m_tbA_TextChanged(object sender, EventArgs e)
        {
            m_btnAdd.Enabled = InputCorrect();
        }

        private void m_tbB_TextChanged(object sender, EventArgs e)
        {
            m_btnAdd.Enabled = InputCorrect();
        }
    }
}
