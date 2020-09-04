using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuillNotes
{
	static class FileUtilities
	{

		public static string CreateSaveDialog(string filterString)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = filterString;
			saveFileDialog.Title = "Save a QUILL File";
			saveFileDialog.ShowDialog();
			return saveFileDialog.FileName;
		}

		public static string CreateOpenDialog(string filterString)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = filterString;
			openFileDialog.Title = "Open a QUILL File";
			openFileDialog.ShowDialog();
			return openFileDialog.FileName;
		}

		public static void WriteToFile(string filePath, string stringToWrite, bool append = false)
		{
			TextWriter writer = null;
			if (filePath == "") return;
			try
			{
				writer = new StreamWriter(filePath, append);
				writer.Write(stringToWrite);
			}
			finally
			{
				if (writer != null)
					writer.Close();
			}
		}

		public static string ReadFromFile(string filePath)
		{
			TextReader reader = null;
			try
			{
				reader = new StreamReader(filePath);
				var fileContents = reader.ReadToEnd();
				return fileContents;
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}

	}
}
