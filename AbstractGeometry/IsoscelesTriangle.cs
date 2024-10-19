using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle:Triangle
	{
		public IsoscelesTriangle(double sideA, double basis, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(height, sideA, sideA, basis, startX, startY, lineWidth, color)
		{ }
	}
}
