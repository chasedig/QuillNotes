using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace QuillNotes
{
	static class Utilities
	{

		//public static ChromiumWebBrowser InitializeChromium()
		//{
			//CefSettings settings = new CefSettings();
		//}

		public static void GenerateDebugNotes(MainWindow mainWindow, int amount)
		{
			for (int i=0;i<amount;i++)
			{
				string[] note = new string[2] {Convert.ToString(i), "This is note " + i };
				mainWindow.AddNote(note);
			}
		}

		public static string GetCopyrightNotice() // Generate copyright notice for the current year
		{
			return "© " + (DateTime.Now).Year + ", Chase Carlson";
		}

		public static T CastObject<T>(object input)
		{
			return (T)input;
		}
		public static T ConvertObject<T>(object input)
		{
			return (T)Convert.ChangeType(input, typeof(T));
		}


	}
}
