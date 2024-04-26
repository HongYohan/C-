internal class Program
{
	abstract class Parent // abstract는 반드시 상속해야 하는 속성이다
	{
		public abstract void Test(); // Parent 클래스 안에 abstract가 하나 더있다.
	}
	class Child : Parent // class Parent에 대한 상속을 함
	{
		public override void Test() { } // 내부 상속인데 여기서는 abstract는 반드시 상속이라는 조건이 있기에
										// 굳이 virtual을 안쓰고 override만 써도 해당 Test에 대한 override를 한다
	}

	sealed class Parent1 // sealed를 클래스에 적용하면 상속을 절대 하지말라는 의미
	{
		sealed public override void Test1() { }
	}
	class Child : Parent // sealed로 인해 상속이 불가능하다
	{
		public  void override Test1() { } // sealed로 인해 오버라이드가 불가능 해진다  
	}
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}
}