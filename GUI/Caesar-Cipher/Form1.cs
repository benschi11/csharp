using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        List<char> _alphabet = new List<char>()
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
            'r', 's', 't', 'u','v','w','x','y','z','ä','ö','ü','ß'
        };
        public Form1()
        {
            InitializeComponent();
            CharsToUpper();
        }

        private void CharsToUpper()
        {
            List<char> upper = new List<char>();
            foreach(char c in _alphabet)
            {
                string temp = c.ToString().ToUpper();
                char t = temp[0];
                upper.Add(t);
            }

            _alphabet.AddRange(upper);
        }

        private void m_btnRun_Click(object sender, EventArgs e)
        {

        }


        //private char Encrypt(char t, int key)
        //{

        //}
    }
}
