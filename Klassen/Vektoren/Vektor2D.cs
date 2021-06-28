using System;
using System.Collections.Generic;
using System.Text;

namespace Vektoren
{
    class Vektor2D
    {
        public Vektor2D()
        {
            X = 0;
            Y = 0;
        }

        public Vektor2D(double x, double y)
        {
            X = x;
            Y = y;
        }


        #region Eigenschaften
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y { get; set; }

        public string Display
        {
            get
            {
                return $"({X} / {Y})";
            }
        }


        public double Length
        {
            get
            {
                double length = Math.Sqrt(X * X + Math.Pow(Y,2));
                return length;
            }
        }

        #endregion

        #region Methoden

        public Vektor2D Scale(double factor)
        {
            double x = X * factor;
            double y = Y * factor;
            Vektor2D v = new Vektor2D(x, y);
            return v;
        }

        public Vektor2D Add(Vektor2D other)
        {
            double x = this.X + other.X;
            double y = this.Y + other.Y;
            Vektor2D v = new Vektor2D(x, y);
            return v;
        }

        #endregion

    }
}
