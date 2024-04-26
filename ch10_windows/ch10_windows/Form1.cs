namespace ch10_windows
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			var comboData = new List<Product>
			{
				new Product(){Name="고구마",Price=500},
				new Product(){Name="감자",Price=600},
				new Product(){Name="옥수수",Price=1200},
				new Product(){Name="밤",Price=300}
			};

			comboBox1.DisplayMember = "Name";
			comboBox1.ValueMember = "Price";
			comboBox1.DataSource = comboData;
			comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

			var listData = new List<Product>
			{
				new Product(){Name="포도",Price=2000},
				new Product(){Name="사과",Price=1000},
				new Product(){Name="딸기",Price=12000},
				new Product(){Name="수박",Price=15000}
			};

			listBox1.DisplayMember = "Name";
			listBox1.ValueMember = "Price";
			listBox1.DataSource = listData;
			listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

			void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
			{
				label1.Text = (comboBox1.SelectedIndex + 1)
					+ "번, 가격: " + comboBox1.SelectedValue
					+ ", 명칭: " + ((Product)comboBox1.SelectedItem).Name;
				label3.Text = ((Product)comboBox1.SelectedItem).Name + ": " + comboBox1.SelectedValue + "\n"
				+ ((Product)listBox1.SelectedItem).Name + ": " + listBox1.SelectedValue + "\n"
				+ "가격: " + ((int)comboBox1.SelectedValue + (int)listBox1.SelectedValue);
			}
			void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
			{
				label2.Text = (listBox1.SelectedIndex + 1)
					+ "번, 가격: " + listBox1.SelectedValue
					+ ", 명칭: " + ((Product)listBox1.SelectedItem).Name;
				label3.Text = ((Product)comboBox1.SelectedItem).Name + ": " + comboBox1.SelectedValue + "\n"
					+ ((Product)listBox1.SelectedItem).Name + ": " + listBox1.SelectedValue + "\n"
					+ "가격: " + ((int)comboBox1.SelectedValue + (int)listBox1.SelectedValue);
			}

			dataGridView1.DataSource = comboData;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(((Product)comboBox1.SelectedItem).Name + ": " + comboBox1.SelectedValue + "\n"
				+ ((Product)listBox1.SelectedItem).Name + ": " + listBox1.SelectedValue + "\n"

				+ "가격: " + ((int)comboBox1.SelectedValue + (int)listBox1.SelectedValue), "장바구니");
		}

		private void label3_Click(object sender, EventArgs e)
		{


		}
	}
}