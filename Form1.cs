using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace TimeKeeperApp
{
	public partial class Form1 : Form
	{

		enum WindowMode
		{
			Normal,
			InputAddTime
		};

		private Logger log;
		private TimerSystem timerSystem;
		Reseter reseter = new();

		private string keyInputBufferValue = "";
		private int keyInputBufferValueLimitedLength = 8;
		private bool addTimeIsPlus = true;

		private WindowMode windowMode = WindowMode.Normal;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		// キーの押しっぱなしを取得する。フォーカス時限定
		private bool IsKeyPress(Keys keyCode)
		{
			return GetKeyState((int)keyCode) < 0 && WindowSelectionChecker.IsWindowSelected(this);
		}

		private static void PlayAlert()
		{
			SoundPlayer simpleSound = new(@"./Alert.wav");
			simpleSound.Play();
		}

		public Form1()
		{
			InitializeComponent();

			log = new Logger();
			timerSystem = new(log);
			timerSystem.onTimeOut += PlayAlert;

			log.Write("System Starts");

			pictureBoxPlus.Visible = pictureBoxPlus.Enabled = false;
			pictureBoxMinus.Visible = pictureBoxMinus.Enabled = false;

			pictureBoxReset.Visible = pictureBoxReset.Enabled = false;
			pictureBoxResetStatusBar.Visible = pictureBoxResetStatusBar.Enabled = false;

			pictureBoxStart.Visible = pictureBoxStart.Enabled = !timerSystem.isPlaying;
			pictureBoxStop.Visible = pictureBoxStop.Enabled = timerSystem.isPlaying;
			pictureBoxAddSelected.Visible = pictureBoxAddSelected.Enabled = false;
		}

		private void ToNormalWindow()
		{
			windowMode = WindowMode.Normal;

			pictureBoxPlus.Visible = pictureBoxPlus.Enabled = false;
			pictureBoxMinus.Visible = pictureBoxMinus.Enabled = false;
			pictureBoxReset.Visible = pictureBoxReset.Enabled = false;
			pictureBoxResetStatusBar.Visible = pictureBoxResetStatusBar.Enabled = false;
		}

		private void ToInputAddTimeWindow()
		{
			windowMode = WindowMode.InputAddTime;
			keyInputBufferValue = "";
			addTimeIsPlus = true;
		}

		private void pictureBoxAdd_Click(object sender, EventArgs e)
		{
			if (windowMode == WindowMode.Normal)
			{
				ToInputAddTimeWindow();
			}
			else if (windowMode == WindowMode.InputAddTime)
			{
				string t = "00000000" + keyInputBufferValue;
				int DD = int.Parse(t[^8..^6]);
				int hh = int.Parse(t[^6..^4]);
				int mm = int.Parse(t[^4..^2]);
				int ss = int.Parse(t[^2..^0]);
				timerSystem.Add((TimeSpan.FromDays(DD) + TimeSpan.FromHours(hh) + TimeSpan.FromMinutes(mm) + TimeSpan.FromSeconds(ss)) * (addTimeIsPlus ? 1 : -1));

				ToNormalWindow();
			}
		}

		private void pictureBoxStart_Click(object sender, EventArgs e)
		{
			timerSystem.Start();
		}

		private void pictureBoxStop_Click(object sender, EventArgs e)
		{
			timerSystem.Stop();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (windowMode == WindowMode.Normal)
			{
				timerSystem.CheckHavingNoTime();
				var ts = timerSystem.GetViewTime();
				label_DD.Text = ts.Days.ToString("00");
				label_hh.Text = ts.Hours.ToString("00");
				label_mm.Text = ts.Minutes.ToString("00");
				label_ss.Text = ts.Seconds.ToString("00");
			}
			if (windowMode == WindowMode.InputAddTime)
			{
				pictureBoxAdd.Visible = pictureBoxAdd.Enabled = false;
				pictureBoxAddSelected.Visible = pictureBoxAddSelected.Enabled = true;

				string t = "00000000" + keyInputBufferValue;
				label_DD.Text = t[^8..^6];
				label_hh.Text = t[^6..^4];
				label_mm.Text = t[^4..^2];
				label_ss.Text = t[^2..^0];

				pictureBoxPlus.Visible = pictureBoxPlus.Enabled = addTimeIsPlus;
				pictureBoxMinus.Visible = pictureBoxMinus.Enabled = !addTimeIsPlus;

				// check reset
				reseter.Pressing(IsKeyPress(Keys.X));
				if (reseter.TimeIsReset())
				{
					timerSystem.Reset();
					ToNormalWindow();
				}
				if (reseter.IsWorking())
				{
					pictureBoxResetStatusBar.Size = new((int)(10 + (342 - 10) * reseter.StatusBarScale()), pictureBoxResetStatusBar.Size.Height);
				}
				pictureBoxReset.Visible = pictureBoxReset.Enabled = reseter.IsWorking();
				pictureBoxResetStatusBar.Visible = pictureBoxResetStatusBar.Enabled = reseter.IsWorking();
				pictureBoxResetStatusBar.BringToFront();
			}
			else
			{
				pictureBoxAdd.Visible = pictureBoxAdd.Enabled = true;
				pictureBoxAddSelected.Visible = pictureBoxAddSelected.Enabled = false;
			}

			pictureBoxStart.Visible = pictureBoxStart.Enabled = !timerSystem.isPlaying;
			pictureBoxStop.Visible = pictureBoxStop.Enabled = timerSystem.isPlaying;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (timerSystem.isPlaying)
			{
				timerSystem.Stop();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Add:
				case Keys.Oemplus:
					addTimeIsPlus = true;
					break;
				case Keys.Subtract:
				case Keys.OemMinus:
					addTimeIsPlus = false;
					break;
				case Keys.NumPad0:
				case Keys.D0:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength &&
						keyInputBufferValue != "")
						keyInputBufferValue += "0";
					break;
				case Keys.NumPad1:
				case Keys.D1:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "1";
					break;
				case Keys.NumPad2:
				case Keys.D2:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "2";
					break;
				case Keys.NumPad3:
				case Keys.D3:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "3";
					break;
				case Keys.NumPad4:
				case Keys.D4:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "4";
					break;
				case Keys.NumPad5:
				case Keys.D5:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "5";
					break;
				case Keys.NumPad6:
				case Keys.D6:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "6";
					break;
				case Keys.NumPad7:
				case Keys.D7:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "7";
					break;
				case Keys.NumPad8:
				case Keys.D8:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "8";
					break;
				case Keys.NumPad9:
				case Keys.D9:
					if (keyInputBufferValue.Length < keyInputBufferValueLimitedLength)
						keyInputBufferValue += "9";
					break;
				case Keys.Delete:
				case Keys.Back:
					if (keyInputBufferValue.Length > 0)
						keyInputBufferValue = keyInputBufferValue[..^1];
					break;
				case Keys.Enter:
					if (windowMode == WindowMode.InputAddTime)
						pictureBoxAdd_Click(new(), new());
					break;
				default:
					break;
			}

			timer1_Tick(new(), new());
		}
	}
}