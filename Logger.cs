using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperApp
{
	internal class Logger
	{
		private FileAccessService fileAccessService;

		public Logger()
		{
			fileAccessService = new("log.txt");

			Write("Logger init");
		}

		public void Write(string txt)
		{
			fileAccessService.Write(DateTime.Now.ToString("[yy/MM/dd/HH:mm:ss.ffffff] ") + txt, true);
		}
	}
}
