namespace ch06_WindowForm
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
			components = new System.ComponentModel.Container();
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// button1
			// 
			button1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(143, 44);
			button1.Margin = new Padding(2);
			button1.Name = "button1";
			button1.Size = new Size(243, 51);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(271, 105);
			textBox1.Margin = new Padding(2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(115, 34);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(143, 108);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(66, 28);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(143, 148);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(66, 28);
			label2.TabIndex = 3;
			label2.Text = "label2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(320, 148);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(66, 28);
			label3.TabIndex = 4;
			label3.Text = "label3";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(143, 186);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(66, 28);
			label4.TabIndex = 5;
			label4.Text = "label4";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(162, 9);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(66, 28);
			label5.TabIndex = 6;
			label5.Text = "label5";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(560, 270);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private System.Windows.Forms.Timer timer1;
	}
}