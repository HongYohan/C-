using System;
using System.ComponentModel.Design;

internal class Program
{
	class Pyramid
	{
		public int Lines()
		{
			Console.Write("라인 수 : ");
			int x = int.Parse(Console.ReadLine());
			return x;
		}

		public void Pyramidd(int x) 
		{
			int num = x;
			for (int i = 1; i < x; i++)
			{
				for (int j = num; j > 0; j--)
				{
					Console.Write("-");
				}
				for (int j = 0; j < (i*2-1) ; j++)
				{
					Console.Write("*");
				}
				num--;
				Console.WriteLine();
			}
		}
	}
	class MyMath // 클래스 메서드
	{
		// 두 클래스 변수명이 같아서 이것을 오버로딩 이라고 부른다.
		public static int Hap(int x, int y) // 자료형 앞에 static이 들어가서 클래스 메서드 라고 부른다
		{
			return x + y;
		}

		public static double Hap(double x, double y)
		{
			return x + y;
		}
		public static int Sub(int x, int y)
		{
			return x - y;
		}

		public static double Sub(double x, double y)
		{
			return x - y;
		}
		public static int Multify(int x, int y)
		{
			return x * y;
		}

		public static double Multify(double x, double y)
		{
			return x * y;
		}
		public static int Nanugi(int x, int y)
		{
			return x / y;
		}

		public static double Nanugi(double x, double y)
		{
			return x / y;
		}
	}
	private static void Main(string[] args)
	{
		Pyramid pyramid = new Pyramid();
		int line=pyramid.Lines();
		pyramid.Pyramidd(line);

		while (true)
		{
			Console.Write("첫 번째 수 입력: ");
			string a = Console.ReadLine();
			Console.Write("두 번째 수 입력: ");
			string b = Console.ReadLine();
			Console.Write("연산자 입력: ");
			string c = Console.ReadLine();

			if (c == "stop") break;

			double d = 0, e = 0;

			// 검사
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == '.') d = double.Parse(a);
			}

			for (int i = 0; i < b.Length; i++)
			{
				if (b[i] == '.') e = double.Parse(b);
			}
				

			// +
			if (c == "+")
			{
				if (d == 0 && e == 0) Console.WriteLine(MyMath.Hap(int.Parse(a), int.Parse(b))); // 오버로딩 int형
				else Console.WriteLine(MyMath.Hap(double.Parse(a), double.Parse(b)).ToString("0.00")); // 오버로딩 double형

			}
			// *
			else if (c == "*")
			{
				if (d == 0 && e == 0) Console.WriteLine(MyMath.Multify(int.Parse(a), int.Parse(b)));
				else Console.WriteLine(MyMath.Multify(double.Parse(a), double.Parse(b)).ToString("0.00"));
			}
			// -
			else if (c == "-")
			{
				if (d == 0 && e == 0) Console.WriteLine(MyMath.Sub(int.Parse(a), int.Parse(b)));
				else Console.WriteLine(MyMath.Sub(double.Parse(a), double.Parse(b)).ToString("0.00"));
			}
			// /
			else if (c == "/")
			{
				if (d == 0 && e == 0) Console.WriteLine(MyMath.Nanugi(int.Parse(a), int.Parse(b)));
				else Console.WriteLine(MyMath.Nanugi(double.Parse(a), double.Parse(b)).ToString("0.00"));
			}
			else Console.WriteLine("제대로된 연산자 입력하세요!");
		}
	}
}