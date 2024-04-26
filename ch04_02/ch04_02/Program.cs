using System.Security.Cryptography.X509Certificates;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
		// 대문자 소문자 출력
        string input = "Potato Tomato";
        Console.WriteLine(input.ToUpper());
        Console.WriteLine(input.ToLower());
        // 문자열 자르기
        string[] inputs= input.Split(new char[] { ' ' });
        foreach(var item in inputs) Console.WriteLine(item);
        // 공백 제거
        input ="test    \n";
        Console.WriteLine(input.Trim()+";;");

		int x = 1;
        while (x < 50)
        {
            Console.Clear(); // 콘솔 화면을 지운다
            Console.SetCursorPosition(x, 5); // 콘솔 화면의 특정한 위치로 커서를 옮긴다
            if (x % 6 == 0) Console.WriteLine("~");
            else if (x % 6 == 1) Console.WriteLine("변");
            else if (x % 6 == 2) Console.WriteLine("신");
            else if (x % 6 == 3) Console.WriteLine("혜");
            else if (x % 6 == 4) Console.WriteLine("힘");
            else Console.WriteLine("내");

            Thread.Sleep(300); // 특정한 시간만큼 스레드를 정지(1ms 기준)
            x++;
        }

		Console.WriteLine("---정지를 원하면 x 입력---");
        for (; ; )
        {
            ConsoleKeyInfo info = Console.ReadKey(); // 키보드로 출력값을 입력받음
            if (info.Key == ConsoleKey.UpArrow) Console.WriteLine("위로 이동");
            else if (info.Key == ConsoleKey.RightArrow) Console.WriteLine("오른쪽으로 이동");
            else if (info.Key == ConsoleKey.DownArrow) Console.WriteLine("아래로 이동");
            else if (info.Key == ConsoleKey.LeftArrow) Console.WriteLine("왼쪽로 이동");
            else if (info.Key == ConsoleKey.X) break;
        }

		ConsoleKeyInfo info = new ConsoleKeyInfo();
        do
        {
            info = Console.ReadKey();
            if (info.Key == ConsoleKey.UpArrow) Console.WriteLine("위로 이동");
            else if (info.Key == ConsoleKey.RightArrow) Console.WriteLine("오른쪽으로 이동");
            else if (info.Key == ConsoleKey.DownArrow) Console.WriteLine("아래로 이동");
            else if (info.Key == ConsoleKey.LeftArrow) Console.WriteLine("왼쪽로 이동");
        } while (info.Key != ConsoleKey.X);

		Random r = new Random();
        int[] intArray = new int[6];
        for(int i =0;i<6;i++) intArray[i] = r.Next(1,46);
        Console.WriteLine("생성된 6개의 랜덤한 숫자 출력: ");
        for(int i =0;i<6;i++) Console.Write(intArray[i]+" ");
        foreach(int value in intArray) Console.Write("{0,5}",value);

		Console.WriteLine("롤러코스터 판별식");
        while (true)
        {
            Console.Write("나이 입력(종료: exit): ");
            string age = Console.ReadLine();
            int value;
			if (int.TryParse(age, out value)) 
                // int.tryparse: 해당 문자열이 정수면 반환 아니면 예외처리
            {
                if(value <9) 
                {
					Console.WriteLine("입장 불가!");
				}
				else
				{
					Console.Write("키 입력: ");
					int height = int.Parse(Console.ReadLine());
					if (height >= 130) Console.WriteLine("고속 롤러코스트 입장 가능");
					else Console.WriteLine("저속 롤러코스트 입장 가능");
				}
				Console.WriteLine("------------------------------------");

			}

			if (age.ToLower() == "exit")
			{
				Console.WriteLine("프로그램 종료!!");
				break;
			}
		}


		int num = 1;
        while (num != 0)
        {
			Console.Write("정수 하나 입력(종료: 0): ");
			num = int.Parse(Console.ReadLine());

            if(num != 0) Console.Write($"1~{num}까지의 2의 배수이면서 3의 배수가 아닌 수: ");

			for (int i = 1; i <= num; i++)
            {
				if (i % 2 == 0 && i % 3 != 0)
				{
                    if (i + 2 <= num || i + 3 <= num)
                    {
						Console.Write(i + ", ");
					}
                    else
                    {
						Console.Write(i+"\n");
					}
				}
                
			}
		}
		Console.WriteLine("감사합니다.");

        
		Console.Write("랜덤하게 생성할 수의 개수: ");
        int cnt=int.Parse(Console.ReadLine());

		Random r = new Random();
        int[] intArray = new int[cnt];
        for(int i =0;i<cnt;i++) intArray[i] = r.Next(100);

        Console.Write("랜덤값 출력: ");
        for(int i =0;i<cnt;i++) Console.Write(intArray[i]+" ");

        int max = intArray[0], min = intArray[0];

        for(int i=1; i < cnt; i++)
        {
            if (max < intArray[i])
            {
                max = intArray[i];
            }
			else if (min > intArray[i]) 
            {
                min = intArray[i];
            }
		}
		Console.WriteLine($"\n최대값: {max}");
		Console.Write($"최소값: {min}");
	}
}