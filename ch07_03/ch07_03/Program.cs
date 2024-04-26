internal class Program
{
	class Parent
	{
		public int variable = 273;
		public Parent() 
		{
			Console.WriteLine("부모 생성자");
		}
	}
	class Child : Parent
	{
		// 변수 하이딩
		public string variable = "Hello";
		public Child()
		{
			Console.WriteLine("자식 생성자");
		}
	}
	public static int number = 10;
	private static void Main(string[] args)
	{
		Child child = new Child();
		// 변수 하이딩,, child클래스에서 가장 가까운 변수를 값으로 함
		Console.WriteLine(child.variable);
		// 섀도잉
		int number = 20;
		Console.WriteLine(number); //20이 출력된다. 이는 가장 가까운 변수명의 값을 선택하기 때문
	}
}