using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class EquilateralTriangle: Triangle //Равнобедренный треугольник
    {
        
        public EquilateralTriangle(double size, int start_x, int start_y, int line_width, Color color)
            : base(size, size, size, start_x, start_y, line_width, color) { }
        
        public override double GetPerimeter() => Size1 *3;
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(base.ToString().Split('.').Last() + ":");
            Console.WriteLine($"Стороны (одинаковые) : {Size1}");
            base.Info(e);
        }
    }
}
