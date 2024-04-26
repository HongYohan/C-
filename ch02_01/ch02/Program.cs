internal class Program
{
    private static void Main(string[] args)
    {
        // 정수
        Console.WriteLine(52 + 273);

        // 실수
        Console.WriteLine(52.273);

        // 문자열
        Console.WriteLine("hello\nworld");  // \n : 행바뀸
        Console.WriteLine("hello\tworld");  // \t : 수평탭
        Console.WriteLine("\"hello,world\""); // \" : "를 출력
        Console.WriteLine("helloworld" + "안녕하세요" + "bula"); // + : 문자열 연결 연산자 / 문자의 덧셈은 안됨
        Console.WriteLine("helloworld"[0]); // [0] : 0번째 문자만 출력함 (문자 출력 선택)

        // 불, true of false
        Console.WriteLine(true); 
        Console.WriteLine(52 > 273); // 불과 비교연산자 = 관계연산자
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour); // || : or
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8); // && : and
        Console.WriteLine(DateTime.Now); //datetime.now : 현재 날짜와 시간을 나타냄

        // 변수
        int a = 1; // int: 4bite, long: 8bite
        double b = 1.1; // float: 4bite, double: 8bite ,, 곱셈과 나눗셈 때문에 double을 사용
        char c = 'c'; // char : 2bite
        Console.WriteLine(c + "\n"); 
        string d = "Hello, Welcome"; //문자열만 가능함,, class로 시작해서 size of를 사용할수 없다
        bool e = 10 < 0; //불 자료형, true or false
        bool f = 10 > 0;

        // 오버플로우
        int ea = -2147483648;
        int eb = -1;
        Console.WriteLine(ea + eb + "\n");
        //오버 플로우 발생시 사용 uint, ulong
        uint unsignedInt = 4147483647;
        Console.WriteLine(unsignedInt + "\n");
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue + "\n");

        // 자료의 크기 확인
        Console.WriteLine("int : " + sizeof(int)); // 4bite
        Console.WriteLine("long : " + sizeof(long)); // 8bite
        Console.WriteLine("float : " + sizeof(float)); // 4bite
        Console.WriteLine("double : " + sizeof(double)); // 8bite
        Console.WriteLine("char : " + sizeof(char) + "\n"); // 2bite

        // character 문자의 특징,, 아스키 코드값으로 결과가 나온다
        char ec = 'A';
        char ed = 'B';
        Console.WriteLine("A : " + ec * 1);
        Console.WriteLine("B : " + ed * 1);
        Console.WriteLine(ec + ed);
        Console.WriteLine(ec - ed);
        Console.WriteLine(ec * ed);
        Console.WriteLine(ec / ed);
        Console.WriteLine(ec % ed + "\n");

        // 불링
        Console.WriteLine("bool e = 10 < 0 : " + e);
        Console.WriteLine("bool e = 10 < 0 : " + f);
    }
}