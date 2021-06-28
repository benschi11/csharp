using System;
using System.Collections.Generic;
using System.Text;

namespace Klassen
{
    class Person
    {
        // Konstruktor
        public Person()
        {

        }

        // Überladenden Konstruktor
        public Person(string vorname, string nachname)
        {
            _vorname = vorname;
            _nachname = nachname;
        }
        #region Eigenschaften

        #region Vorname
        private string _vorname;

        public string Vorname
        {
            get { return this._vorname; }
            set { this._vorname = value; }
        }
        #endregion

        #region Nachname
        private string _nachname;

        public string Nachname
        {
            get { return this._nachname; }
            set { this._nachname = value; }
        }

        #endregion

        #endregion

        public void Sprechen(string text)
        {
            Console.WriteLine(_vorname + " sagt: " + text);
        }

        public override string ToString()
        {
            return _vorname + " " + _nachname;
        }

    }
}
