internal class Program
{
	private static void Main(string[] args)
	{
		// File.WriteAllText(@"폴더 경로\파일명.txt","내용")
		File.WriteAllText(@"C:\Users\82106\Desktop\C#02\test\test.txt", "문자열을 파일에 씁니다");
		Console.WriteLine(File.ReadAllText(@"C:\Users\82106\Desktop\C#02\test\test.txt"));

		// using (객체로 선언해서 파일명까지 선언)
		using (StreamWriter writer = new StreamWriter(@"C:\Users\82106\Desktop\C#02\test\test.txt"))
		{
			writer.WriteLine("안녕하세요");
			writer.WriteLine("StreamWriter 클래스를 사용해");
			writer.WriteLine("글자를 여러 줄 입력해봅시다");

			for(int i = 0; i < 10; i++)
			{
				writer.WriteLine("반복문 - " + (i + 1));
			}
		}
		// write로 선언할 경우 console로 값을 불러와야 한다
		Console.WriteLine(File.ReadAllText(@"C:\Users\82106\Desktop\C#02\test\test.txt"));

		// reader 로 선언하면 바로 읽을 수 있음
		using (StreamReader reader = new StreamReader(@"C:\Users\82106\Desktop\C#02\test\test.txt"))
		{
			string line;
			while((line = reader.ReadLine()) != null)
			{
				Console.WriteLine(line); // 문자열을 읽어만 오는 메서드
			}
		}
	}
}