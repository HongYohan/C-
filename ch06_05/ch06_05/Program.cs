internal class Program
{
	static void Change(int input)
	{
		input = 20;
	}
	class Test
	{
		public int value=1;
	}

	class Fibonacci
	{
		public long Get(int i)
		{
			if (i < 0) { return 0; }
			if (i == 1) { return 1; }
			return Get(i-2)+Get(i-1); // 재귀 함수로 자기 자신의 함수를 호출해서 계속적인 연산을 이룸
		}
	}
	private static void Main(string[] args)
	{
		int a = 10;
		Change(a); // 10을 Change(int input)의 매개변수로 들어감
		// 그러므로 input은 10으로 덮어쓰기 된다.
		Console.WriteLine(a);

		Test testA = new Test();
		Test testB = testA; // testA와 testB의 주소 참조값이 같아짐
		testA.value = 10;
		testB.value = 20; // 그래서 새로운 값을 입력하면 그 값이 testA 와 testB에게 같아진다
		Console.WriteLine(testA.value);

		Fibonacci fibo = new Fibonacci();
		Console.WriteLine(fibo.Get(1)); // 1
		Console.WriteLine(fibo.Get(2)); // 0+1
		Console.WriteLine(fibo.Get(3)); // 0+1+1
		Console.WriteLine(fibo.Get(4)); // 0+1, 0+1+1 = 3
		Console.WriteLine(fibo.Get(5)); // 0+1+1(fibo.Get(3)), 0+1,0+1+1(fibo.Get(4)) = 5
	}
}