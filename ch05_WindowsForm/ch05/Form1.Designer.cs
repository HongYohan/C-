﻿namespace ch05
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
			mybutton1 = new Button();
			SuspendLayout();
			// 
			// mybutton1
			// 
			mybutton1.Location = new Point(0, 0);
			mybutton1.Margin = new Padding(4);
			mybutton1.Name = "mybutton1";
			mybutton1.Size = new Size(140, 40);
			mybutton1.TabIndex = 0;
			mybutton1.Text = "마음대로";
			mybutton1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(560, 270);
			Controls.Add(mybutton1);
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button mybutton1;
	}
}