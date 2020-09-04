using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuillNotes
{
	public partial class SettingsForm : Form
	{
		Dictionary<string, bool> settings;
		string[] settingsStrings;
		public SettingsForm(MainWindow window)
		{
			InitializeComponent();
			settings = window.document.Settings;
			settingsStrings = settings.Keys.ToArray();
			settings = window.document.Settings;
			//settingsListBox.Items = settingsStrings;
		}

		private void settingsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
