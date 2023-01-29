using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AreaCalc.Triangle;

namespace AreaCalc
{
    public class Rectangle : Figure
    {
        public string Form { get; set; }
        public bool Rectangular {get; set;}

        private SidesRectangle sides;

        public SidesRectangle _Sides
        {
            get { return sides; }
            set
            {
                if (CheckRectangle(value))
                    sides = new SidesRectangle(value.a, value.b, value.c, value.d);
                else 
                    throw new Exception("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
            }
        }

        public Rectangle(float a, float b, float c, float d)
        {
            _Sides = new SidesRectangle(a, b, c, d);
        }

        public Rectangle(float a, float b, float c, float d, float alpha)
        {
            _Sides = new SidesRectangle(a, b, c, d);
        }

        private bool CheckRectangle(SidesRectangle sides)
        {
            if (sides.a == sides.b || sides.a == sides.c || sides.a == sides.d)
            {
                Form = "Параллелограмм";
            }
            else
            {
                Form = "Четырех угольник";
            }
            if (sides.a == sides.b && sides.a == sides.c && sides.a == sides.d)
            {
                Form = "Квадрат";
            }

            if (Math.Sign(sides.a * sides.b * sides.c * sides.d) <= 0)
            {
                return false;
            }

            return true;

        }

        public bool CheckFigure()
        {
            return CheckRectangle(sides);
        }

        public float GetSquare()
        {
            if (sides.alpha.HasValue)
            {
                float c1 = (float)(Math.Pow(_Sides.a, 2) + Math.Pow(_Sides.b, 2));
                float c2 = (float)(Math.Pow(_Sides.c, 2) + Math.Pow(_Sides.d, 2));
                return (float)(c1* c2 * 1/2 * Math.Sin(sides.alpha.Value));
            }
            return 0;

        }

        public struct SidesRectangle
        {
            public float a; public float b; public float c; public float d;
            public float? alpha;

            public SidesRectangle(float a, float b, float c, float d, float? alpha = null)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.alpha = alpha;
            }
        }
    }
}
