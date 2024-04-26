namespace ch09_windows
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://hanb.co.kr");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();

			foreach (var item in Controls)
			{
				if (item is CheckBox)
				{
					CheckBox checkbox = (CheckBox)item;
					if (checkbox.Checked)
					{
						list.Add(checkbox.Text);
					}
				}
			}
			MessageBox.Show(string.Join(",", list));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (var item in Controls)
			{
				if (item is GroupBox)
				{
					foreach(var item2 in ((GroupBox)item).Controls)
					{
						RadioButton radioButton = item2 as RadioButton;
						if(radioButton != null && radioButton.Checked)
						{
							MessageBox.Show(radioButton.Text);
						}
					}
				}
			}
		}
	}
}