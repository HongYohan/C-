namespace ch10_windows
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			comboBox1 = new ComboBox();
			listBox1 = new ListBox();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(73, 42);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(228, 40);
			comboBox1.TabIndex = 0;
			// 
			// listBox1
			// 
			listBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 32;
			listBox1.Location = new Point(488, 42);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(183, 132);
			listBox1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(73, 180);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 33;
			dataGridView1.Size = new Size(360, 228);
			dataGridView1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(73, 107);
			label1.Name = "label1";
			label1.Size = new Size(166, 32);
			label1.TabIndex = 3;
			label1.Text = "콤보선택 결과";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(488, 232);
			label2.Name = "label2";
			label2.Size = new Size(190, 32);
			label2.TabIndex = 4;
			label2.Text = "리스트선택 결과";
			// 
			// button1
			// 
			button1.Location = new Point(676, 281);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 5;
			button1.Text = "장바구니";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(488, 286);
			label3.Name = "label3";
			label3.Size = new Size(48, 25);
			label3.TabIndex = 6;
			label3.Text = "결과";
			label3.Click += label3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(listBox1);
			Controls.Add(comboBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox1;
		private ListBox listBox1;
		private DataGridView dataGridView1;
		private Label label1;
		private Label label2;
		private Button button1;
		private Label label3;
	}
}