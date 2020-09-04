using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuillNotes
{
	static class Utilities
	{

		public static void GenerateDebugNotes(NotesWindow notesWindow, int amount)
		{
			for (int i=0;i<amount;i++)
			{
				string[] note = new string[2] {Convert.ToString(i), "This is note " + i };
				notesWindow.AddNote(note);
			}
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
