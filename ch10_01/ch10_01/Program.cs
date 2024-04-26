internal class Program
{
	private static void Main(string[] args)
	{
		string[] array = { "가", "나" };
		Console.Write("숫자를 입력해주세요: ");
		int input = int.Parse(Console.ReadLine());
		if(input < array.Length)
		{
			Console.WriteLine("입력한 위치의 값은 " + array[input] + "입니다");
		}
		else
		{
			Console.WriteLine("인덱스 범위를 넘었습니다");
		}
		Console.Write("입력: ");
		string a = Console.ReadLine();
		try
		{
			int index = int.Parse(a);
			Console.WriteLine("입력 숫자: "+index);
		}
		// Exception 클래스의 인스턴스로 예외 객체라고 부른다.
		catch(Exception exception)
		{
			Console.WriteLine("예외가 발생했습니다");
			Console.WriteLine(exception.GetType());
			Console.WriteLine(exception.Message); // 메시지 출력
			Console.WriteLine(exception.StackTrace); // 경로 출력
		}
		finally {Console.WriteLine("프로그램 종료");}
	}
}