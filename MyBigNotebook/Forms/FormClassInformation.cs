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
    public partial class FormClassInformation : Form
    {
        private ClassInformation classInformation;
        public FormClassInformation(ClassInformation information)
        {
            InitializeComponent();
            classInformation = information;
            
            
        }
    }
}
