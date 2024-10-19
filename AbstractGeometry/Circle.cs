using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AbstractGeometry
{
	internal class Circle:Shape
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}
		public Circle(double radius,
			int startX, int startY, int lineWidth, System.Drawing.Color color) 
			:base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		//public override double GetDiameter() => 2 * radius;
		public override double GetArea() => Math.PI * radius * radius;
		public override double GetPerimeter() => 2 * Math.PI * radius;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (int)Radius, (int)Radius);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine("Круг");
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Console.WriteLine();
			Draw(e);
		}
	}
}
