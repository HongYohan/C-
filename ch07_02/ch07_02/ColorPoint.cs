using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ch07_02
{
	internal class ColorPoint : Point  // 부모 클래스를 받음
	{
		private string z;
		public void setColor(string s)
		{
			z=s;
		}
		public void showColorPoint()
		{
			Console.Write(z);
			base.showPoint();
		}
	}
}
