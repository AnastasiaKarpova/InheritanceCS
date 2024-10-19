using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class EquilateralTriangle:Triangle
	{
		public EquilateralTriangle(double sideA, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(sideA, sideA, sideA, height, startX, startY, lineWidth, color)
		{ }
	}
}
