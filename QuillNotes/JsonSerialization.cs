using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuillNotes
{
	class JsonSerialization
	{
		public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
		{
			TextWriter writer = null;
			try
			{
				var contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(objectToWrite);
				writer = new StreamWriter(filePath, append);
				writer.Write(contentsToWriteToFile);
			}
			finally
			{
				if (writer != null)
					writer.Close();
			}
		}

		public static T ReadFromJsonFile<T>(string filePath) where T : new()
		{
			TextReader reader = null;
			try
			{
				reader = new StreamReader(filePath);
				var fileContents = reader.ReadToEnd();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(fileContents);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}
	}
}
