using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperApp
{
	internal class FileAccessService
	{
		private string filePath;

		private void PrepareFile()
		{
			if (!File.Exists(filePath))
			{
				File.Create(filePath);
			}
		}

		public void Write(string text, bool append)
		{
			PrepareFile();
			Encoding utfEnc = Encoding.UTF8;
			using (StreamWriter writer = new StreamWriter(filePath, append, utfEnc))
			{
				writer.WriteLine(text);
			}
		}

		public string[] ReadLines()
		{
			if (!File.Exists(filePath)) return Array.Empty<string>();
			return File.ReadAllLines(filePath);
		}

		public FileAccessService(string filePath)
		{
			this.filePath = filePath;
			PrepareFile();
		}
	}
}
