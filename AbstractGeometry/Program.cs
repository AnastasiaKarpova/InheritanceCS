﻿using System;
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
			//Console.WriteLine("AbstractGeometry");
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			

			Rectangle rectangle = new Rectangle(100, 50, 400, 100, 3, System.Drawing.Color.Red);
			rectangle.Info(e);
			
			//Square square = new Square(100, 550, 100, 3, System.Drawing.Color.Green);
			//square.Info(e);

			Square square = new Square(75, 512, 16, 1, Color.DarkBlue);
			square.Info(e);

			Circle circle = new Circle(75, 550, 150, 2, System.Drawing.Color.Blue);
			circle.Info(e);

			RightTriangle rTriangle = new RightTriangle(200, 100, 150, 500, 250, 3, System.Drawing.Color.Purple);
			rTriangle.Info(e);

			EquilateralTriangle eTriangle = new EquilateralTriangle(100, 700, 200, 3, System.Drawing.Color.Yellow);
			eTriangle.Info(e);

			IsoscelesTriangle iTriangle = new IsoscelesTriangle(60, 100, 650, 300, 3, System.Drawing.Color.Orange);
			iTriangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
