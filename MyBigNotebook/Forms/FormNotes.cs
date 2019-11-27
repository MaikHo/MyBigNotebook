using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormNotes : Form
    {
        private ClassNotes Notes;
        public FormNotes(ClassNotes notes)
        {
            InitializeComponent();
            Notes = notes;
        }
    }
}
