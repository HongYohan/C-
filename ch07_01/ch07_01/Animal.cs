﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_01
{
	internal class Animal // 부모 클래스
	{
		public int Age { get; set; }

		public Animal() { this.Age = 0; }

		public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
		public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
	}
}
