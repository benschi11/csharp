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
            'r', 's', 't', 'u','v','w','x','y','z','ä','ö','ü'
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
                string temp = c.ToString().ToUpper(); // in Großbuchstaben umwandeln
                char t = temp[0];
                upper.Add(t);
            }

            _alphabet.AddRange(upper);
            _alphabet.AddRange(new char[]{ 'ß', ' '});
        }

        private void m_btnRun_Click(object sender, EventArgs e)
        {
            string input = m_tbInput.Text; // Einlesen des Textes

            string output = "";

            int key = Convert.ToInt32(m_tbKey.Text);

            // Schleife, die jeden Buchstaben im string Input durchgeht
            foreach (char c in input)
            {
                char en = ' ';
                if (m_rbEncrypt.Checked == true)
                {
                    en = Encrypt(c, key);
                }
                else if(m_rbDecrypt.Checked == true)
                {
                    en = Decrypt(c, key);
                }
                
                output = output + en;
            }

            //Ausgabe
            m_tbOutput.Text = output;


        }

        /// <summary>
        /// Diese Funktion verschlüsselt einen Buchstaben mit Hilfe eines Keys und gibt den verschlüsselten Buchstaben zurück.
        /// </summary>
        /// <param name="t">der Buchstabe der verschlüsselt werden soll</param>
        /// <param name="key">die Anzahl um wie viel der Buchstabe verschoben werden soll</param>
        /// <returns>den verschlüsselten / verschobenen Buchstaben</returns>
        private char Encrypt(char t, int key)
        {
            int index = _alphabet.IndexOf(t); // Suche nach dem Buchstaben in meiner Liste
            index = index + key; // erhöhe den index um den gegebenen Key

            // Überprüfe ob index noch innerhalb der Liste
            while(index >= _alphabet.Count)
            {
                index = index - _alphabet.Count;
            }
            while (index < 0)
            {
                index = index + _alphabet.Count;
            }

            return _alphabet[index];
        }

        private char Decrypt(char t, int key)
        {
            int index = _alphabet.IndexOf(t); // Suche nach dem Buchstaben in meiner Liste
            index = index - key; 

            // Überprüfe ob index noch innerhalb der Liste
            while (index < 0)
            {
                index = index + _alphabet.Count;
            }

            return _alphabet[index];
        }
    }
}
