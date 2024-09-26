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
    internal class RightTriangle : Triangle //Прямоугольный треугольник, принимает катеты
    {
        public RightTriangle(double side1, double side2, int start_x, int start_y, int line_width, Color color)
            : base(side1, side2, Math.Sqrt(side1 * side1 + side2 * side2), start_x, start_y, line_width, color) { }
        public override double GetArea() => Size1 * Size2 / 2;
        public double GetHeight() => Size2;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            PointF[] apt = new PointF[3] {
                new PointF((float)StartX, (float)StartY),
                new PointF((float)StartX+ (float)Size1, (float)StartY),
                new PointF((float)StartX, (float)StartY+(float)Size2)};  //
            e.Graphics.DrawPolygon(pen, apt);
        }
        public override void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            e.Graphics.DrawLine
                (
                pen,
                StartX,
                StartY,
                (float)StartX,
                (float)StartY + (float)Size2
                );
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(base.ToString().Split('.').Last() + ":");
            Console.WriteLine($"Катет 1: {Size1}");
            Console.WriteLine($"Катет 2: {Size2}");
            Console.WriteLine($"Гипотенуза 3: {Size3}");
            base.Info(e);
        }
    }
}