using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class RightTriangle : Triangle //Прямоугольный треугольник, принимает катеты
    {
        public RightTriangle(double side1, double side2, int start_x, int start_y, int line_width, Color color)
            : base(side1, side2, Math.Sqrt(side1 * side1 + side2 * side2), start_x, start_y, line_width, color) { }
    }
}