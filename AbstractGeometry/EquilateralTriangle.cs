﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class EquilateralTriangle: Triangle//Равнобедренный треугольник
    {
        public EquilateralTriangle(double side, int start_x, int start_y, int line_width, Color color)
            : base(side, side, side, start_x, start_y, line_width, color) { }
    }
}
