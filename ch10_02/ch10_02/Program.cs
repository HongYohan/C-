internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("입력: ");
		try
		{
			string input = Console.ReadLine();
			int[] array = { 52, 273, 32, 103 };

			int index = int.Parse(input);
			Console.WriteLine("입력 숫자:"+index);
			Console.WriteLine("배열 요소: " + array[index]);
		}
		catch (FormatException e)
		{
			Console.WriteLine("FormatException 발생");
			Console.WriteLine(e.GetType()+"이 발생했습니다.");
		}
		catch(IndexOutOfRangeException e)
		{
			Console.WriteLine("IndexOutOfRangeException 발생");
			Console.WriteLine(e.GetType()+"이 발생했습니다.");
		}
	}
}