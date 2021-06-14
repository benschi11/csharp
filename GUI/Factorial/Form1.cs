using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnCalc_Click(object sender, EventArgs e)
        {
            int input = 0; // Deklaration
            try
            {
                input = Convert.ToInt32(m_tbInput.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            double factorial = 1;
            for (double i = 1;i <= input; i++)
            {
                factorial = factorial * i;
            }

            m_lblOutput.Text = factorial.ToString();
            
            
            
        }
    }
}
