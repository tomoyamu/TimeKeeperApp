using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeKeeperApp
{
	public class WindowSelectionChecker
	{
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public static bool IsWindowSelected(Form form)
		{
			IntPtr activeWindowHandle = GetForegroundWindow();

			return activeWindowHandle == form.Handle;
		}
	}
}