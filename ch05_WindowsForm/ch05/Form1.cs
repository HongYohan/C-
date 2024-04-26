namespace ch05
{
	public partial class Form1 : Form // Form은 부모 클래스로 부터 Form1은 상속 받았다는 의미
	{
		public Form1() // 생성자
		{
			InitializeComponent();

			int width = 200;
			int height = 40;
			int margin = 6; //여백
			mybutton1.Text = "코드에서 변경!"; // [디자인]에 생성한 button에 대해서 변경함
			mybutton1.Width = width;
			mybutton1.Height = height;
			mybutton1.Location = new Point(margin,0);

			for (int i = 0; i < 5; i++)
			{
				Button button = new Button();
				Controls.Add(button); // 버튼추가
				button.Location = new Point(margin, (margin+height)*(i+1)); // 위치
				button.Text = "동적 생성 " + i + "번째";  //제목
				button.Width = width; // 넓이
				button.Height = height; // 높이
			}

		}
	}
}