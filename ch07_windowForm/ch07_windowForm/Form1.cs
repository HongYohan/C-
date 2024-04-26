namespace ch07_windowForm
{
	public partial class Form1 : Form
	{
		class CustomForm : Form
		{
			public CustomForm()
			{
				Text = "����� ���� ��";
				this.Size = new Size(400, 300); // ����� ���� �� ũ��
			}

		}
		public Form1()
		{
			InitializeComponent();
			IsMdiContainer = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult result;

			do
			{
				MessageBox.Show("����");
				MessageBox.Show("����", "����");
				result = MessageBox.Show("����", "����", MessageBoxButtons.RetryCancel);
			} while (DialogResult.Retry == result);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CustomForm form = new CustomForm();
			form.MdiParent = this; //�θ��� �ȿ��� ȣ���� �ɼ��ְ� �Ѵ�
			form.Show();
		}
	}
}