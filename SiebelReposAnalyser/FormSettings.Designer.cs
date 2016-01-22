namespace SiebelReposAnalyser
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.radioButtonServerOM = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.checkBoxPrePopUsers = new System.Windows.Forms.CheckBox();
            this.buttonGetCFG = new System.Windows.Forms.Button();
            this.labelDataSource = new System.Windows.Forms.Label();
            this.comboBoxDataSrc = new System.Windows.Forms.ComboBox();
            this.textBoxCFG = new System.Windows.Forms.TextBox();
            this.labelCFG = new System.Windows.Forms.Label();
            this.labelConType = new System.Windows.Forms.Label();
            this.comboBoxConType = new System.Windows.Forms.ComboBox();
            this.textBoxEnt = new System.Windows.Forms.TextBox();
            this.textBoxOM = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelEnterprise = new System.Windows.Forms.Label();
            this.labelOM = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.checkBoxRemPass = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.comboBoxRepName = new System.Windows.Forms.ComboBox();
            this.labelRepName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.groupBoxScriptChecks = new System.Windows.Forms.GroupBox();
            this.checkBoxScriptFinally = new System.Windows.Forms.CheckBox();
            this.checkBoxForwardBack = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptDestruction = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptNoComm = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptVars = new System.Windows.Forms.CheckBox();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.groupBoxConfigChecks = new System.Windows.Forms.GroupBox();
            this.checkBoxConfigForceActive = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigLinkSpec = new System.Windows.Forms.CheckBox();
            this.checkBoxSortIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxIndexSearch = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptIgnoreInactive = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigIgnoreInactive = new System.Windows.Forms.CheckBox();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageScript.SuspendLayout();
            this.groupBoxScriptChecks.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxConfigChecks.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConnect.Controls.Add(this.labelType);
            this.groupBoxConnect.Controls.Add(this.radioButtonServerOM);
            this.groupBoxConnect.Controls.Add(this.radioButtonClient);
            this.groupBoxConnect.Controls.Add(this.checkBoxPrePopUsers);
            this.groupBoxConnect.Controls.Add(this.buttonGetCFG);
            this.groupBoxConnect.Controls.Add(this.labelDataSource);
            this.groupBoxConnect.Controls.Add(this.comboBoxDataSrc);
            this.groupBoxConnect.Controls.Add(this.textBoxCFG);
            this.groupBoxConnect.Controls.Add(this.labelCFG);
            this.groupBoxConnect.Controls.Add(this.labelConType);
            this.groupBoxConnect.Controls.Add(this.comboBoxConType);
            this.groupBoxConnect.Controls.Add(this.textBoxEnt);
            this.groupBoxConnect.Controls.Add(this.textBoxOM);
            this.groupBoxConnect.Controls.Add(this.textBoxHost);
            this.groupBoxConnect.Controls.Add(this.labelEnterprise);
            this.groupBoxConnect.Controls.Add(this.labelOM);
            this.groupBoxConnect.Controls.Add(this.labelHost);
            this.groupBoxConnect.Controls.Add(this.checkBoxRemPass);
            this.groupBoxConnect.Controls.Add(this.textBoxPass);
            this.groupBoxConnect.Controls.Add(this.labelPass);
            this.groupBoxConnect.Controls.Add(this.textBoxUser);
            this.groupBoxConnect.Controls.Add(this.labelUser);
            this.groupBoxConnect.Location = new System.Drawing.Point(3, 6);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(429, 200);
            this.groupBoxConnect.TabIndex = 28;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connection";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(7, 25);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "Type:";
            // 
            // radioButtonServerOM
            // 
            this.radioButtonServerOM.AutoSize = true;
            this.radioButtonServerOM.Checked = true;
            this.radioButtonServerOM.Location = new System.Drawing.Point(85, 21);
            this.radioButtonServerOM.Name = "radioButtonServerOM";
            this.radioButtonServerOM.Size = new System.Drawing.Size(135, 17);
            this.radioButtonServerOM.TabIndex = 45;
            this.radioButtonServerOM.TabStop = true;
            this.radioButtonServerOM.Text = "Server Object Manager";
            this.radioButtonServerOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(226, 21);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(129, 17);
            this.radioButtonClient.TabIndex = 44;
            this.radioButtonClient.Text = "Dedicated Web Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrePopUsers
            // 
            this.checkBoxPrePopUsers.AutoSize = true;
            this.checkBoxPrePopUsers.Location = new System.Drawing.Point(184, 177);
            this.checkBoxPrePopUsers.Name = "checkBoxPrePopUsers";
            this.checkBoxPrePopUsers.Size = new System.Drawing.Size(169, 17);
            this.checkBoxPrePopUsers.TabIndex = 43;
            this.checkBoxPrePopUsers.Text = "Pre-Populate User Dropdowns";
            this.checkBoxPrePopUsers.UseVisualStyleBackColor = true;
            // 
            // buttonGetCFG
            // 
            this.buttonGetCFG.Location = new System.Drawing.Point(214, 359);
            this.buttonGetCFG.Name = "buttonGetCFG";
            this.buttonGetCFG.Size = new System.Drawing.Size(32, 23);
            this.buttonGetCFG.TabIndex = 41;
            this.buttonGetCFG.Text = "...";
            this.buttonGetCFG.UseVisualStyleBackColor = true;
            this.buttonGetCFG.Visible = false;
            // 
            // labelDataSource
            // 
            this.labelDataSource.AutoSize = true;
            this.labelDataSource.Location = new System.Drawing.Point(9, 394);
            this.labelDataSource.Name = "labelDataSource";
            this.labelDataSource.Size = new System.Drawing.Size(70, 13);
            this.labelDataSource.TabIndex = 40;
            this.labelDataSource.Text = "Data Source:";
            this.labelDataSource.Visible = false;
            // 
            // comboBoxDataSrc
            // 
            this.comboBoxDataSrc.FormattingEnabled = true;
            this.comboBoxDataSrc.Location = new System.Drawing.Point(85, 386);
            this.comboBoxDataSrc.Name = "comboBoxDataSrc";
            this.comboBoxDataSrc.Size = new System.Drawing.Size(161, 21);
            this.comboBoxDataSrc.TabIndex = 39;
            this.comboBoxDataSrc.Visible = false;
            // 
            // textBoxCFG
            // 
            this.textBoxCFG.Location = new System.Drawing.Point(85, 359);
            this.textBoxCFG.Name = "textBoxCFG";
            this.textBoxCFG.Size = new System.Drawing.Size(126, 20);
            this.textBoxCFG.TabIndex = 38;
            this.textBoxCFG.Visible = false;
            // 
            // labelCFG
            // 
            this.labelCFG.AutoSize = true;
            this.labelCFG.Location = new System.Drawing.Point(9, 363);
            this.labelCFG.Name = "labelCFG";
            this.labelCFG.Size = new System.Drawing.Size(50, 13);
            this.labelCFG.TabIndex = 37;
            this.labelCFG.Text = "CFG File:";
            this.labelCFG.Visible = false;
            // 
            // labelConType
            // 
            this.labelConType.AutoSize = true;
            this.labelConType.Location = new System.Drawing.Point(9, 335);
            this.labelConType.Name = "labelConType";
            this.labelConType.Size = new System.Drawing.Size(34, 13);
            this.labelConType.TabIndex = 36;
            this.labelConType.Text = "Type:";
            this.labelConType.Visible = false;
            // 
            // comboBoxConType
            // 
            this.comboBoxConType.FormattingEnabled = true;
            this.comboBoxConType.Items.AddRange(new object[] {
            "Server (SISNAPI)",
            "Local (Dedicated Client)"});
            this.comboBoxConType.Location = new System.Drawing.Point(85, 332);
            this.comboBoxConType.Name = "comboBoxConType";
            this.comboBoxConType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxConType.TabIndex = 35;
            this.comboBoxConType.Visible = false;
            // 
            // textBoxEnt
            // 
            this.textBoxEnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnt.Location = new System.Drawing.Point(83, 72);
            this.textBoxEnt.Name = "textBoxEnt";
            this.textBoxEnt.Size = new System.Drawing.Size(336, 20);
            this.textBoxEnt.TabIndex = 2;
            // 
            // textBoxOM
            // 
            this.textBoxOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOM.Location = new System.Drawing.Point(83, 98);
            this.textBoxOM.Name = "textBoxOM";
            this.textBoxOM.Size = new System.Drawing.Size(336, 20);
            this.textBoxOM.TabIndex = 3;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHost.Location = new System.Drawing.Point(83, 46);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(336, 20);
            this.textBoxHost.TabIndex = 1;
            // 
            // labelEnterprise
            // 
            this.labelEnterprise.AutoSize = true;
            this.labelEnterprise.Location = new System.Drawing.Point(7, 75);
            this.labelEnterprise.Name = "labelEnterprise";
            this.labelEnterprise.Size = new System.Drawing.Size(57, 13);
            this.labelEnterprise.TabIndex = 34;
            this.labelEnterprise.Text = "Enterprise:";
            // 
            // labelOM
            // 
            this.labelOM.AutoSize = true;
            this.labelOM.Location = new System.Drawing.Point(8, 103);
            this.labelOM.Name = "labelOM";
            this.labelOM.Size = new System.Drawing.Size(27, 13);
            this.labelOM.TabIndex = 33;
            this.labelOM.Text = "OM:";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(7, 49);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 13);
            this.labelHost.TabIndex = 32;
            this.labelHost.Text = "Host:";
            // 
            // checkBoxRemPass
            // 
            this.checkBoxRemPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRemPass.AutoSize = true;
            this.checkBoxRemPass.Location = new System.Drawing.Point(83, 177);
            this.checkBoxRemPass.Name = "checkBoxRemPass";
            this.checkBoxRemPass.Size = new System.Drawing.Size(77, 17);
            this.checkBoxRemPass.TabIndex = 6;
            this.checkBoxRemPass.Text = "Remember";
            this.checkBoxRemPass.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.Location = new System.Drawing.Point(83, 151);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(336, 20);
            this.textBoxPass.TabIndex = 5;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(8, 156);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(56, 13);
            this.labelPass.TabIndex = 31;
            this.labelPass.Text = "Password:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.Location = new System.Drawing.Point(83, 124);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(336, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(8, 129);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 13);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Admin User:";
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMisc.Controls.Add(this.comboBoxRepName);
            this.groupBoxMisc.Controls.Add(this.labelRepName);
            this.groupBoxMisc.Location = new System.Drawing.Point(6, 217);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(426, 72);
            this.groupBoxMisc.TabIndex = 34;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // comboBoxRepName
            // 
            this.comboBoxRepName.FormattingEnabled = true;
            this.comboBoxRepName.Items.AddRange(new object[] {
            "Siebel Repository"});
            this.comboBoxRepName.Location = new System.Drawing.Point(85, 23);
            this.comboBoxRepName.Name = "comboBoxRepName";
            this.comboBoxRepName.Size = new System.Drawing.Size(197, 21);
            this.comboBoxRepName.TabIndex = 9;
            this.comboBoxRepName.Text = "Siebel Repository";
            // 
            // labelRepName
            // 
            this.labelRepName.AutoSize = true;
            this.labelRepName.Location = new System.Drawing.Point(10, 26);
            this.labelRepName.Name = "labelRepName";
            this.labelRepName.Size = new System.Drawing.Size(60, 13);
            this.labelRepName.TabIndex = 25;
            this.labelRepName.Text = "Repository:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(380, 339);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(252, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 23);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Save and Close";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSettings.Controls.Add(this.tabPageConnection);
            this.tabControlSettings.Controls.Add(this.tabPageScript);
            this.tabControlSettings.Controls.Add(this.tabPageConfig);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(443, 324);
            this.tabControlSettings.TabIndex = 37;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.groupBoxConnect);
            this.tabPageConnection.Controls.Add(this.groupBoxMisc);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(435, 298);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.groupBoxScriptChecks);
            this.tabPageScript.Location = new System.Drawing.Point(4, 22);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScript.Size = new System.Drawing.Size(435, 298);
            this.tabPageScript.TabIndex = 1;
            this.tabPageScript.Text = "eScript";
            this.tabPageScript.UseVisualStyleBackColor = true;
            // 
            // groupBoxScriptChecks
            // 
            this.groupBoxScriptChecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxScriptIgnoreInactive);
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxScriptFinally);
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxForwardBack);
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxScriptDestruction);
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxScriptNoComm);
            this.groupBoxScriptChecks.Controls.Add(this.checkBoxScriptVars);
            this.groupBoxScriptChecks.Location = new System.Drawing.Point(3, 6);
            this.groupBoxScriptChecks.Name = "groupBoxScriptChecks";
            this.groupBoxScriptChecks.Size = new System.Drawing.Size(426, 286);
            this.groupBoxScriptChecks.TabIndex = 14;
            this.groupBoxScriptChecks.TabStop = false;
            this.groupBoxScriptChecks.Text = "eScript Checks";
            // 
            // checkBoxScriptFinally
            // 
            this.checkBoxScriptFinally.AutoSize = true;
            this.checkBoxScriptFinally.Checked = true;
            this.checkBoxScriptFinally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptFinally.Location = new System.Drawing.Point(6, 22);
            this.checkBoxScriptFinally.Name = "checkBoxScriptFinally";
            this.checkBoxScriptFinally.Size = new System.Drawing.Size(86, 17);
            this.checkBoxScriptFinally.TabIndex = 9;
            this.checkBoxScriptFinally.Text = "Ret in Finally";
            this.checkBoxScriptFinally.UseVisualStyleBackColor = true;
            // 
            // checkBoxForwardBack
            // 
            this.checkBoxForwardBack.AutoSize = true;
            this.checkBoxForwardBack.Checked = true;
            this.checkBoxForwardBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxForwardBack.Location = new System.Drawing.Point(6, 68);
            this.checkBoxForwardBack.Name = "checkBoxForwardBack";
            this.checkBoxForwardBack.Size = new System.Drawing.Size(112, 17);
            this.checkBoxForwardBack.TabIndex = 13;
            this.checkBoxForwardBack.Text = "ForwardBackward";
            this.checkBoxForwardBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptDestruction
            // 
            this.checkBoxScriptDestruction.AutoSize = true;
            this.checkBoxScriptDestruction.Checked = true;
            this.checkBoxScriptDestruction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptDestruction.Location = new System.Drawing.Point(6, 45);
            this.checkBoxScriptDestruction.Name = "checkBoxScriptDestruction";
            this.checkBoxScriptDestruction.Size = new System.Drawing.Size(80, 17);
            this.checkBoxScriptDestruction.TabIndex = 10;
            this.checkBoxScriptDestruction.Text = "Destruction";
            this.checkBoxScriptDestruction.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptNoComm
            // 
            this.checkBoxScriptNoComm.AutoSize = true;
            this.checkBoxScriptNoComm.Checked = true;
            this.checkBoxScriptNoComm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptNoComm.Location = new System.Drawing.Point(6, 91);
            this.checkBoxScriptNoComm.Name = "checkBoxScriptNoComm";
            this.checkBoxScriptNoComm.Size = new System.Drawing.Size(92, 17);
            this.checkBoxScriptNoComm.TabIndex = 12;
            this.checkBoxScriptNoComm.Text = "No Comments";
            this.checkBoxScriptNoComm.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptVars
            // 
            this.checkBoxScriptVars.AutoSize = true;
            this.checkBoxScriptVars.Enabled = false;
            this.checkBoxScriptVars.Location = new System.Drawing.Point(6, 114);
            this.checkBoxScriptVars.Name = "checkBoxScriptVars";
            this.checkBoxScriptVars.Size = new System.Drawing.Size(87, 17);
            this.checkBoxScriptVars.TabIndex = 11;
            this.checkBoxScriptVars.Text = "Unused Vars";
            this.checkBoxScriptVars.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.groupBoxConfigChecks);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(435, 298);
            this.tabPageConfig.TabIndex = 2;
            this.tabPageConfig.Text = "Configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // groupBoxConfigChecks
            // 
            this.groupBoxConfigChecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfigChecks.Controls.Add(this.checkBoxConfigIgnoreInactive);
            this.groupBoxConfigChecks.Controls.Add(this.checkBoxConfigForceActive);
            this.groupBoxConfigChecks.Controls.Add(this.checkBoxConfigLinkSpec);
            this.groupBoxConfigChecks.Controls.Add(this.checkBoxSortIndex);
            this.groupBoxConfigChecks.Controls.Add(this.checkBoxIndexSearch);
            this.groupBoxConfigChecks.Location = new System.Drawing.Point(3, 6);
            this.groupBoxConfigChecks.Name = "groupBoxConfigChecks";
            this.groupBoxConfigChecks.Size = new System.Drawing.Size(426, 286);
            this.groupBoxConfigChecks.TabIndex = 0;
            this.groupBoxConfigChecks.TabStop = false;
            this.groupBoxConfigChecks.Text = "Config Checks";
            // 
            // checkBoxConfigForceActive
            // 
            this.checkBoxConfigForceActive.AutoSize = true;
            this.checkBoxConfigForceActive.Checked = true;
            this.checkBoxConfigForceActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConfigForceActive.Location = new System.Drawing.Point(6, 22);
            this.checkBoxConfigForceActive.Name = "checkBoxConfigForceActive";
            this.checkBoxConfigForceActive.Size = new System.Drawing.Size(86, 17);
            this.checkBoxConfigForceActive.TabIndex = 21;
            this.checkBoxConfigForceActive.Text = "Force Active";
            this.checkBoxConfigForceActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigLinkSpec
            // 
            this.checkBoxConfigLinkSpec.AutoSize = true;
            this.checkBoxConfigLinkSpec.Location = new System.Drawing.Point(6, 45);
            this.checkBoxConfigLinkSpec.Name = "checkBoxConfigLinkSpec";
            this.checkBoxConfigLinkSpec.Size = new System.Drawing.Size(74, 17);
            this.checkBoxConfigLinkSpec.TabIndex = 22;
            this.checkBoxConfigLinkSpec.Text = "Link Spec";
            this.checkBoxConfigLinkSpec.UseVisualStyleBackColor = true;
            this.checkBoxConfigLinkSpec.Visible = false;
            // 
            // checkBoxSortIndex
            // 
            this.checkBoxSortIndex.AutoSize = true;
            this.checkBoxSortIndex.Location = new System.Drawing.Point(6, 68);
            this.checkBoxSortIndex.Name = "checkBoxSortIndex";
            this.checkBoxSortIndex.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSortIndex.TabIndex = 24;
            this.checkBoxSortIndex.Text = "Sort Index";
            this.checkBoxSortIndex.UseVisualStyleBackColor = true;
            this.checkBoxSortIndex.Visible = false;
            // 
            // checkBoxIndexSearch
            // 
            this.checkBoxIndexSearch.AutoSize = true;
            this.checkBoxIndexSearch.Location = new System.Drawing.Point(6, 91);
            this.checkBoxIndexSearch.Name = "checkBoxIndexSearch";
            this.checkBoxIndexSearch.Size = new System.Drawing.Size(89, 17);
            this.checkBoxIndexSearch.TabIndex = 23;
            this.checkBoxIndexSearch.Text = "Search Index";
            this.checkBoxIndexSearch.UseVisualStyleBackColor = true;
            this.checkBoxIndexSearch.Visible = false;
            // 
            // checkBoxScriptIgnoreInactive
            // 
            this.checkBoxScriptIgnoreInactive.AutoSize = true;
            this.checkBoxScriptIgnoreInactive.Checked = true;
            this.checkBoxScriptIgnoreInactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptIgnoreInactive.Location = new System.Drawing.Point(209, 22);
            this.checkBoxScriptIgnoreInactive.Name = "checkBoxScriptIgnoreInactive";
            this.checkBoxScriptIgnoreInactive.Size = new System.Drawing.Size(97, 17);
            this.checkBoxScriptIgnoreInactive.TabIndex = 14;
            this.checkBoxScriptIgnoreInactive.Text = "Ignore Inactive";
            this.checkBoxScriptIgnoreInactive.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigIgnoreInactive
            // 
            this.checkBoxConfigIgnoreInactive.AutoSize = true;
            this.checkBoxConfigIgnoreInactive.Checked = true;
            this.checkBoxConfigIgnoreInactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConfigIgnoreInactive.Location = new System.Drawing.Point(209, 22);
            this.checkBoxConfigIgnoreInactive.Name = "checkBoxConfigIgnoreInactive";
            this.checkBoxConfigIgnoreInactive.Size = new System.Drawing.Size(97, 17);
            this.checkBoxConfigIgnoreInactive.TabIndex = 25;
            this.checkBoxConfigIgnoreInactive.Text = "Ignore Inactive";
            this.checkBoxConfigIgnoreInactive.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 372);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageScript.ResumeLayout(false);
            this.groupBoxScriptChecks.ResumeLayout(false);
            this.groupBoxScriptChecks.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.groupBoxConfigChecks.ResumeLayout(false);
            this.groupBoxConfigChecks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.RadioButton radioButtonServerOM;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.CheckBox checkBoxPrePopUsers;
        private System.Windows.Forms.Button buttonGetCFG;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.ComboBox comboBoxDataSrc;
        private System.Windows.Forms.TextBox textBoxCFG;
        private System.Windows.Forms.Label labelCFG;
        private System.Windows.Forms.Label labelConType;
        private System.Windows.Forms.ComboBox comboBoxConType;
        private System.Windows.Forms.TextBox textBoxEnt;
        private System.Windows.Forms.TextBox textBoxOM;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelEnterprise;
        private System.Windows.Forms.Label labelOM;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.CheckBox checkBoxRemPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.ComboBox comboBoxRepName;
        private System.Windows.Forms.Label labelRepName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPageScript;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.GroupBox groupBoxScriptChecks;
        private System.Windows.Forms.CheckBox checkBoxScriptFinally;
        private System.Windows.Forms.CheckBox checkBoxForwardBack;
        private System.Windows.Forms.CheckBox checkBoxScriptDestruction;
        private System.Windows.Forms.CheckBox checkBoxScriptNoComm;
        private System.Windows.Forms.CheckBox checkBoxScriptVars;
        private System.Windows.Forms.GroupBox groupBoxConfigChecks;
        private System.Windows.Forms.CheckBox checkBoxConfigForceActive;
        private System.Windows.Forms.CheckBox checkBoxConfigLinkSpec;
        private System.Windows.Forms.CheckBox checkBoxSortIndex;
        private System.Windows.Forms.CheckBox checkBoxIndexSearch;
        private System.Windows.Forms.CheckBox checkBoxScriptIgnoreInactive;
        private System.Windows.Forms.CheckBox checkBoxConfigIgnoreInactive;
    }
}