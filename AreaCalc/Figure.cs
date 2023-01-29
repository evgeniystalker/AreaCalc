using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public interface Figure
    {

        public string Form { get; set; }
        public bool Rectangular { get; set; }

        bool CheckFigure();

        float GetSquare();
    }
}
