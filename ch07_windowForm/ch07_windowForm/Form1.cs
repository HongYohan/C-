namespace ch07_windowForm
{
	public partial class Form1 : Form
	{
		class CustomForm : Form
		{
			public CustomForm()
			{
				Text = "사용자 정의 폼";
				this.Size = new Size(400, 300); // 사용자 정의 폼 크기
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
				MessageBox.Show("뭘봐");
				MessageBox.Show("뭘봐", "제목");
				result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
			} while (DialogResult.Retry == result);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CustomForm form = new CustomForm();
			form.MdiParent = this; //부모폼 안에서 호출이 될수있게 한다
			form.Show();
		}
	}
}