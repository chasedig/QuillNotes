using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace QuillNotes
{
	public partial class View : Form
	{

		public int index { get; set; }

		public View(string[] note, int index)
		{
			this.index = index;
			InitializeComponent();
			titleLabel.Text = note[0];
			var markdownResult = Markdown.ToHtml(note[1]);
			noteDisplay.DocumentText = markdownResult;
		}
	}
}
