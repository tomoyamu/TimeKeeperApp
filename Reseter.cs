using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperApp
{
	internal class Reseter
	{
		private Stopwatch keyPressTimer = new();
		public double resetTime = 3;
		
		public void Pressing(bool pressing)
		{
			if (pressing && !keyPressTimer.IsRunning)
			{
				keyPressTimer.Restart();
			}
			if (!pressing)
			{
				keyPressTimer.Stop();
				keyPressTimer.Reset();
			}
		}

		public bool TimeIsReset()
		{
			if (keyPressTimer.Elapsed.TotalSeconds >= resetTime)
			{
				keyPressTimer.Stop();
				keyPressTimer.Reset();
				return true;
			}
			return false;
		}

		public double StatusBarScale()
		{
			return double.Min(1, keyPressTimer.Elapsed.TotalSeconds / resetTime);
		}

		public bool IsWorking()
		{
			return keyPressTimer.IsRunning;
		}
	}
}
