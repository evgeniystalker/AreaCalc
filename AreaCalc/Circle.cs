using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Circle : Figure
    {
        private float radius;
        public float Radius {
            get { return radius; }
            set {
                if (CheckCircle(value))
                    radius = value;
                else
                    throw new Exception("Маленький радиус");
            }
        }

        public string Form { get; set; }
        public bool Rectangular { get; set; }

        public bool CheckFigure()
        {
            return CheckCircle(Radius);
        }

        public bool CheckCircle(float radius)
        {
            if (radius > 0)
                return true;
            else
                return false;
        }

        public float GetSquare()
        {
            return MathF.Pow(Radius*2, 2 ) / 4 * MathF.PI;
        }

        public Circle(float r)
        {
            Form = "Круг";
            Rectangular = false;
            Radius = r;
        }
    }
}
