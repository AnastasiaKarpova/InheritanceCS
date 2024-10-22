using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Policy;

namespace AbstractGeometry
{
	internal class RightTriangle : Triangle
	{
		double rightSideA;
		double rightSideB;
		double rightBase;

		public double RightSideA
		{
			get => rightSideA;
			set=>rightSideA = SizeFilter(value);
		}
		public double RightSideB
		{
			get => rightSideB;
			set=> rightSideB = SizeFilter(value);
		}
		public double RightBase
		{
			get => rightBase; 
			set => rightBase = SizeFilter(value);	
		}
		public RightTriangle(/*double sideA, double sideB, double height,*/
			double rightSideA, double rightSideB, double rightBase,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(/*sideA, sideB, sideB, height, */startX, startY, lineWidth, color)
		{ 
			RightSideA = rightSideA;
			RightSideB = rightSideB;
			RightBase = rightBase;
		}
		#region MyRegion
		//public override void Info(PaintEventArgs e)
		//{
		//	Console.WriteLine("Правильный треугольник");
		//	Console.WriteLine($"Площадь фигуры: {GetArea()}");
		//	Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
		//	Console.WriteLine();
		//	Draw(e);
		//} 
		#endregion
		public override double GetHeight() =>
			(RightSideA * RightSideB) / RightBase;
		public override double GetArea() => (RightSideA * RightSideB) / 2;
		public override double GetPerimeter() => RightBase + RightSideA + RightSideB;

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY + (int)RightSideA),
				new Point(StartX, StartY + (int)RightBase - (int)GetHeight()),
				new Point(StartX+(int)RightSideB, StartY + (int)RightSideA),
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
