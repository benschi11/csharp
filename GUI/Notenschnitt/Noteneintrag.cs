using System;
using System.Collections.Generic;
using System.Text;

namespace Notenschnitt
{
    class Noteneintrag
    {
        public Noteneintrag(string fach, int note)
        {
            Fach = fach;
            Note = note;
        }

        #region Fach
        private string _fach;

        public string Fach
        {
            get { return _fach; }
            set { _fach = value; }
        }
        #endregion

        #region Note
        private int _note;

        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion

        public string Ausgabe
        {
            get { return Fach + "\t" + Note; }
        }
    }
}
