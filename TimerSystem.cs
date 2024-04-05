using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperApp
{
	internal class TimerSystem
	{
		private Logger logger;
		private FileAccessService fileAccessService;
		private Stopwatch stopwatch;
		private double time;
		private bool _isPlaying;
		public bool isPlaying
		{
			get { return _isPlaying; }
		}
		public delegate void OnTimeOut();
		public OnTimeOut onTimeOut = delegate { };

		private void SaveTimeAsFile()
		{
			logger.Write($"Save Time as file: {time}");
			fileAccessService.Write(time.ToString(), false);
		}

		public TimerSystem(Logger logger)
		{
			this.logger = logger;
			this.fileAccessService = new("leftTime.dat");
			try
			{
				time = float.Parse(this.fileAccessService.ReadLines()[0]);
				logger.Write("Time has been loaded");
			}
			catch (Exception)
			{
				time = 0;
				logger.Write("Time has been reset");
				SaveTimeAsFile();
			}
			this.stopwatch = new();
		}

		public TimeSpan GetViewTime()
		{
			var ts = TimeSpan.FromSeconds(time) - stopwatch.Elapsed;
			if (ts.Days >= 100)
			{
				return TimeSpan.FromDays(99) + TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) + TimeSpan.FromSeconds(59);
			}
			return ts;
		}

		public void Start()
		{
			stopwatch.Reset();
			stopwatch.Start();
			_isPlaying = true;

			logger.Write("Start Timer");
		}

		public void Stop()
		{
			stopwatch.Stop();
			_isPlaying = false;
			time -= stopwatch.Elapsed.TotalSeconds;
			stopwatch.Reset();
			logger.Write("Stop Timer");
			SaveTimeAsFile();
		}

		public bool CheckHavingNoTime()
		{
			if (GetViewTime().TotalSeconds < 0)
			{
				stopwatch.Stop();
				_isPlaying = false;
				stopwatch.Reset();
				time = 0;
				logger.Write("Force to Stop Timer");
				SaveTimeAsFile();
				onTimeOut();
				return true;
			}

			return false;
		}

		public void Add(TimeSpan addTime)
		{
			logger.Write($"Add Time: {addTime.ToString()}");
			time += addTime.TotalSeconds;
			SaveTimeAsFile();
		}

		public void Reset()
		{
			stopwatch.Stop();
			_isPlaying = false;
			stopwatch.Reset();
			logger.Write($"Reset Time");
			time = 0;
			SaveTimeAsFile();
		}
	}
}
