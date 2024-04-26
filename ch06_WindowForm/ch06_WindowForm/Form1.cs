namespace ch06_WindowForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent(); // 초기화로 인한 초기 값을 지정
			label5.Text = "202295035_홍요한";
			label1.Text = "inch 입력 : ";
			label2.Text = "inch to cm 결과 : ";
			label3.Text = "";
			button1.Text = "단위환산";

		}
		private int elapsedTime = 0; // 시간지정 변수
		private void timer1_Tick(object sender, EventArgs e) // 시간을 보내는 매서드
		{
			elapsedTime++;
			label4.Text = elapsedTime + "초 경과";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label3.Text = double.Parse(textBox1.Text) * 2.54+" cm"; // textBox에 입력된 문자를 double 형으로 바꾸고 연산한 값을 label3에 입력
			/*Button self = (Button)sender; // 자기 자신에 대한 변수 값
			self.Text = "저를 클릭했습니다!";*/
			button1.Text = "저를 클릭했습니다!";
		}
	}
}