using ch07_02;
internal class Program
{
	private static void Main(string[] args)
	{
		Point p = new Point();
		p.set(1, 2);
		p.showPoint();

		ColorPoint cp = new ColorPoint();
		cp.set(3, 4);
		cp.setColor("red");
		cp.showColorPoint();
	}
}