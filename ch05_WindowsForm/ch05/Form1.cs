namespace ch05
{
	public partial class Form1 : Form // Form�� �θ� Ŭ������ ���� Form1�� ��� �޾Ҵٴ� �ǹ�
	{
		public Form1() // ������
		{
			InitializeComponent();

			int width = 200;
			int height = 40;
			int margin = 6; //����
			mybutton1.Text = "�ڵ忡�� ����!"; // [������]�� ������ button�� ���ؼ� ������
			mybutton1.Width = width;
			mybutton1.Height = height;
			mybutton1.Location = new Point(margin,0);

			for (int i = 0; i < 5; i++)
			{
				Button button = new Button();
				Controls.Add(button); // ��ư�߰�
				button.Location = new Point(margin, (margin+height)*(i+1)); // ��ġ
				button.Text = "���� ���� " + i + "��°";  //����
				button.Width = width; // ����
				button.Height = height; // ����
			}

		}
	}
}