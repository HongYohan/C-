internal class Program
{
    private static void Main(string[] args)
    {
        // 증감연산자
        int num = 10;
        Console.WriteLine(num++); // 이전값을 출력후 결과를 더함,, 나중계산
        Console.WriteLine(++num); // 이전값에 덧셈을 한후 값을 출력,, 먼저계산
        Console.WriteLine(num--); // 이전값 출력 후 결과를 뺌
        Console.WriteLine(--num); // 이전값에 마이너스를 한후 값을 출력

        // 자료형 검사
        Console.WriteLine(num.GetType()); // Int32 즉 4bite int형이라고 결과가 나온다.

        // var 변수]
        var local = 273;
        Console.WriteLine(local.GetType()); // int형으로 받아진다,, 하지만 지역변수에서만 사용가능
        
        // 입력
        string input = Console.ReadLine();
        Console.WriteLine("input: " + input);

        // 자료형 변환
        double number = 52.276103;
        Console.WriteLine((float)number); // number이라는 변수값이 float안에 포함할수있는 값 이므로 강제개행 가능
        Console.WriteLine(number.ToString("0.0"));
        Console.WriteLine(number.ToString("0.00")); // 반올림이 실행된다
        Console.WriteLine(number.ToString("0.000"));
        Console.WriteLine(number.ToString("0.0000"));

        int number2 = 52273;
        string outputA = number2 + "?"; // string으로 문자열로 저장됨
        Console.WriteLine(outputA);
        Console.WriteLine(outputA.GetType());

        char character2 = 'a';
        string outputB = character2 + "b"; // 문자열에 a와 b를 합친다
        Console.WriteLine(outputB);
        Console.WriteLine(outputB.GetType());

        string outputC = (int)character2 + "?"; // 강제 타입변환: (int)character2
        Console.WriteLine(outputC);
        Console.WriteLine(outputC.GetType());

        // int.Parse(),, long.Parse(),,,
        Console.WriteLine(int.Parse("52")); // "52"인 자료형을 int형으로 변환해서 출력함
        Console.WriteLine((52).ToString()); // 값은 int형 이지만 ToString으로 문자열로 타입이 바뀐다
        Console.WriteLine((52.273).ToString("0.0")); // ToString("0.0")이것은 형식을 설정해주는 format 형식이다, 자동반올림
        double pi = 3.14159265358979323846;
        Console.WriteLine(pi.ToString("F4")); // 자동 반올림, 4번째 자리까지 출력
        Console.WriteLine(pi.ToString("E2")); // 지수 형태로 2자리 까지 출력
        Console.WriteLine(pi.ToString("E4"));

        // 기타 출력법
        /*int number1 = 10;
        int number2 = 20;
        Console.WriteLine(string.Format("입력 값 {0}은 {1}이다.", number1, number2)); // string format 형식 지정
        Console.WriteLine($"중간 값은: {number1}"); // $로 직접 값 연결
        Console.WriteLine("중간 값은: {0}", number1); // 바로 연결*/

    }
}