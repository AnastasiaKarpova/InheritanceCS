using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class EquilateralTriangle : IsoscelesTriangle
	{
		public EquilateralTriangle(/*double sideA, double height,*/
			double side,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(/*sideA, sideA, sideA, height, */side, side, startX, startY, lineWidth, color)
		{ }
		#region MyRegion
		//public override void Info(PaintEventArgs e)
		//{
		//	Console.WriteLine("Равносторонний треугольник");
		//	Console.WriteLine($"Площадь фигуры: {GetArea()}");
		//	Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
		//	Console.WriteLine();
		//	Draw(e);
		//} 
		#endregion
		
	}
}
