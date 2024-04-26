internal class Program
{
	struct Point // 구조체는 참조 복사가 아닌 값 복사가 일어나는 구조이다
	{
		public int x;
		public int y;
		public string testA;
		public string testB;
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
			this.testA = "초기화";
			this.testB = "초기화";
		}
		public Point(int x, int y, string test)
		{
			this.x = x;
			this.y = y;
			this.testA = test;
			this.testB = test;
		} 

	}
	private static void Main(string[] args)
	{
		Point point = new Point();
		Console.WriteLine(point.x);
		Console.WriteLine(point.y);
		Console.WriteLine(point.testA);
		Console.WriteLine(point.testB);
	}
}