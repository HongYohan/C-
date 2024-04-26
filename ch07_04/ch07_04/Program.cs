internal class Program
{
	class Parent
	{
		public virtual void Method() 
		{
			Console.WriteLine("부모의 메서드");
		}
	}
	class Child : Parent
	{
		public override void Method() // 자식의 메서드에 override 키워드를 적용
		{
			Console.WriteLine("자식의 메서드");
		}
	}
	private static void Main(string[] args)
	{
		Child child = new Child();
		child.Method();
		((Parent)child).Method(); // 오버라이딩으로 인해 Parent의 값도 child 값으로 변경됨
	}
}