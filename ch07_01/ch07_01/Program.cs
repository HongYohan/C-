using ch07_01;
internal class Program
{
	private static void Main(string[] args)
	{
		/*List<Dog> dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
		List<Cat> cats= new List<Cat>() { new Cat(), new Cat(), new Cat() };

		foreach (var item in dogs) {
			item.Eat();
			item.Sleep();
			item.Bark();
		}
		foreach (var item in cats)
		{
			item.Eat();
			item.Sleep();
			item.Meow();
		}*/


		// 다형성
		List<Animal> Animals = new List<Animal>() { new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat() };

		foreach (var item in Animals)
		{
			item.Eat();
			item.Sleep();
			
			if(item is  Dog) { ((Dog)item).Bark(); }
			if(item is Cat) { ((Cat)item).Meow(); }
		}

		// 위에 하고 같은 의미
		foreach (var item in Animals)
		{
			item.Eat();
			item.Sleep();

			// as를 이용해서 각 인자값을 넣는데 만약에 null값이 생기더라도 item이라는 변수에는 아무값도 넣지 않는다
			var dog = item as Dog; // null != dog에 없다면 dog.bark를 이용한다
			if (dog != null) { dog.Bark(); }
			var cat = item as Cat;
			if (cat != null) { cat.Meow();}
	}
}