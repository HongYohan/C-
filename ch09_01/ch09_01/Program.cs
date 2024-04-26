namespace IComparaleBasic
{
	internal class Program
	{
		class Product : IComparable // IComparable 인터페이스 상속
		{
			public string Name { get; set; }
			public int Price { get; set; }
			public override string ToString() // 문자열을 반환하는 함수
			{
				return Name + " : " + Price + "원";
			}
			public int CompareTo(object obj) // 상속받은 CompareTo에다가
			{ // 내가 원하는 값에 대한 형식 즉,, 메서드를 구현
				return this.Price.CompareTo((obj as Product).Price);
			}
		}
		class Dummy : IDisposable // IDisposable로 호출
		{
			public void Dispose() 
			{
				Console.WriteLine("Dispose() 메서드를 호출합니다.");
			}
		}

		static void Main(string[] args)
		{
			List<Product> list = new List<Product>()
			{
				new Product() {Name = "고구마",Price =1500},
				new Product() {Name = "사과",Price=2400},
				new Product() {Name = "바나나", Price=1000},
				new Product() {Name = "배", Price = 3000}
			};
			list.Sort(); // IComparable 인터페이스가 구현 되어서 해당 값에 대한 메서드 형식이 결정이 됨
			foreach (var item in list) { Console.WriteLine(item); }

			Dummy dummy = new Dummy(); // IDisposable 메서드는 인터페이스 호출로 해야한다
			dummy.Dispose(); // 클래스 형태로 호출
		}
	}
}