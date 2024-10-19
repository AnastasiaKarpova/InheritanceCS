using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle:Triangle
	{
		public IsoscelesTriangle(double sideA, double basis, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(height, sideA, sideA, basis, startX, startY, lineWidth, color)
		{ }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine("Равнобедренный треугольник");
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Console.WriteLine();
			Draw(e);
		}
	}
}
