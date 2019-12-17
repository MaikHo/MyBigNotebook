using System;
using System.Windows.Forms;
using System.Configuration;

namespace MyBigNotebook.Forms
{
    public partial class FormSetting : Form
    {
        private bool First { get; set; }
        public FormSetting()
        {
            InitializeComponent();
            textBoxGoogleUser.Text = ConfigurationManager.AppSettings.Get("GoogleUser");
            checkBoxAutoSave.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AutoSave"));
            numericUpDownsaveTime.Value = Convert.ToInt32(ConfigurationManager.AppSettings.Get("TimeAutoSave"));
            First = false;
        }

        public FormSetting(bool first)
        {
            InitializeComponent();
            textBoxGoogleUser.Text = ConfigurationManager.AppSettings.Get("GoogleUser");
            checkBoxAutoSave.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AutoSave"));
            numericUpDownsaveTime.Value = Convert.ToInt32(ConfigurationManager.AppSettings.Get("TimeAutoSave"));
            if (first) buttonClose.Visible = false;
            First = first;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["CountStart"].Value = (Convert.ToInt32(configuration.AppSettings.Settings["CountStart"].Value)+1).ToString();
            configuration.AppSettings.Settings["GoogleUser"].Value = textBoxGoogleUser.Text;
            configuration.AppSettings.Settings["AutoSave"].Value = checkBoxAutoSave.Checked.ToString();
            configuration.AppSettings.Settings["TimeAutoSave"].Value = numericUpDownsaveTime.Value.ToString() ;
            configuration.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void FormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (First) buttonSave_Click(sender, new EventArgs());
        }
    }
}
