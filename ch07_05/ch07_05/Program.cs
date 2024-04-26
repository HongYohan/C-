internal class Program
{
	class Animal
	{
		public virtual void Eat() {
			Console.WriteLine("냠냠 먹습니다.");
		}
	}
	class Dog : Animal
	{
		public new void Eat() // new로 인해 무조건 부모 클래스의 Eat에 대한 결과값이 나와야 한다
		{
			Console.WriteLine("강아지 사료를 먹습니다.");
		}
	}
	class Cat : Animal
	{
		public override void Eat() //virtual에 대한 값을 없애고 해당 override에 대한 Eat값을 표기한다.
		{
			Console.WriteLine("고양이 사료를 먹습니다.");
		}
	}
	private static void Main(string[] args)
	{
		List<Animal> list = new List<Animal>() 
		{
			new Dog(),new Cat(),new Cat(),new Dog(),
			new Dog(),new Cat(),new Dog(),new Dog(),
		};
		foreach (var item in list)
		{
			item.Eat();
		}
	}
}