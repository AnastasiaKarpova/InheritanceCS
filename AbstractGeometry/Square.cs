using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square:Rectangle
	{
		public Square(double side,
			int startX, int startY, int lineWidth, System.Drawing.Color color)
			: base(side, side, startX, startY, lineWidth, color)
		{}
	}
}
