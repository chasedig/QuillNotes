using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuillNotes
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string fileName = "";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (args != null && args.Length > 0)
			{
				fileName = args[0];
				if (File.Exists(fileName))
				{
					MainWindow mainWindow = new MainWindow();
					mainWindow.OpenFile(fileName);
					Application.Run(mainWindow);
				}
			}
			else
			{
				MainWindow mainWindow = new MainWindow();
				Application.Run(mainWindow);
			}

			
		}
	}
}
