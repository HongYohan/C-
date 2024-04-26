using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_01
{
	internal class Cat: Animal  // 부모 클래스를 상속받는 자식 클래스
	{
		public void Meow() { Console.WriteLine("냥냥 짖습니다."); }
	}
}
