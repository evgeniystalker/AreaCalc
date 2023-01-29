using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : Figure
    {
        public struct SidesTriangles
        {
            public float x; public float y; public float z;

            public SidesTriangles(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public string Form { get; set; }
        public bool Rectangular { get; set; }

        private SidesTriangles sides;

        public SidesTriangles _Sides
        {
            get { return sides; }
            set
            {
                if (this.CheckTriangle(value.x, value.y, value.z))
                    this.sides = value;
                else
                    throw new Exception("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
            }
        }

        public Triangle(float x, float y, float z)
        {
            _Sides = new SidesTriangles(x, y, z);
        }



        public bool CheckTriangle(float a, float b, float c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                Form = "Не треугольник";
            else
                Form = "Обычный";

            if (a == b && b == c)
                Form = "Равносторонний";

            if (a == b || b == c || a == c)
                Form = "Равнобедренный";



            var sides = new float[] { a, b, c }.OrderBy(x => x).ToArray();

            if ((Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) == Math.Pow(sides[2], 2))
                Rectangular = true;
            else
                Rectangular = false;

            if (sides[0] + sides[1] > sides[2])
                if (sides[0] + sides[2] > sides[1])
                    if (sides[2] + sides[1] > sides[0])
                        return true;

            return false;

        }

        public float GetSquare()
        {
            float p = (sides.x + sides.y + sides.z) / 2;
            return (float)Math.Sqrt(p * (p - sides.x) * (p - sides.y) * (p - sides.z));
        }

        public bool CheckFigure()
        {
           return this.CheckTriangle(sides.x, sides.y, sides.z);
        }
    }


}
