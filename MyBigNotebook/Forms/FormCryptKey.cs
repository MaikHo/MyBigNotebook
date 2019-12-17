using System;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormCryptKey : Form
    {
        public FormCryptKey(string oldKey)
        {
            InitializeComponent();
            textBoxKey.Text = oldKey;
            textBoxKey.Focus();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.DialogResult = DialogResult.OK;
        }
    }
}
