internal class Program
{
	class Product
	{
		public static int counter =0;
		public int id;
		public string name;
		public int price;
		public Product(string name, int price)
		{
			Product.counter = counter+1;
			this.id = counter; // this는 클래스 자기자신을 의미 즉, Product.name하고 같은 의미이다.
			this.name = name;
			this.price = price;
		}
		public const double PI = 3.141592; // const는 상수 생성 호출어 이다
		~Product() // ~는 소멸자 호출 기호이다.
		{
			Console.WriteLine(this.name+"의 소멸자 호출");
		}
	}
	private static void Main(string[] args)
	{
		// Program 변수는 private 접근 제한자 이다,, 접근 제한자는 오직 해당 클래스 내부에서만 호출 가능
		Product productA = new Product("감자", 2000); // 각 생성자의 값을 초기화 시킨다.
		Product productB = new Product("고구마", 3000);
		Console.WriteLine(productA.id + ":" + productA.name);
		Console.WriteLine(productB.id + ":" + productB.name);
		Console.WriteLine(Product.counter + "개 생성되었습니다.");
		GC.Collect();
	}
}