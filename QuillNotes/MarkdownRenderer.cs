using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using Markdig;

namespace QuillNotes
{
	public partial class MarkdownRendererForm : Form
	{
		public MarkdownRendererForm(string markdownString)
		{
			InitializeComponent();
			Console.WriteLine(markdownString);
			MarkdownRenderer.DocumentText = Markdown.ToHtml(markdownString);
		}
	}
}
