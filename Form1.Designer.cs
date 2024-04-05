namespace TimeKeeperApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBoxStart = new PictureBox();
			pictureBoxStop = new PictureBox();
			pictureBoxAdd = new PictureBox();
			label_DD = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			label_hh = new Label();
			label_mm = new Label();
			label_ss = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			pictureBox1 = new PictureBox();
			pictureBoxPlus = new PictureBox();
			pictureBoxMinus = new PictureBox();
			pictureBoxReset = new PictureBox();
			pictureBoxResetStatusBar = new PictureBox();
			pictureBoxAddSelected = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBoxStart).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxStop).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPlus).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxMinus).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxReset).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxResetStatusBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAddSelected).BeginInit();
			SuspendLayout();
			// 
			// pictureBoxStart
			// 
			pictureBoxStart.Image = (Image)resources.GetObject("pictureBoxStart.Image");
			pictureBoxStart.Location = new Point(103, 356);
			pictureBoxStart.Name = "pictureBoxStart";
			pictureBoxStart.Size = new Size(402, 77);
			pictureBoxStart.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxStart.TabIndex = 1;
			pictureBoxStart.TabStop = false;
			pictureBoxStart.Click += pictureBoxStart_Click;
			// 
			// pictureBoxStop
			// 
			pictureBoxStop.BackColor = Color.Transparent;
			pictureBoxStop.Image = (Image)resources.GetObject("pictureBoxStop.Image");
			pictureBoxStop.Location = new Point(103, 356);
			pictureBoxStop.Name = "pictureBoxStop";
			pictureBoxStop.Size = new Size(402, 77);
			pictureBoxStop.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxStop.TabIndex = 2;
			pictureBoxStop.TabStop = false;
			pictureBoxStop.Visible = false;
			pictureBoxStop.Click += pictureBoxStop_Click;
			// 
			// pictureBoxAdd
			// 
			pictureBoxAdd.BackColor = Color.Transparent;
			pictureBoxAdd.Image = (Image)resources.GetObject("pictureBoxAdd.Image");
			pictureBoxAdd.Location = new Point(567, 356);
			pictureBoxAdd.Name = "pictureBoxAdd";
			pictureBoxAdd.Size = new Size(402, 77);
			pictureBoxAdd.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxAdd.TabIndex = 3;
			pictureBoxAdd.TabStop = false;
			pictureBoxAdd.Click += pictureBoxAdd_Click;
			// 
			// label_DD
			// 
			label_DD.AutoSize = true;
			label_DD.BackColor = Color.Transparent;
			label_DD.Font = new Font("Digital-7 Mono", 135F, FontStyle.Regular, GraphicsUnit.Point);
			label_DD.ForeColor = Color.FromArgb(243, 152, 0);
			label_DD.Location = new Point(68, 110);
			label_DD.Name = "label_DD";
			label_DD.Size = new Size(239, 179);
			label_DD.TabIndex = 4;
			label_DD.Text = "00";
			label_DD.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(262, 131);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(49, 133);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(477, 131);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(49, 133);
			pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(689, 131);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(49, 133);
			pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox4.TabIndex = 7;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(903, 131);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(49, 133);
			pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox5.TabIndex = 8;
			pictureBox5.TabStop = false;
			// 
			// label_hh
			// 
			label_hh.AutoSize = true;
			label_hh.BackColor = Color.Transparent;
			label_hh.Font = new Font("Digital-7 Mono", 135F, FontStyle.Regular, GraphicsUnit.Point);
			label_hh.ForeColor = Color.FromArgb(243, 152, 0);
			label_hh.Location = new Point(282, 110);
			label_hh.Name = "label_hh";
			label_hh.Size = new Size(239, 179);
			label_hh.TabIndex = 9;
			label_hh.Text = "00";
			label_hh.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label_mm
			// 
			label_mm.AutoSize = true;
			label_mm.BackColor = Color.Transparent;
			label_mm.Font = new Font("Digital-7 Mono", 135F, FontStyle.Regular, GraphicsUnit.Point);
			label_mm.ForeColor = Color.FromArgb(243, 152, 0);
			label_mm.Location = new Point(495, 110);
			label_mm.Name = "label_mm";
			label_mm.Size = new Size(239, 179);
			label_mm.TabIndex = 10;
			label_mm.Text = "00";
			label_mm.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label_ss
			// 
			label_ss.AutoSize = true;
			label_ss.BackColor = Color.Transparent;
			label_ss.Font = new Font("Digital-7 Mono", 135F, FontStyle.Regular, GraphicsUnit.Point);
			label_ss.ForeColor = Color.FromArgb(243, 152, 0);
			label_ss.Location = new Point(707, 110);
			label_ss.Name = "label_ss";
			label_ss.Size = new Size(239, 179);
			label_ss.TabIndex = 11;
			label_ss.Text = "00";
			label_ss.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 33;
			timer1.Tick += timer1_Tick;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = null;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1004, 421);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBoxPlus
			// 
			pictureBoxPlus.Image = (Image)resources.GetObject("pictureBoxPlus.Image");
			pictureBoxPlus.Location = new Point(41, 141);
			pictureBoxPlus.Name = "pictureBoxPlus";
			pictureBoxPlus.Size = new Size(56, 112);
			pictureBoxPlus.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxPlus.TabIndex = 12;
			pictureBoxPlus.TabStop = false;
			// 
			// pictureBoxMinus
			// 
			pictureBoxMinus.Image = (Image)resources.GetObject("pictureBoxMinus.Image");
			pictureBoxMinus.Location = new Point(41, 141);
			pictureBoxMinus.Name = "pictureBoxMinus";
			pictureBoxMinus.Size = new Size(56, 112);
			pictureBoxMinus.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxMinus.TabIndex = 13;
			pictureBoxMinus.TabStop = false;
			// 
			// pictureBoxReset
			// 
			pictureBoxReset.Image = (Image)resources.GetObject("pictureBoxReset.Image");
			pictureBoxReset.Location = new Point(331, 82);
			pictureBoxReset.Name = "pictureBoxReset";
			pictureBoxReset.Size = new Size(386, 230);
			pictureBoxReset.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxReset.TabIndex = 14;
			pictureBoxReset.TabStop = false;
			// 
			// pictureBoxResetStatusBar
			// 
			pictureBoxResetStatusBar.BackColor = Color.Red;
			pictureBoxResetStatusBar.Location = new Point(352, 232);
			pictureBoxResetStatusBar.Name = "pictureBoxResetStatusBar";
			pictureBoxResetStatusBar.Size = new Size(342, 32);
			pictureBoxResetStatusBar.TabIndex = 15;
			pictureBoxResetStatusBar.TabStop = false;
			// 
			// pictureBoxAddSelected
			// 
			pictureBoxAddSelected.BackColor = Color.Transparent;
			pictureBoxAddSelected.Image = (Image)resources.GetObject("pictureBoxAddSelected.Image");
			pictureBoxAddSelected.Location = new Point(567, 356);
			pictureBoxAddSelected.Name = "pictureBoxAddSelected";
			pictureBoxAddSelected.Size = new Size(402, 77);
			pictureBoxAddSelected.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxAddSelected.TabIndex = 16;
			pictureBoxAddSelected.TabStop = false;
			pictureBoxAddSelected.Click += pictureBoxAdd_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.Black;
			ClientSize = new Size(1028, 446);
			Controls.Add(pictureBoxAddSelected);
			Controls.Add(pictureBoxResetStatusBar);
			Controls.Add(pictureBoxReset);
			Controls.Add(pictureBoxMinus);
			Controls.Add(pictureBoxPlus);
			Controls.Add(pictureBox2);
			Controls.Add(label_DD);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox5);
			Controls.Add(label_ss);
			Controls.Add(pictureBox3);
			Controls.Add(label_mm);
			Controls.Add(label_hh);
			Controls.Add(pictureBoxAdd);
			Controls.Add(pictureBoxStop);
			Controls.Add(pictureBoxStart);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "TimeKepper";
			FormClosing += Form1_FormClosing;
			KeyDown += Form1_KeyDown;
			((System.ComponentModel.ISupportInitialize)pictureBoxStart).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxStop).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPlus).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxMinus).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxReset).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxResetStatusBar).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAddSelected).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBoxStart;
		private PictureBox pictureBoxStop;
		private PictureBox pictureBoxAdd;
		private Label label_DD;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private Label label_hh;
		private Label label_mm;
		private Label label_ss;
		private System.Windows.Forms.Timer timer1;
		private PictureBox pictureBox1;
		private PictureBox pictureBoxPlus;
		private PictureBox pictureBoxMinus;
		private PictureBox pictureBoxReset;
		private PictureBox pictureBoxResetStatusBar;
		private PictureBox pictureBoxAddSelected;
	}
}