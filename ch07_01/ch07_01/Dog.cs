using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_01
{
	internal class Dog : Animal  // 부모 클래스를 상속받는 자식 클래스
	{
		public string  Color { get; set; }

		public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
	}
}
