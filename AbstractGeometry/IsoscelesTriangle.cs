using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle:Triangle
	{
		double triangleBase;
		double triangleSide;

		public double TriangleBase
		{
			get => triangleBase;
			set => triangleBase = SizeFilter(value);
		}
		public double TriangleSide
		{
			get => triangleSide;
			set => triangleSide = SizeFilter(value);
		}
		public IsoscelesTriangle(/*double sideA, double basis, double height,*/
			double triangleBase, double triangleSide,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(/*height, sideA, sideA, basis, */startX, startY, lineWidth, color)
		{ 
			TriangleBase = triangleBase;
			TriangleSide = triangleSide;
		}
		#region MyRegion
		//public override void Info(PaintEventArgs e)
		//{
		//	Console.WriteLine("Равнобедренный треугольник");
		//	Console.WriteLine($"Площадь фигуры: {GetArea()}");
		//	Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
		//	Console.WriteLine();
		//	Draw(e);
		//} 
		#endregion
		public override double GetHeight() =>
			Math.Sqrt(Math.Pow(TriangleSide, 2) - Math.Pow(TriangleBase/2, 2));
		public override double GetArea() =>TriangleBase * GetHeight() / 2;
		public override double GetPerimeter() =>TriangleBase + TriangleSide * 2;

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY + (int)TriangleSide),
				new Point(StartX + (int)TriangleBase, StartY + (int)TriangleSide),
				new Point(StartX+(int)TriangleBase/2, StartY + (int)TriangleSide - (int)GetHeight()),
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
