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
        List<Noteneintrag> _grades = new List<Noteneintrag>();
        bool _editMode = false;
        Noteneintrag _selectedItem = null;
        public Form1()
        {
            InitializeComponent();
            m_lbGrades.DataSource = _grades;
            m_lbGrades.DisplayMember = "Ausgabe";
        }

        private void m_btnAddGrade_Click(object sender, EventArgs e)
        {
            string eingabe = m_tbGrade.Text;
            int grade = Convert.ToInt32(eingabe);

            string fach = m_tbFach.Text;

            Noteneintrag ne = new Noteneintrag(fach, grade);

            _grades.Add(ne);

            UpdateListBox();

            CalculateGradeAverage();
            m_tbGrade.Clear();
            m_tbFach.Clear();
        }

        private void UpdateListBox()
        {
            m_lbGrades.DataSource = null; // setze Datasource zurück
            m_lbGrades.DataSource = _grades; // aktualisiert GUI
            m_lbGrades.DisplayMember = "Ausgabe";
        }

        private void m_tbGrade_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void CalculateGradeAverage()
        {
            double summe = 0;
            foreach (Noteneintrag ne in _grades)
            {
                summe = summe + ne.Note;
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
                m_btnEdit.Enabled = false;
            }
            else
            {
                m_btnDeleteGrade.Enabled = true;
                m_btnEdit.Enabled = true;
            }
        }

        private void m_btnDeleteGrade_Click(object sender, EventArgs e)
        {
            int selectedIndex = m_lbGrades.SelectedIndex;
            _grades.RemoveAt(selectedIndex);
            UpdateListBox(); // aktualisiert GUI
            CalculateGradeAverage();
        }

        private void m_btnEdit_Click(object sender, EventArgs e)
        {
            if (_editMode == false)
            {
                _selectedItem = (Noteneintrag)m_lbGrades.SelectedItem;
                m_tbFach.Text = _selectedItem.Fach;
                m_tbGrade.Text = Convert.ToString(_selectedItem.Note);
                GoToEditMode();
            }
            else
            {
                _selectedItem.Fach = m_tbFach.Text;
                _selectedItem.Note = Convert.ToInt32(m_tbGrade.Text);

                UpdateListBox();
            }
        }

        private void GoToEditMode()
        {
            _editMode = true;
            m_btnCancel.Visible = true;
            m_btnAddGrade.Visible = false;
            m_btnDeleteGrade.Visible = false;
            m_btnEdit.Text = "Save";
        }

        private void LeaveEditMode()
        {
            _editMode = false;
            m_btnCancel.Visible = false;
            m_btnAddGrade.Visible = true;
            m_btnDeleteGrade.Visible = true;
            m_btnEdit.Text = "Edit";
        }
    }
}
