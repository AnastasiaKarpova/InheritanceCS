using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Triangle:Shape, IHaveEquilateral, IHaveIsosceles, IHaveRight
	{
		double sideA;
		double sideB;
		double basis;
		double height;
		public double SideA
		{
			get => sideA;
			set => sideA = SizeFilter(value);
		}
		public double SideB
		{
			get => sideB;
			set => sideB = SizeFilter(value);
		}
		public double Basis
		{
			get => basis; 
			set => basis = SizeFilter(value);	
		}
		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}
		public Triangle (double sideA, double sideB, double basis, double height, 
			int startX, int startY, int lineWidth, System.Drawing.Color color) 
			: base (startX, startY, lineWidth, color)
		{
			SideA = sideA;
			SideB = sideB;
			Basis = basis;
			Height = height;
		}
		public override double GetArea() => (basis * height)/2;
		public override double GetPerimeter() => sideA + sideB + basis;
		public override void Draw(PaintEventArgs e)
		{
			#region MyRegion
			//Pen pen = new Pen(Color, LineWidth);
			//Point[] verticesR =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX, StartY + (int)basis - (int)height),
			//	new Point(StartX + (int)sideB, StartY + (int)sideA)
			//};
			//Point[] verticesE =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX + (int)sideA, StartY + (int)sideA),
			//	new Point(StartX + (int)sideA/2, StartY + (int)sideA - (int)height)
			//};
			//Point[] verticesI =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX + (int)basis, StartY + (int)sideA),
			//	new Point(StartX + (int)basis/2, StartY + (int)sideA - (int)height)
			//};

			//e.Graphics.DrawPolygon(pen, verticesR); 
			#endregion
			DrawEquilateral(e);
			DrawIsosceles(e);
			DrawRight(e);
		}
		public void DrawEquilateral(PaintEventArgs e)
		{
			#region MyRegion
			//Point[] verticesE =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX + (int)sideA, StartY + (int)sideA),
			//	new Point(StartX + (int)sideA/2, StartY + (int)sideA - (int)height)
			//}; 
			#endregion
			e.Graphics.DrawPolygon(new Pen(Color, 3), new Point[] { new Point(StartX, StartY + (int)sideA),
			new Point(StartX + (int)sideA, StartY + (int)sideA), new Point(StartX + (int)sideA/2, StartY + (int)sideA - (int)height)});
		}
		public void DrawIsosceles(PaintEventArgs e)
		{
			#region MyRegion
			//Point[] verticesI =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX + (int)basis, StartY + (int)sideA),
			//	new Point(StartX + (int)basis/2, StartY + (int)sideA - (int)height)
			//}; 
			#endregion
			e.Graphics.DrawPolygon(new Pen(Color, 1), new Point[] { new Point(StartX, StartY + (int)sideA),
			new Point(StartX + (int)basis, StartY + (int)sideA), new Point(StartX + (int)basis/2, StartY + (int)sideA - (int)height)});
		}
		public void DrawRight(PaintEventArgs e)
		{
			#region MyRegion
			//Point[] verticesR =
			//{
			//	new Point (StartX, StartY + (int)sideA),
			//	new Point(StartX, StartY + (int)basis - (int)height),
			//	new Point(StartX + (int)sideB, StartY + (int)sideA)
			//}; 
			#endregion
			e.Graphics.DrawPolygon(new Pen(Color, 2), new Point[] { new Point(StartX, StartY + (int)sideA),
			new Point(StartX, StartY + (int)basis - (int)height), new Point(StartX + (int)sideB, StartY + (int)sideA)});
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Площадь треугольника: {GetArea()}");
			Console.WriteLine($"Периметр треугольника: {GetPerimeter()}");
			Console.WriteLine();
			Draw(e);
		}
	}
}
