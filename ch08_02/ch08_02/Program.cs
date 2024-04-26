internal class Program
{
	static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
	{
		rx = x+vx;
		ry = y+vy;
	}
	private static void Main(string[] args)
	{
		Console.Write("숫자 입력: ");
		int output; // Console.ReadLine으로 값을 입력 받는다.
		bool result = int.TryParse(Console.ReadLine(), out output); 
		// 해당 입력받은 값을 int.TryParse로 int형으로 변환하고
		// out 뒤의 변수에 해당값을 입력한다 (형변환이 잘되면 true 아니면 false)
		if(result)
		{
			Console.WriteLine("입력한 숫자: "+output);
		}
		else
		{
			Console.WriteLine("숫자를 입력해 주세요");
		}
		int x = 0;
		int y = 0;
		int vx = 1;
		int vy =1;
		Console.WriteLine($"현재 좌표: ({x},{y})");
		NextPosition(x,y,vx,vy, out x, out y); // out으로 rx와 ry의 값을 각각 x와 y에 덮어씌여 받는다
		Console.WriteLine($"다음 좌표: ({x},{y})");
	}
}