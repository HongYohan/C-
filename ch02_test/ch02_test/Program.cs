internal class Program
{
    private static void Main(string[] args)
    {
        // 단위변환 프로그램
        Console.Write("inch : ");
        string inch_num = Console.ReadLine(); //입력받은 문자를 문자열 변수로 저장함
        //int intinch_num = (int)inch_num;  강제 변환은 readline으로 받았을때 안됨
        Console.WriteLine("Your inch: " + float.Parse(inch_num) + " inch");

        double cm_num = 2.54 * double.Parse(inch_num); // 문자열 변수를 실수형으로 바꿔줌, 작은것을 큰것에 담아 문제가 없음
        Console.WriteLine("결과 값 : " + cm_num.ToString("F2") + " cm\n\n\n");



        // 사칙연산 프로그램
        Console.Write("첫 번째 정수 : ");
        string num1 = Console.ReadLine();
        Console.Write("두 번째 정수 : ");
        string num2 = Console.ReadLine();

        Console.WriteLine(num1 + " + " + num2 + ": " + (int.Parse(num1) + int.Parse(num2))); // WriteLine으로 사칙연산은 괄호를 쓰는게좋음
        Console.WriteLine(num1 + " - " + num2 + ": " + (int.Parse(num1) - int.Parse(num2))); // 왜냐하면 문자로 취급될수도 있기 때문
        Console.WriteLine(num1 + " * " + num2 + ": " + (int.Parse(num1) * int.Parse(num2)));
        Console.WriteLine(num1 + " / " + num2 + ": " + (double.Parse(num1) / double.Parse(num2)).ToString("F2"));



        // 원의 둘레와 넓이 구하기
        Console.Write("\n\n반지름: ");
        double r = double.Parse(Console.ReadLine());
        double PI = 3.14159;
        Console.WriteLine("원의 둘레: " + (2 * PI * r).ToString("F3"));
        Console.WriteLine("원의 넓이: " + (PI * Math.Pow(r, 2)).ToString("F3")); // Math.Pow(값, 제곱근)을 의미함



        // 문자 계산 프로그램
        Console.Write("문자 입력: ");
        char cHar = char.Parse(Console.ReadLine()); //ReadLine 문자열로 받는다

        Console.Write("정수 입력: ");
        int xnum = int.Parse(Console.ReadLine()); //Read 숫자 입력

        int ascod = Convert.ToInt32(cHar); //문자를 아스키코드에 의해 숫자로 변환 ,Parse 안될시 convert
        int ascod_update = ascod + xnum;
        char ch_cHar = Convert.ToChar(ascod_update); // 숫자값을 아스키코드에 의해 문자로 변환

        Console.WriteLine("1. 연산 수행 전");
        Console.WriteLine("-아스키코드 값: " + ascod);
        Console.WriteLine("-변환된 문자 출력: " + cHar);

        Console.WriteLine("2. 연산 수행 후");
        Console.WriteLine("-아스키코드 값: " + ascod_update);
        Console.WriteLine("-변환된 문자 출력: " + ch_cHar);
    }
}