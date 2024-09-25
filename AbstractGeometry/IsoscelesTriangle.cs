using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class IsoscelesTriangle : Triangle //Равносторонний треугольник
    {
        public IsoscelesTriangle(double side1, double side2, int start_x, int start_y, int line_width, Color color)
            : base(side1, side2, side2, start_x, start_y, line_width, color) { }
        //public override double GetArea() => Size1 * Size2 / 2;
        public override double GetPerimeter() => Size1 + Size2 * 2;
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType() + ":");
            Console.WriteLine($"Основание: {Size1}");
            Console.WriteLine($"Равные стороны : {Size2}");
            base.Info(e);
        }
    }
}