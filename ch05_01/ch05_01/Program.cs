internal class Program
{
	static int cv; // 클래스 변수
	int iv; // 인스턴스 변수

	class Student
	{
		public string name;
		public int grade;
	}
	private static void Main(string[] args)
	{
		Random r = new Random();
		List<int> list = new List<int>();
		
		for (int i = 0; i < 10; i++)
		{
			list.Add(r.Next(1, 21));
		}

		Console.WriteLine("삭제 전: ");
		for(int i = 0;i < list.Count; i++)
		{
			Console.WriteLine(" "+list[i]);
		}
		
		// 역 for문
		for(int i = list.Count-1; i >= 0; i--)
		{
			if (list[i] < 10)
			{
				list.RemoveAt(i);
			}
		}

		list.RemoveAll(x => x < 10);
		int z = 1;
		foreach(var item in list)
		{
			Console.WriteLine("생성된 개수: "+z+"\t랜덤수: "+item);
			z++;
		}

		List<Student> students = new List<Student>();
		students.Add(new Student() { name = "홍요한", grade = 1});
		students.Add(new Student() { name = "홍길동", grade = 2});

		Console.WriteLine(students[0].name + students[1].grade); // 0번지의 값을 출력
	}
}