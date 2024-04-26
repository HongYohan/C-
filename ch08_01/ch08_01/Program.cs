internal class Program
{
	class Wanted<T>
	{
		public T Value; // 값 입력시 T에는 해당 제네릭이 들어가져서 var과 비슷한 느낌이다.
		public Wanted(T value)
		{
			this.Value = value;
		}
	}

	class SquareCalculator
	{
		public int this[int x] // 인덱서를 배열처럼 사용하는 제곱 클래스
		{
			get
			{
				return x*x; // 값을 받고 반환함
			}
		}
	}
	private static void Main(string[] args)
	{
		Wanted<string> wantedString = new Wanted<string>("String");
		// Wanted<T>라는 제네릭에서 <string>형으로 값을 받겠다는 뜻이다
		Wanted<int> wantedInt = new Wanted<int>(52273);
		Wanted<double> wantedDouble = new Wanted<double>(52.273);

		Console.WriteLine(wantedString.Value);
		Console.WriteLine(wantedInt.Value);
		Console.WriteLine(wantedDouble.Value);

		SquareCalculator square = new SquareCalculator();
		Console.WriteLine(square[10]);
	}
}