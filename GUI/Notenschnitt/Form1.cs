using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notenschnitt
{
    public partial class Form1 : Form
    {
        List<int> _grades = new List<int>();
        public Form1()
        {
            InitializeComponent();
            m_lbGrades.DataSource = _grades;
        }

        private void m_btnAddGrade_Click(object sender, EventArgs e)
        {
            string eingabe = m_tbGrade.Text;

            int grade = Convert.ToInt32(eingabe);

            _grades.Add(grade);

            UpdateListBox();

            CalculateGradeAverage();
            m_tbGrade.Clear();
        }

        private void UpdateListBox()
        {
            m_lbGrades.DataSource = null; // setze Datasource zurück
            m_lbGrades.DataSource = _grades; // aktualisiert GUI
        }

        private void m_tbGrade_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void CalculateGradeAverage()
        {
            double summe = 0;
            foreach (int grade in _grades)
            {
                summe = summe + grade;
            }

            double average = Math.Round(summe / _grades.Count,2);
            m_lblGradeAverage.Text = "Notenschnitt: " + string.Format("{0:0.00}",average);
        }

        private void CheckInput()
        {
            if (m_tbGrade.Text == "1" || 
                m_tbGrade.Text == "2" ||
                m_tbGrade.Text == "3" || 
                m_tbGrade.Text == "4" ||
                m_tbGrade.Text == "5")
            {
                m_btnAddGrade.Enabled = true;
            }
            else
            {
                m_btnAddGrade.Enabled = false;
            }
        }

        private void m_lbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_lbGrades.SelectedIndex == -1)
            {
                m_btnDeleteGrade.Enabled = false;
            }
            else
            {
                m_btnDeleteGrade.Enabled = true;
            }
        }

        private void m_btnDeleteGrade_Click(object sender, EventArgs e)
        {
            int selectedIndex = m_lbGrades.SelectedIndex;
            _grades.RemoveAt(selectedIndex);
            UpdateListBox(); // aktualisiert GUI
            CalculateGradeAverage();
        }
    }
}
