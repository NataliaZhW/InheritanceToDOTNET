﻿﻿//#define CHECK_1
#define CHECK_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Инициализируем графику в консоли:
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            //2) Только теперь можно создавать:
#if CHECK_1
			Rectangle rectangle = new Rectangle(80, 50, 400, 60, 2, Color.AliceBlue);
			rectangle.Info(e);

			Square square = new Square(75, 500, 50, 3, Color.Red);
			square.Info(e);

			Circle circle = new Circle(800, 700, 50, 1, Color.Yellow);
			circle.Info(e); 
#endif

#if CHECK_2
            Shape[] shapes = new Shape[]
            {
                //new Rectangle(80, 50, 400, 60, 2, Color.Aqua),
                //new Square(75, 500, 50, 3, Color.Green),
                //new Circle(800, 700, 50, 1, Color.Yellow),
                new EquilateralTriangle(80, 600, 50, 2, Color.Yellow),
                new IsoscelesTriangle(80, 50, 400, 50, 5, Color.RoyalBlue),
                new RightTriangle(90, 60, 400, 100, 4, Color.Purple),
                new Triangle (90, 140, 60, 400, 200, 3, Color.Red)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                //if(shapes[i] is IHaveDiameter)
                shapes[i].Info(e);
            }
#endif
        }
        [DllImport("kernel32.dll")]// импортируем из dll
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
/*
Interface - это набор абстрактных методов. (Able)
I....able: IMovable, IDrawable, IFlyable, ......
 !!!	ИНТЕРФЕЙСЫ НЕ НАСДЕДУЮТ, ИНТЕРФЕЙСЫ РЕАЛИЗУЮТ	!!!
 */



