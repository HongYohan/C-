internal class Program
{
	class Box
	{
		//변수
		private int width;
		private int height;

		public int Width
		{
			get { return width; } // Getter 은 반드시 return이 있어야 한다.
			set // 속성 값
			{
				// value가 해당 int Width의 값인데 그것에 대한 조건을 맞추고 width에 덮어쓰기 한다
				if (value > 0) { width = value; } 
				else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
			}
		}
		
		public int Height
		{
			get { return height; }
			set
			{
				if (value > 0) { height = value; }
				else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
			}
		}
		public Box(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public void Area() 
		{ 
			if(this.width * this.height == 0) { Console.WriteLine("값을 정확하게 입력하시오"); }
			else Console.WriteLine(this.width * this.height);
		}
	}
	private static void Main(string[] args)
	{
		Console.WriteLine("두 자연수 입력");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		Box box = new Box(a, b);
		
		/*box.Width = 20;
		box.Height = 10;*/

		box.Area();
	}
}