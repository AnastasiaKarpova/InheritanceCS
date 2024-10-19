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
	internal class RightTriangle:Triangle
	{
		public RightTriangle(double sideA, double sideB, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(sideA, sideB, sideB, height, startX, startY, lineWidth, color)
		{}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine("Правильный треугольник");
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Console.WriteLine();
			Draw(e);
		}
	}
}
