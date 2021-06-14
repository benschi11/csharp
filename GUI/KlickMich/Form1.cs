using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlickMich
{
    public partial class Form1 : Form
    {
        int _count;
        public Form1()
        {
            InitializeComponent();
            _count = 0;
        }

        private void m_btnClickMe_MouseEnter(object sender, EventArgs e)
        {
            _count++;

            if (_count > 40)
            {
                MessageBox.Show("Ich bin müde");
            }
            else
            {
                Hüpfen();
            }
        }

        private void Hüpfen()
        {
            Random r = new Random();
            int moveX = r.Next(0, 200);
            int moveY = r.Next(0, 200);

            int newLocationX = m_btnClickMe.Location.X + moveX;
            int newLocationY = m_btnClickMe.Location.Y + moveY;

            if (newLocationX > this.Size.Width - 100)
            {
                newLocationX = newLocationX - this.Size.Width + 100;
            }

            if (newLocationY > this.Size.Height - 100)
            {
                newLocationY = newLocationY - this.Size.Height + 100;
            }

            m_btnClickMe.Location = new Point(newLocationX, newLocationY);
        }

        private void m_btnClickMe_Click(object sender, EventArgs e)
        {

        }
    }
}
