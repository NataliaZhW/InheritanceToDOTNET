using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Triangle : Shape
    {
        double size1;
        double size2;
        double size3;
        public double Size1
        {
            get => size1;
            set => size1 =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double Size2
        {
            get => size2;
            set => size2 =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double Size3
        {
            get => size3;
            set => size3 =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        //			Constructors:
        public Triangle(double size1, double size2, double size3, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Size1 = size1;            
            Size2 = size2;            
            Size3 = size3;            
        }
        public override double GetArea() 
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - Size1) * (s - Size2) * (s - Size3));
        }
        public override double GetPerimeter() => Size1 + Size2 + Size3;
        public double GetHeight() => 2* GetArea()/Size1;
        
        public override void Draw(PaintEventArgs e)
        {
            //Console.WriteLine("Здесь должен быть рисунок прямоугольника");
            Pen pen = new Pen(Color, LineWidth);
            PointF[] apt = new PointF[3] {
                new PointF((float)StartX, (float)StartY),
                new PointF((float)StartX+ (float)Size1, (float)StartY),
                new PointF((float)StartX+ (float)((Size2*Size2+Size1*Size1-Size3*Size3)/(2*Size1)), 
                                                           (float)StartY + (float)GetHeight())};  //
            e.Graphics.DrawPolygon (pen, apt);
        }
            
        public override void Info(PaintEventArgs e)
        {
            if (Convert.ToString(this.GetType()) == "AbstractGeometry.Triangle") 
            {            
            Console.WriteLine(this.GetType() + ":");
            Console.WriteLine($"Сторона 1: {Size1}");
            Console.WriteLine($"Сторона 2: {Size2}");
            Console.WriteLine($"Сторона 3: {Size3}");
            }
            base.Info(e);
        }
    }
}

