using System;
using System.Windows.Forms;
using SiebelReposAnalyser.Properties;

namespace SiebelReposAnalyser
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            PopulateSettings();
        }

        private void PopulateSettings()
        {
            radioButtonServerOM.Checked = Settings.Default.ConnectServerType;
            radioButtonClient.Checked = !Settings.Default.ConnectServerType;
            textBoxHost.Text = Settings.Default.ConnectHost;
            textBoxEnt.Text = Settings.Default.ConnectEnterprise;
            textBoxOM.Text = Settings.Default.ConnectOM;
            textBoxUser.Text = Settings.Default.ConnectUser;
            textBoxPass.Text = Settings.Default.ConnectPassword;
            checkBoxRemPass.Checked = Settings.Default.ConnectRemPassword;
            checkBoxPrePopUsers.Checked = Settings.Default.ConnectPrePropUsers;
            comboBoxRepName.Text = Settings.Default.ConnReposName;

            // Script Settings
            checkBoxScriptDestruction.Checked = Settings.Default.ScriptCheckDestruction;
            checkBoxScriptFinally.Checked = Settings.Default.ScriptCheckFinally;
            checkBoxForwardBack.Checked = Settings.Default.ScriptCheckForwardBackward;
            checkBoxScriptNoComm.Checked = Settings.Default.ScriptCheckNoComments;
            checkBoxScriptIgnoreInactive.Checked = Settings.Default.ScriptIgnoreInactive;

            // Config Settings
            checkBoxConfigForceActive.Checked = Settings.Default.ConfigCheckForceActive;
            checkBoxConfigIgnoreInactive.Checked = Settings.Default.ConfigIgnoreInactive;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Connection Settings
            Settings.Default.ConnectServerType = radioButtonServerOM.Checked;
            Settings.Default.ConnectEnterprise = textBoxEnt.Text;
            Settings.Default.ConnectHost = textBoxHost.Text;
            Settings.Default.ConnectOM = textBoxOM.Text;
            Settings.Default.ConnectUser = textBoxUser.Text;
            Settings.Default.ConnectPassword = textBoxPass.Text;
            Settings.Default.ConnectPrePropUsers = checkBoxPrePopUsers.Checked;
            Settings.Default.ConnectRemPassword = checkBoxRemPass.Checked;
            Settings.Default.ConnReposName = comboBoxRepName.Text;
            
            // Script Settings
            Settings.Default.ScriptCheckDestruction = checkBoxScriptDestruction.Checked;
            Settings.Default.ScriptCheckFinally = checkBoxScriptFinally.Checked;
            Settings.Default.ScriptCheckForwardBackward = checkBoxForwardBack.Checked;
            Settings.Default.ScriptCheckNoComments = checkBoxScriptNoComm.Checked;
            Settings.Default.ScriptIgnoreInactive = checkBoxScriptIgnoreInactive.Checked;
            // Config Settings
            Settings.Default.ConfigCheckForceActive = checkBoxConfigForceActive.Checked;
            Settings.Default.ConfigIgnoreInactive = checkBoxConfigIgnoreInactive.Checked;
            Settings.Default.Save();
        }
    }
}
