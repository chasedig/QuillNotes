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
    public partial class NoteEditor : Form
    {
        public NoteEditor(string title, string contents)
        {
            InitializeComponent();
            titleBox.Text = title;
            editBox.Text = contents;
        }
    }
}
