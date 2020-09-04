using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuillNotes
{
	public class Document
	{
		public List<string[]> Notes { get; set; }
		public Dictionary<string, bool> Settings { get; }

		public Document()
		{
			this.Notes = new List<string[]>();

			this.Settings = new Dictionary<string, bool>()
			{
				["Show Copyright Notice"] = true,
				["Confirm Note Deletion"] = true,
			};
		}

		
	}
}
