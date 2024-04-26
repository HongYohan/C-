namespace ch08_windowForm
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
			menuStrip1 = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripMenuItem();
			뭘봐ToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 33);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(64, 29);
			toolStripMenuItem1.Text = "파일";
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new Size(277, 34);
			toolStripMenuItem3.Text = "toolStripMenuItem3";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { 뭘봐ToolStripMenuItem });
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(191, 29);
			toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// 뭘봐ToolStripMenuItem
			// 
			뭘봐ToolStripMenuItem.Name = "뭘봐ToolStripMenuItem";
			뭘봐ToolStripMenuItem.Size = new Size(150, 34);
			뭘봐ToolStripMenuItem.Text = "뭘봐";
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(24, 24);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
			statusStrip1.Location = new Point(0, 418);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 32);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = ";야!";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(156, 25);
			toolStripStatusLabel1.Text = "뒤져라이거머리야";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(183, 25);
			toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(183, 25);
			toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem2;
		private StatusStrip statusStrip1;
		private ToolStripMenuItem 뭘봐ToolStripMenuItem;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel3;
	}
}