internal class Program
{
    private static void Main(string[] args)
    {
        /*// for문
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("출력");
        }

        // 기본적인 배열,, 배열[인덱스],, 초기화
        int[] intArray = { 52, 273, 32, 65, 103 };
        long[] longArray = { 52, 273, 32, 65, 103 };
        float[] floatArray = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
        double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        char[] icharArray = { '가', '나', '다', '라' };
        string[] stringArray = { "홍요한", "유대훈", "윤아린" };

        Console.WriteLine(intArray[2]); // 인덱스로도 접근가능
        Console.WriteLine(intArray.Length); // 5가 나온다

        // 배열 생성
        int[] Array = new int[100]; // 100개의 인덱스 공간이 생김

        // while 반복문
        Console.Write("배열의 개수를 선언하십시오: ");
        int cnt = int.Parse(Console.ReadLine());
        int[] array = new int[cnt];
        int i = 0;
        int sum = 0;

        Console.WriteLine("배열의 값을 입력하시오(Enter)");
        while (i < array.Length)
        {
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }
        i = 0;
        while (i < array.Length)
        {
            Console.WriteLine(i + "번째 배열 출력: " + array[i]);
            sum += array[i];
            i++;
        }
        Console.WriteLine($"누적의 합 : {sum}");
        Console.WriteLine("누적의 평균 : {0}", sum / cnt);

        // for 반복문
        Console.Write("배열의 개수를 선언하십시오: ");
        int cnt = int.Parse(Console.ReadLine());
        int[] array = new int[cnt];
        int sum = 0;

        Console.WriteLine("배열의 값을 입력하시오(Enter)");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(i + "번째 배열 출력: " + array[i]);
            sum += array[i];
        }
        Console.WriteLine($"누적의 합 : {sum}");
        Console.WriteLine("누적의 평균 : {0}", sum / cnt);*/


        // for(;;): 무한반복문
        // 이중 while, for 문
        int i = 0;
        while (i < 10)
        {
            int j = 1;
            while (j < 10 - i)
            {
                Console.Write('-');
                j++;
            }
            int k = 0;
            while (k < i + 1)
            {
                Console.Write('♥');
                k++;
            }
            Console.Write('\n');
            i++;
        }


        for (int o = 10; o > 0; o--) // 역for문
        {
            for (int j = 0; j < o; j++)
            {
                Console.Write('♡');
            }
            for (int j = 0; j < 10 - o; j++)
            {
                Console.Write('-');
            }
            Console.Write('\n');
        }

        /*// while(true): 무한반복 break;
        // foreach (자료형 변수 in 컬렉션)

        // goto 키워드,, 반복문 탈출때 사용
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("외부 반복문");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("내부 반복문");
                goto doNotUse;
            }
        }
    doNotUse:
        Console.WriteLine("goto 키워드");

        // continue;
        Console.Write("정수: ");
        int cnt = int.Parse(Console.ReadLine());
        int i = 0;
        while (i < cnt)
        {
            if (i % 2 == 0)
            {
                i++;
                continue;
            }
            Console.WriteLine(i);
            i++;
        }*/
    }
}