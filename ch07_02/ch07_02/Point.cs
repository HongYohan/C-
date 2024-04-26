using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_02
{
	internal class Point
	{
		private int x, y;
		public void set(int a, int b)
		{
			this.x = a;
			this.y = b;
		}
		public void showPoint()
		{
			Console.WriteLine("(" + x + "," + y + ")");
		}
	}
}
