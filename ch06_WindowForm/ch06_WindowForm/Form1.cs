namespace ch06_WindowForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent(); // �ʱ�ȭ�� ���� �ʱ� ���� ����
			label5.Text = "202295035_ȫ����";
			label1.Text = "inch �Է� : ";
			label2.Text = "inch to cm ��� : ";
			label3.Text = "";
			button1.Text = "����ȯ��";

		}
		private int elapsedTime = 0; // �ð����� ����
		private void timer1_Tick(object sender, EventArgs e) // �ð��� ������ �ż���
		{
			elapsedTime++;
			label4.Text = elapsedTime + "�� ���";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label3.Text = double.Parse(textBox1.Text) * 2.54+" cm"; // textBox�� �Էµ� ���ڸ� double ������ �ٲٰ� ������ ���� label3�� �Է�
			/*Button self = (Button)sender; // �ڱ� �ڽſ� ���� ���� ��
			self.Text = "���� Ŭ���߽��ϴ�!";*/
			button1.Text = "���� Ŭ���߽��ϴ�!";
		}
	}
}