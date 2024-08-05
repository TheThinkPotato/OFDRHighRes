using System;
using System.Windows.Forms;

namespace OperationFlashPointVideoConfig
{
    public partial class ConfigForm : Form
    {
        private MainAppForm mainAppform;
        public ConfigForm(MainAppForm mainAppForm)
        {
            mainAppform = mainAppForm;
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = mainAppform.getNoneSteamVersionPath();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //open file dialog and save it to the textbox
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mainAppform.setNonSteamVersionPath(textBoxPath.Text);
        }
    }
}
