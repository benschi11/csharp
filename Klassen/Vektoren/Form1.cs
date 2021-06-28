using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektoren
{
    public partial class Form1 : Form
    {
        List<Vektor2D> _vectors = new List<Vektor2D>();
        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnCreate_Click(object sender, EventArgs e)
        {
            // Einlesen der Daten
            double x = Convert.ToDouble(m_tbX.Text);
            double y = Convert.ToDouble(m_tbY.Text);

            Vektor2D v = new Vektor2D(x, y);

            _vectors.Add(v);

            UpdateGUI();
        }

        private void UpdateGUI()
        {
            m_lbVectors.DataSource = null;
            m_lbVectors.DataSource = _vectors;
            m_lbVectors.DisplayMember = "Display";

            m_cbVector1.BindingContext = new BindingContext();
            m_cbVector1.DataSource = null;
            m_cbVector1.DataSource = _vectors;
            m_cbVector1.DisplayMember = "Display";

            m_cbVector2.BindingContext = new BindingContext();
            m_cbVector2.DataSource = null;
            m_cbVector2.DataSource = _vectors;
            m_cbVector2.DisplayMember = "Display";
        }

        private void m_btnLength_Click(object sender, EventArgs e)
        {
            Vektor2D selectedItem = (Vektor2D)m_lbVectors.SelectedItem;
            double length = Math.Round(selectedItem.Length,2);
            m_lblLength.Text = $"{length:0.00} LE";
        }

        private void m_btnScale_Click(object sender, EventArgs e)
        {
            double factor = Convert.ToDouble(m_tbFactor.Text);
            Vektor2D selectedItem = (Vektor2D)m_lbVectors.SelectedItem;
            Vektor2D scaled = selectedItem.Scale(factor);
            m_lblScaled.Text = scaled.Display;
        }

        private void m_btnCalc_Click(object sender, EventArgs e)
        {
            if(m_cbOperation.Text == "+")
            {
                Vektor2D v1 = (Vektor2D)m_cbVector1.SelectedItem;
                Vektor2D v2 = (Vektor2D)m_cbVector2.SelectedItem;
                Vektor2D result = v1.Add(v2);
                m_lblResult.Text = result.Display;
            }
        }
    }
}
