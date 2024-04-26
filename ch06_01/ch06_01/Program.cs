internal class Program
{
	class Test
	{
		// 함수 4가지 형태,, 매개변수와 반환
		// 1.반환값 없고, 매개변수 없는 경우
		public void Power1()
		{
			int x = 10;
			Console.WriteLine(x * x);
		}
		// 2. 반환값 없고, 매개변수 있는 경우
		public void Power2(int x)
		{
			Console.WriteLine(x*x);
		}
		// 3. 반환값 있고, 매개변수 없는 경우
		public int Power3() // return 값이 정수형이여서 int 임
		{
			int x = 10;
			return (x*x);
		}
		// 4. 반환값 있고, 매개변수 있는 경우
		public int Power4(int x)
		{
			return (x * x);
		}
		public static int Multy(int x, int y) // static으로 선언이 되었기때문에 Test.Multy로 접근해야 한다
		{
			return (x * y);
		}
	}
	public static int Multy(int x, int y) // 내부 메서드에 선언된 것,, 클래스 변수임
	{
		return (x * y);
	}
	private static void Main(string[] args)
	{
		Test test = new Test(); // 내부 클래스 에서 인스턴스 변수를 불러오기 위한 문장
		test.Power1();
		test.Power2(10); //실인자값
		Console.WriteLine(test.Power3());
		Console.WriteLine(test.Power4(10));
		Console.WriteLine(Multy(10, 10));
	}
}