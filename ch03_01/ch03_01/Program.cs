internal class Program
{
    private static void Main(string[] args)
    {
        //if (조건)
        //{

        //}
        //else
        //{
        //    if (조건)
        //    {

        //    }
        //    else if (조건)
        //    {

        //    }
        //    else
        //    {
        //        나머지 조건
        //     }
        //}

        // if - else
        //두개의 서로 다른 숫자를 입력받아 큰 수를 출력
         Console.WriteLine("두 정수 크기 판별식");
         Console.Write("첫 번째 숫자 입력: ");
         int number1 = int.Parse(Console.ReadLine());
         Console.Write("두 번째 숫자 입력: ");
         int number2 = int.Parse(Console.ReadLine());
         if (number1 > number2) Console.WriteLine("두 수중에 큰 수는 " + number1 + "이고, 작은 수는 " + number2 + "이다.");
         else Console.WriteLine("두 수중에 큰 수는 " + number2 + "이고, 작은 수는 " + number1 + "이다.");


         // 중첩 조건문
         //입력된 수가 양수, 0, 음수 인지를 판별
         Console.WriteLine("\n\n정수의 부호 판별식");
         Console.Write("숫자 입력: ");
         int number = int.Parse(Console.ReadLine());
         if (number > 0)
         {
             string s = string.Format("입력 값 {0}은 양수이다.", number); 
             Console.WriteLine(s);
         }
         else
         {
             if (number == 0) Console.WriteLine($"입력 값 {number}은 zero이다."); //$로 바로 변수값을 불러들임
             else Console.WriteLine("입력 값 {0}은 음수이다.", number); //항상 0부터 시작
         }


         //삼항 연산자
         Console.WriteLine("\n\n정수의 부호 판별식");
         Console.Write("숫자 입력: ");
         int number_s = int.Parse(Console.ReadLine());
         string s_s = number_s > 0 ? "양수" : number_s == 0 ? "zero" : "음수";
         Console.WriteLine(string.Format("입력 값 {0}은 {1}이다.", number_s, s_s));


         //놀이 공원 입장
         Console.WriteLine("\n\n롤러코스터 판별식");
         Console.Write("나이 입력: ");
         int age = int.Parse(Console.ReadLine());
         if (age < 9)
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


         // 2자리 정수 판별식
         Console.WriteLine("\n\n2자리 정수판별식");
         Console.Write("2자리 정수 입력: ");
         string num= Console.ReadLine();
         if (int.Parse(num) < 10) Console.WriteLine("10~99 사이의 정수만 입력하세요.");
         else
         {
             if (num[0] == num[1]) Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다."); // //로 나머지 와 비교가능
             else Console.WriteLine("No! 10의 자리와 1의 자리가 다릅니다.");
         }


         // 3개의 정수 중간값 판별식
         Console.WriteLine("\n\n3개의 정수 중간값 판별식");
         Console.WriteLine("정수 3개 입력: ");
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());
         int num3 = int.Parse(Console.ReadLine());

         if (num1 > num2 && num1 > num3)//num1이 가장큼
         {
             if (num2 > num3) Console.WriteLine("중간 값은 : " + num2); //num2가 num3보다 큼
             else Console.WriteLine("중간 값은 : " + num3); //num3이 num2보다 큼
         }
         if (num2 > num1 && num2 > num3) //num2가 최대값
         {
             if (num1 > num3) Console.WriteLine("중간 값은 : " + num1); //num1이 num3보다 큼
             else Console.WriteLine("중간 값은 : " + num3);
         }
         if (num3 > num1 && num3 > num2) //num3가 최대값
         {
             if (num1 > num2) Console.WriteLine("중간 값은 : " + num1); //num1이 num2보다 큼
             else Console.WriteLine("중간 값은 : " + num2); //$"중간 값은: {num2}" ("중간 값은: {0}",num2)
         }


         // 2자리 정수 판별식,, if - else if - else
         Console.Write("2자리 정수 입력: ");
         int num = int.Parse(Console.ReadLine());
         int a = num / 10;
         int b = num % 10;

         if (num < 10 || num>=100) Console.WriteLine("10~99 사이의 정수만 입력하세요.");
         else if (a == b) Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다.");
         else Console.WriteLine("No! 10의 자리와 1의 자리가 다릅니다.");


        // 3개의 정수 중간값 판별식
        Console.WriteLine("\n\n3개의 정수 중간값 판별식");
        Console.WriteLine("정수 3개 입력: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)//num1이 가장큼
        {
            if (num2 > num3) Console.WriteLine("중간 값은 : " + num2); //num2가 num3보다 큼
            else Console.WriteLine($"중간 값은 : {num3}"); //num3이 num2보다 큼
        }
        else if (num2 > num1 && num2 > num3) //num2가 최대값
        {
            if (num1 > num3) Console.WriteLine("중간 값은: {0}", num1); //num1이 num3보다 큼
            else Console.WriteLine($"중간 값은 : {num3}");
        }
        else //num3가 최대값
        {
            if (num1 > num2) Console.WriteLine("중간 값은: {0}", num1); //num1이 num2보다 큼
            else Console.WriteLine($"중간 값은 : {num2}"); //$"중간 값은: {num2}" ("중간 값은: {0}",num2)
        }


        // 학점 판별식
        Console.WriteLine("\n\n학점 판별");
        Console.WriteLine("점수 입력: ");
        int num_1 = int.Parse(Console.ReadLine());

        if (num_1 >= 90) Console.WriteLine("A학점");
        else if (num_1 >= 80) Console.WriteLine("B학점");
        else if (num_1 >= 70) Console.WriteLine("C학점");
        else if (num_1 >= 60) Console.WriteLine("D학점");
        else Console.WriteLine("재수강으로 분발하세요");


        // 연산식
        Console.WriteLine("\n\n연산");
        Console.WriteLine("숫자 2개와 연산자(+,-,*,/,%)중 하나 입력: ");
        int num_2 = int.Parse(Console.ReadLine());
        int num_3 = int.Parse(Console.ReadLine());
        string num_4 = Console.ReadLine();

        if (num_4 == "+") Console.WriteLine("{0} + {1} = {2}", num_2, num_3, num_2 + num_3);  //num_4.Equals("+")
        else if (num_4 == "-") Console.WriteLine("{0} - {1} = {2}", num_2, num_3, num_2 - num_3);
        else if (num_4 == "*") Console.WriteLine("{0} * {1} = {2}", num_2, num_3, num_2 * num_3);
        else if (num_4 == "/") Console.WriteLine("{0} / {1} = {2}", num_2, num_3, num_2 / (double)num_3);
        else if (num_4 == "%") Console.WriteLine("{0} % {1} = {2}", num_2, num_3, num_2 % num_3);
        else Console.WriteLine("연산자를 정확하게 입력하세요");



        // 학점 판별식,, switch - case
        Console.WriteLine("\n\n학점 판별");
        Console.WriteLine("점수 입력: ");
        int num_1 = int.Parse(Console.ReadLine());

        switch (num_1) //num_1/10 점수대 표현함
        {
            case >= 90: // case 9 90점대 이상에 할당됨
                Console.WriteLine("A학점");
                break;
            case >= 80:
                Console.WriteLine("B학점");
                break;
            case >= 70:
                Console.WriteLine("C학점");
                break;
            case >= 60:
                Console.WriteLine("D학점");
                break;
            default:
                Console.WriteLine("재수강으로 분발하세요");
                break;
        }



        // 연산식
        Console.WriteLine("\n\n연산");
        Console.WriteLine("숫자 2개와 연산자(+,-,*,/,%)중 하나 입력: ");
        int num_2 = int.Parse(Console.ReadLine());
        int num_3 = int.Parse(Console.ReadLine());
        string num_4 = Console.ReadLine();

        switch (num_4)
        {
            case "+":
                Console.WriteLine($"{num_2} + {num_3} = " + (num_2 + num_3));
                break;
            case "-":
                Console.WriteLine($"{num_2} - {num_3} = " + (num_2 - num_3));
                break;
            case "*":
                Console.WriteLine($"{num_2} * {num_3} = " + (num_2 * num_3));
                break;
            case "/":
                Console.WriteLine($"{num_2} / {num_3} = " + (num_2 / (double)num_3));
                break;
            case "%":
                Console.WriteLine($"{num_2} % {num_3} = " + (num_2 % num_3));
                break;
            default:
                Console.WriteLine("연산자를 정확하게 입력하세요");
                break;
        }



        // Contains(),, 입력한 값에 조건의 값이 있다면 조건 실행
        Console.Write("입력 : ");
        string line =Console.ReadLine();
        if (line.Contains("안녕")) Console.WriteLine("안녕하세요.."); 
        else Console.WriteLine("^ ^");
    }
}