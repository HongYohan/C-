namespace ch09_windows
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
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox3 = new CheckBox();
			button1 = new Button();
			label1 = new Label();
			linkLabel1 = new LinkLabel();
			groupBox1 = new GroupBox();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			groupBox2 = new GroupBox();
			radioButton4 = new RadioButton();
			radioButton5 = new RadioButton();
			radioButton6 = new RadioButton();
			button2 = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(85, 113);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(74, 29);
			checkBox1.TabIndex = 0;
			checkBox1.Text = "감자";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(85, 163);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(92, 29);
			checkBox2.TabIndex = 1;
			checkBox2.Text = "고구마";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Location = new Point(85, 219);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(92, 29);
			checkBox3.TabIndex = 2;
			checkBox3.Text = "토마토";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(56, 294);
			button1.Name = "button1";
			button1.Size = new Size(187, 40);
			button1.TabIndex = 3;
			button1.Text = "클릭";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(85, 9);
			label1.Name = "label1";
			label1.Size = new Size(48, 25);
			label1.TabIndex = 4;
			label1.Text = "글자";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(85, 49);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(48, 25);
			linkLabel1.TabIndex = 5;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "글자";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Location = new Point(277, 100);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(209, 136);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "곡물";
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(25, 101);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(91, 29);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "옥수수";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(25, 66);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(91, 29);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "고구마";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(25, 30);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(73, 29);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "감자";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(radioButton4);
			groupBox2.Controls.Add(radioButton5);
			groupBox2.Controls.Add(radioButton6);
			groupBox2.Location = new Point(556, 100);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(209, 136);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "과일";
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(25, 101);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(73, 29);
			radioButton4.TabIndex = 2;
			radioButton4.TabStop = true;
			radioButton4.Text = "딸기";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			radioButton5.AutoSize = true;
			radioButton5.Location = new Point(25, 66);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new Size(73, 29);
			radioButton5.TabIndex = 1;
			radioButton5.TabStop = true;
			radioButton5.Text = "사과";
			radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			radioButton6.AutoSize = true;
			radioButton6.Location = new Point(25, 30);
			radioButton6.Name = "radioButton6";
			radioButton6.Size = new Size(73, 29);
			radioButton6.TabIndex = 0;
			radioButton6.TabStop = true;
			radioButton6.Text = "포도";
			radioButton6.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(448, 294);
			button2.Name = "button2";
			button2.Size = new Size(187, 40);
			button2.TabIndex = 8;
			button2.Text = "클릭";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(linkLabel1);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(checkBox3);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private Button button1;
		private Label label1;
		private LinkLabel linkLabel1;
		private GroupBox groupBox1;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private GroupBox groupBox2;
		private RadioButton radioButton4;
		private RadioButton radioButton5;
		private RadioButton radioButton6;
		private Button button2;
	}
}