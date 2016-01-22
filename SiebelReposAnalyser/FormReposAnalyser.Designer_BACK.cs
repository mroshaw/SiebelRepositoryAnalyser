namespace SiebelReposAnalyser
{
    partial class FormReposAnalyser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Results");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReposAnalyser));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonScript = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.comboBoxRepName = new System.Windows.Forms.ComboBox();
            this.labelRepName = new System.Windows.Forms.Label();
            this.labelDonate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.comboBoxConfigCreatedByFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxConfigUpdatedByFilter = new System.Windows.Forms.ComboBox();
            this.dateTimeConfigCreatedFilter = new System.Windows.Forms.DateTimePicker();
            this.dateTimeConfigUpdatedFilter = new System.Windows.Forms.DateTimePicker();
            this.labelConfigCreatedFilter = new System.Windows.Forms.Label();
            this.labelConfigCreatedByFilter = new System.Windows.Forms.Label();
            this.labelConfigUpdatedFilter = new System.Windows.Forms.Label();
            this.labelConfigUpdatedByFilter = new System.Windows.Forms.Label();
            this.textBoxConfigNameFilter = new System.Windows.Forms.TextBox();
            this.labelConfigNameFilter = new System.Windows.Forms.Label();
            this.groupBoxScript = new System.Windows.Forms.GroupBox();
            this.comboBoxScriptCreatedByFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxScriptUpdatedByFilter = new System.Windows.Forms.ComboBox();
            this.dateTimeScriptCreatedFilter = new System.Windows.Forms.DateTimePicker();
            this.dateTimeScriptUpdatedFilter = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScriptUpdatedByFilter = new System.Windows.Forms.Label();
            this.textBoxScriptNameFilter = new System.Windows.Forms.TextBox();
            this.labelScriptNameFilter = new System.Windows.Forms.Label();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.tabConfigFunctions = new System.Windows.Forms.TabControl();
            this.tabChangeLog = new System.Windows.Forms.TabPage();
            this.buttonConfigExportCSV = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonExportChangeLogXML = new System.Windows.Forms.Button();
            this.textBoxUpdated = new System.Windows.Forms.TextBox();
            this.textBoxUpdatedBy = new System.Windows.Forms.TextBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxCreatedBy = new System.Windows.Forms.TextBox();
            this.labelUpdated = new System.Windows.Forms.Label();
            this.labelUpdatedBy = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.treeViewAllChanges = new System.Windows.Forms.TreeView();
            this.buttonShowChanges = new System.Windows.Forms.Button();
            this.dateTimeChanges = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageConfigProbs = new System.Windows.Forms.TabPage();
            this.buttonConfigExportProbCSV = new System.Windows.Forms.Button();
            this.buttonExportConfigProblemsXML = new System.Windows.Forms.Button();
            this.checkBoxConfigLinkSpec = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigForceActive = new System.Windows.Forms.CheckBox();
            this.buttonConfigFind = new System.Windows.Forms.Button();
            this.dataGridViewConfigProbs = new System.Windows.Forms.DataGridView();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelScript = new System.Windows.Forms.Panel();
            this.tabScriptFunctions = new System.Windows.Forms.TabControl();
            this.tabCount = new System.Windows.Forms.TabPage();
            this.textBoxCustLines = new System.Windows.Forms.TextBox();
            this.textBoxVanLines = new System.Windows.Forms.TextBox();
            this.labelCustomLines = new System.Windows.Forms.Label();
            this.labelVanLines = new System.Windows.Forms.Label();
            this.labelTotalLines = new System.Windows.Forms.Label();
            this.labelVanillaLines = new System.Windows.Forms.Label();
            this.comboBoxVer = new System.Windows.Forms.ComboBox();
            this.labelRefVer = new System.Windows.Forms.Label();
            this.textTotalLines = new System.Windows.Forms.TextBox();
            this.dataGridViewCodeLines = new System.Windows.Forms.DataGridView();
            this.buttonCodeLines = new System.Windows.Forms.Button();
            this.tabPageScriptSearch = new System.Windows.Forms.TabPage();
            this.treeViewSearchResults = new System.Windows.Forms.TreeView();
            this.buttonScriptSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tabPageProbFinder = new System.Windows.Forms.TabPage();
            this.buttonScriptExportProbCSV = new System.Windows.Forms.Button();
            this.buttonExportScriptProblemsXML = new System.Windows.Forms.Button();
            this.checkBoxScriptIgnoreVan = new System.Windows.Forms.CheckBox();
            this.checkBoxForwardBack = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptNoComm = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptVars = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptDestruction = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptFinally = new System.Windows.Forms.CheckBox();
            this.buttonFindScriptProbs = new System.Windows.Forms.Button();
            this.dataGridViewScriptProbs = new System.Windows.Forms.DataGridView();
            this.ColumnScriptType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelHome = new System.Windows.Forms.Panel();
            this.webBrowserNews = new System.Windows.Forms.WebBrowser();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxExScript = new Ionic.WinForms.RichTextBoxEx();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxAutoConnect = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelConnect.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxScript.SuspendLayout();
            this.groupBoxConnect.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.tabConfigFunctions.SuspendLayout();
            this.tabChangeLog.SuspendLayout();
            this.tabPageConfigProbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigProbs)).BeginInit();
            this.panelScript.SuspendLayout();
            this.tabScriptFunctions.SuspendLayout();
            this.tabCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodeLines)).BeginInit();
            this.tabPageScriptSearch.SuspendLayout();
            this.tabPageProbFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScriptProbs)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelConnStatus,
            this.toolStripSplitButtonConnect});
            this.statusStrip.Location = new System.Drawing.Point(0, 519);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(755, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripStatusLabelConnStatus
            // 
            this.toolStripStatusLabelConnStatus.Name = "toolStripStatusLabelConnStatus";
            this.toolStripStatusLabelConnStatus.Size = new System.Drawing.Size(669, 17);
            this.toolStripStatusLabelConnStatus.Spring = true;
            this.toolStripStatusLabelConnStatus.Text = "(Not Connected)";
            this.toolStripStatusLabelConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSplitButtonConnect
            // 
            this.toolStripSplitButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.toolStripSplitButtonConnect.Image = global::SiebelReposAnalyser.Properties.Resources.Disconnected;
            this.toolStripSplitButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonConnect.Name = "toolStripSplitButtonConnect";
            this.toolStripSplitButtonConnect.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButtonConnect.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonConnect.Click += new System.EventHandler(this.toolStripSplitButtonConnect_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.Disconnected;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.Connected;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.buttonHome);
            this.panelControl.Controls.Add(this.buttonExit);
            this.panelControl.Controls.Add(this.buttonScript);
            this.panelControl.Controls.Add(this.buttonConfig);
            this.panelControl.Controls.Add(this.buttonConnect);
            this.panelControl.Location = new System.Drawing.Point(6, 27);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(109, 485);
            this.panelControl.TabIndex = 10;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Image = global::SiebelReposAnalyser.Properties.Resources.Home;
            this.buttonHome.Location = new System.Drawing.Point(17, 25);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 77);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::SiebelReposAnalyser.Properties.Resources.Repos_Manager;
            this.buttonExit.Location = new System.Drawing.Point(17, 387);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 77);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Close";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonScript
            // 
            this.buttonScript.Image = global::SiebelReposAnalyser.Properties.Resources.Degree;
            this.buttonScript.Location = new System.Drawing.Point(17, 296);
            this.buttonScript.Name = "buttonScript";
            this.buttonScript.Size = new System.Drawing.Size(75, 77);
            this.buttonScript.TabIndex = 2;
            this.buttonScript.Text = "Script";
            this.buttonScript.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonScript.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonScript.UseVisualStyleBackColor = true;
            this.buttonScript.Click += new System.EventHandler(this.buttonScript_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Image = global::SiebelReposAnalyser.Properties.Resources.News_View;
            this.buttonConfig.Location = new System.Drawing.Point(17, 207);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 77);
            this.buttonConfig.TabIndex = 1;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonConnect.Image = global::SiebelReposAnalyser.Properties.Resources.Settings;
            this.buttonConnect.Location = new System.Drawing.Point(17, 116);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 77);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Settings";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelConnect
            // 
            this.panelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConnect.Controls.Add(this.groupBoxMisc);
            this.panelConnect.Controls.Add(this.groupBoxConfig);
            this.panelConnect.Controls.Add(this.groupBoxScript);
            this.panelConnect.Controls.Add(this.groupBoxConnect);
            this.panelConnect.Location = new System.Drawing.Point(122, 27);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(621, 485);
            this.panelConnect.TabIndex = 11;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMisc.Controls.Add(this.comboBoxRepName);
            this.groupBoxMisc.Controls.Add(this.labelRepName);
            this.groupBoxMisc.Controls.Add(this.labelDonate);
            this.groupBoxMisc.Controls.Add(this.button1);
            this.groupBoxMisc.Location = new System.Drawing.Point(7, 246);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(276, 225);
            this.groupBoxMisc.TabIndex = 26;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // comboBoxRepName
            // 
            this.comboBoxRepName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRepName.FormattingEnabled = true;
            this.comboBoxRepName.Items.AddRange(new object[] {
            "Siebel Repository"});
            this.comboBoxRepName.Location = new System.Drawing.Point(85, 23);
            this.comboBoxRepName.Name = "comboBoxRepName";
            this.comboBoxRepName.Size = new System.Drawing.Size(176, 21);
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
            // labelDonate
            // 
            this.labelDonate.AutoSize = true;
            this.labelDonate.Location = new System.Drawing.Point(10, 192);
            this.labelDonate.Name = "labelDonate";
            this.labelDonate.Size = new System.Drawing.Size(98, 13);
            this.labelDonate.TabIndex = 24;
            this.labelDonate.Text = "Donate via PayPal:";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SiebelReposAnalyser.Properties.Resources.Donate;
            this.button1.Location = new System.Drawing.Point(162, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfig.Controls.Add(this.comboBoxConfigCreatedByFilter);
            this.groupBoxConfig.Controls.Add(this.comboBoxConfigUpdatedByFilter);
            this.groupBoxConfig.Controls.Add(this.dateTimeConfigCreatedFilter);
            this.groupBoxConfig.Controls.Add(this.dateTimeConfigUpdatedFilter);
            this.groupBoxConfig.Controls.Add(this.labelConfigCreatedFilter);
            this.groupBoxConfig.Controls.Add(this.labelConfigCreatedByFilter);
            this.groupBoxConfig.Controls.Add(this.labelConfigUpdatedFilter);
            this.groupBoxConfig.Controls.Add(this.labelConfigUpdatedByFilter);
            this.groupBoxConfig.Controls.Add(this.textBoxConfigNameFilter);
            this.groupBoxConfig.Controls.Add(this.labelConfigNameFilter);
            this.groupBoxConfig.Location = new System.Drawing.Point(289, 246);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(317, 225);
            this.groupBoxConfig.TabIndex = 25;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Config";
            // 
            // comboBoxConfigCreatedByFilter
            // 
            this.comboBoxConfigCreatedByFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConfigCreatedByFilter.FormattingEnabled = true;
            this.comboBoxConfigCreatedByFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxConfigCreatedByFilter.Location = new System.Drawing.Point(105, 102);
            this.comboBoxConfigCreatedByFilter.Name = "comboBoxConfigCreatedByFilter";
            this.comboBoxConfigCreatedByFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxConfigCreatedByFilter.TabIndex = 18;
            this.comboBoxConfigCreatedByFilter.Text = "All";
            this.comboBoxConfigCreatedByFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptCreatedByFilter_TextChanged);
            this.comboBoxConfigCreatedByFilter.Leave += new System.EventHandler(this.comboBoxScriptCreatedByFilter_TextChanged);
            // 
            // comboBoxConfigUpdatedByFilter
            // 
            this.comboBoxConfigUpdatedByFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConfigUpdatedByFilter.FormattingEnabled = true;
            this.comboBoxConfigUpdatedByFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxConfigUpdatedByFilter.Location = new System.Drawing.Point(105, 48);
            this.comboBoxConfigUpdatedByFilter.Name = "comboBoxConfigUpdatedByFilter";
            this.comboBoxConfigUpdatedByFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxConfigUpdatedByFilter.TabIndex = 16;
            this.comboBoxConfigUpdatedByFilter.Text = "All";
            this.comboBoxConfigUpdatedByFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigUpdatedByFilter_TextChanged);
            this.comboBoxConfigUpdatedByFilter.Leave += new System.EventHandler(this.comboBoxConfigUpdatedByFilter_TextChanged);
            // 
            // dateTimeConfigCreatedFilter
            // 
            this.dateTimeConfigCreatedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeConfigCreatedFilter.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeConfigCreatedFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeConfigCreatedFilter.Location = new System.Drawing.Point(105, 129);
            this.dateTimeConfigCreatedFilter.Name = "dateTimeConfigCreatedFilter";
            this.dateTimeConfigCreatedFilter.Size = new System.Drawing.Size(202, 20);
            this.dateTimeConfigCreatedFilter.TabIndex = 19;
            this.dateTimeConfigCreatedFilter.Value = new System.DateTime(2012, 3, 28, 18, 0, 0, 0);
            this.dateTimeConfigCreatedFilter.Leave += new System.EventHandler(this.dateTimeConfigCreatedFilter_ValueChanged);
            // 
            // dateTimeConfigUpdatedFilter
            // 
            this.dateTimeConfigUpdatedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeConfigUpdatedFilter.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeConfigUpdatedFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeConfigUpdatedFilter.Location = new System.Drawing.Point(105, 75);
            this.dateTimeConfigUpdatedFilter.Name = "dateTimeConfigUpdatedFilter";
            this.dateTimeConfigUpdatedFilter.Size = new System.Drawing.Size(202, 20);
            this.dateTimeConfigUpdatedFilter.TabIndex = 17;
            this.dateTimeConfigUpdatedFilter.Value = new System.DateTime(2012, 3, 28, 18, 0, 0, 0);
            this.dateTimeConfigUpdatedFilter.Leave += new System.EventHandler(this.dateTimeConfigUpdatedFilter_ValueChanged);
            // 
            // labelConfigCreatedFilter
            // 
            this.labelConfigCreatedFilter.AutoSize = true;
            this.labelConfigCreatedFilter.Location = new System.Drawing.Point(6, 132);
            this.labelConfigCreatedFilter.Name = "labelConfigCreatedFilter";
            this.labelConfigCreatedFilter.Size = new System.Drawing.Size(72, 13);
            this.labelConfigCreatedFilter.TabIndex = 10;
            this.labelConfigCreatedFilter.Text = "Created Filter:";
            // 
            // labelConfigCreatedByFilter
            // 
            this.labelConfigCreatedByFilter.AutoSize = true;
            this.labelConfigCreatedByFilter.Location = new System.Drawing.Point(7, 106);
            this.labelConfigCreatedByFilter.Name = "labelConfigCreatedByFilter";
            this.labelConfigCreatedByFilter.Size = new System.Drawing.Size(87, 13);
            this.labelConfigCreatedByFilter.TabIndex = 8;
            this.labelConfigCreatedByFilter.Text = "Created By Filter:";
            // 
            // labelConfigUpdatedFilter
            // 
            this.labelConfigUpdatedFilter.AutoSize = true;
            this.labelConfigUpdatedFilter.Location = new System.Drawing.Point(6, 78);
            this.labelConfigUpdatedFilter.Name = "labelConfigUpdatedFilter";
            this.labelConfigUpdatedFilter.Size = new System.Drawing.Size(76, 13);
            this.labelConfigUpdatedFilter.TabIndex = 6;
            this.labelConfigUpdatedFilter.Text = "Updated Filter:";
            // 
            // labelConfigUpdatedByFilter
            // 
            this.labelConfigUpdatedByFilter.AutoSize = true;
            this.labelConfigUpdatedByFilter.Location = new System.Drawing.Point(7, 52);
            this.labelConfigUpdatedByFilter.Name = "labelConfigUpdatedByFilter";
            this.labelConfigUpdatedByFilter.Size = new System.Drawing.Size(91, 13);
            this.labelConfigUpdatedByFilter.TabIndex = 4;
            this.labelConfigUpdatedByFilter.Text = "Updated By Filter:";
            // 
            // textBoxConfigNameFilter
            // 
            this.textBoxConfigNameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfigNameFilter.Location = new System.Drawing.Point(103, 23);
            this.textBoxConfigNameFilter.Name = "textBoxConfigNameFilter";
            this.textBoxConfigNameFilter.Size = new System.Drawing.Size(206, 20);
            this.textBoxConfigNameFilter.TabIndex = 15;
            this.textBoxConfigNameFilter.Leave += new System.EventHandler(this.textBoxConfigNameFilter_TextChanged);
            // 
            // labelConfigNameFilter
            // 
            this.labelConfigNameFilter.AutoSize = true;
            this.labelConfigNameFilter.Location = new System.Drawing.Point(7, 26);
            this.labelConfigNameFilter.Name = "labelConfigNameFilter";
            this.labelConfigNameFilter.Size = new System.Drawing.Size(63, 13);
            this.labelConfigNameFilter.TabIndex = 2;
            this.labelConfigNameFilter.Text = "Name Filter:";
            // 
            // groupBoxScript
            // 
            this.groupBoxScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxScript.Controls.Add(this.comboBoxScriptCreatedByFilter);
            this.groupBoxScript.Controls.Add(this.comboBoxScriptUpdatedByFilter);
            this.groupBoxScript.Controls.Add(this.dateTimeScriptCreatedFilter);
            this.groupBoxScript.Controls.Add(this.dateTimeScriptUpdatedFilter);
            this.groupBoxScript.Controls.Add(this.label2);
            this.groupBoxScript.Controls.Add(this.label6);
            this.groupBoxScript.Controls.Add(this.label3);
            this.groupBoxScript.Controls.Add(this.labelScriptUpdatedByFilter);
            this.groupBoxScript.Controls.Add(this.textBoxScriptNameFilter);
            this.groupBoxScript.Controls.Add(this.labelScriptNameFilter);
            this.groupBoxScript.Location = new System.Drawing.Point(289, 10);
            this.groupBoxScript.Name = "groupBoxScript";
            this.groupBoxScript.Size = new System.Drawing.Size(317, 230);
            this.groupBoxScript.TabIndex = 24;
            this.groupBoxScript.TabStop = false;
            this.groupBoxScript.Text = "Script";
            // 
            // comboBoxScriptCreatedByFilter
            // 
            this.comboBoxScriptCreatedByFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxScriptCreatedByFilter.FormattingEnabled = true;
            this.comboBoxScriptCreatedByFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxScriptCreatedByFilter.Location = new System.Drawing.Point(105, 103);
            this.comboBoxScriptCreatedByFilter.Name = "comboBoxScriptCreatedByFilter";
            this.comboBoxScriptCreatedByFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxScriptCreatedByFilter.TabIndex = 13;
            this.comboBoxScriptCreatedByFilter.Text = "All";
            this.comboBoxScriptCreatedByFilter.Leave += new System.EventHandler(this.comboBoxScriptCreatedByFilter_TextUpdate);
            // 
            // comboBoxScriptUpdatedByFilter
            // 
            this.comboBoxScriptUpdatedByFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxScriptUpdatedByFilter.FormattingEnabled = true;
            this.comboBoxScriptUpdatedByFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxScriptUpdatedByFilter.Location = new System.Drawing.Point(105, 50);
            this.comboBoxScriptUpdatedByFilter.Name = "comboBoxScriptUpdatedByFilter";
            this.comboBoxScriptUpdatedByFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxScriptUpdatedByFilter.TabIndex = 11;
            this.comboBoxScriptUpdatedByFilter.Text = "All";
            this.comboBoxScriptUpdatedByFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptUpdatedByFilter_TextChanged);
            this.comboBoxScriptUpdatedByFilter.Leave += new System.EventHandler(this.comboBoxScriptUpdatedByFilter_TextChanged);
            // 
            // dateTimeScriptCreatedFilter
            // 
            this.dateTimeScriptCreatedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeScriptCreatedFilter.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeScriptCreatedFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeScriptCreatedFilter.Location = new System.Drawing.Point(105, 130);
            this.dateTimeScriptCreatedFilter.Name = "dateTimeScriptCreatedFilter";
            this.dateTimeScriptCreatedFilter.Size = new System.Drawing.Size(204, 20);
            this.dateTimeScriptCreatedFilter.TabIndex = 14;
            this.dateTimeScriptCreatedFilter.Value = new System.DateTime(2012, 3, 28, 18, 0, 0, 0);
            this.dateTimeScriptCreatedFilter.Leave += new System.EventHandler(this.dateTimeScriptCreatedFilter_ValueChanged);
            // 
            // dateTimeScriptUpdatedFilter
            // 
            this.dateTimeScriptUpdatedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeScriptUpdatedFilter.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeScriptUpdatedFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeScriptUpdatedFilter.Location = new System.Drawing.Point(105, 78);
            this.dateTimeScriptUpdatedFilter.Name = "dateTimeScriptUpdatedFilter";
            this.dateTimeScriptUpdatedFilter.Size = new System.Drawing.Size(204, 20);
            this.dateTimeScriptUpdatedFilter.TabIndex = 12;
            this.dateTimeScriptUpdatedFilter.Value = new System.DateTime(2012, 3, 28, 18, 0, 0, 0);
            this.dateTimeScriptUpdatedFilter.Leave += new System.EventHandler(this.dateTimeScriptUpdatedFilter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Created Filter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Created By Filter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Updated Filter:";
            // 
            // labelScriptUpdatedByFilter
            // 
            this.labelScriptUpdatedByFilter.AutoSize = true;
            this.labelScriptUpdatedByFilter.Location = new System.Drawing.Point(6, 54);
            this.labelScriptUpdatedByFilter.Name = "labelScriptUpdatedByFilter";
            this.labelScriptUpdatedByFilter.Size = new System.Drawing.Size(91, 13);
            this.labelScriptUpdatedByFilter.TabIndex = 2;
            this.labelScriptUpdatedByFilter.Text = "Updated By Filter:";
            // 
            // textBoxScriptNameFilter
            // 
            this.textBoxScriptNameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScriptNameFilter.Location = new System.Drawing.Point(105, 24);
            this.textBoxScriptNameFilter.Name = "textBoxScriptNameFilter";
            this.textBoxScriptNameFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxScriptNameFilter.TabIndex = 10;
            this.textBoxScriptNameFilter.Leave += new System.EventHandler(this.textBoxScriptNameFilter_TextChanged);
            // 
            // labelScriptNameFilter
            // 
            this.labelScriptNameFilter.AutoSize = true;
            this.labelScriptNameFilter.Location = new System.Drawing.Point(6, 32);
            this.labelScriptNameFilter.Name = "labelScriptNameFilter";
            this.labelScriptNameFilter.Size = new System.Drawing.Size(63, 13);
            this.labelScriptNameFilter.TabIndex = 0;
            this.labelScriptNameFilter.Text = "Name Filter:";
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.checkBoxAutoConnect);
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
            this.groupBoxConnect.Controls.Add(this.buttonLogout);
            this.groupBoxConnect.Controls.Add(this.buttonLogin);
            this.groupBoxConnect.Controls.Add(this.textPass);
            this.groupBoxConnect.Controls.Add(this.labelPass);
            this.groupBoxConnect.Controls.Add(this.textUser);
            this.groupBoxConnect.Controls.Add(this.labelUser);
            this.groupBoxConnect.Location = new System.Drawing.Point(7, 10);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(273, 230);
            this.groupBoxConnect.TabIndex = 23;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connection";
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
            this.buttonGetCFG.Click += new System.EventHandler(this.buttonGetCFG_Click);
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
            this.comboBoxDataSrc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataSrc_SelectedIndexChanged);
            // 
            // textBoxCFG
            // 
            this.textBoxCFG.Location = new System.Drawing.Point(85, 359);
            this.textBoxCFG.Name = "textBoxCFG";
            this.textBoxCFG.Size = new System.Drawing.Size(126, 20);
            this.textBoxCFG.TabIndex = 38;
            this.textBoxCFG.TextChanged += new System.EventHandler(this.textBoxCFG_TextChanged);
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
            this.comboBoxConType.SelectedIndexChanged += new System.EventHandler(this.comboBoxConType_SelectedIndexChanged);
            // 
            // textBoxEnt
            // 
            this.textBoxEnt.Location = new System.Drawing.Point(85, 49);
            this.textBoxEnt.Name = "textBoxEnt";
            this.textBoxEnt.Size = new System.Drawing.Size(176, 20);
            this.textBoxEnt.TabIndex = 2;
            this.textBoxEnt.Text = "SBA_82";
            this.textBoxEnt.Leave += new System.EventHandler(this.textBoxEnt_TextChanged);
            // 
            // textBoxOM
            // 
            this.textBoxOM.Location = new System.Drawing.Point(85, 75);
            this.textBoxOM.Name = "textBoxOM";
            this.textBoxOM.Size = new System.Drawing.Size(176, 20);
            this.textBoxOM.TabIndex = 3;
            this.textBoxOM.Text = "PSCcObjMgr_ENU";
            this.textBoxOM.Leave += new System.EventHandler(this.textBoxOM_TextChanged);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(85, 23);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(176, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.Text = "SIEB822-VM";
            this.textBoxHost.Leave += new System.EventHandler(this.textBoxHost_TextChanged);
            // 
            // labelEnterprise
            // 
            this.labelEnterprise.AutoSize = true;
            this.labelEnterprise.Location = new System.Drawing.Point(9, 52);
            this.labelEnterprise.Name = "labelEnterprise";
            this.labelEnterprise.Size = new System.Drawing.Size(57, 13);
            this.labelEnterprise.TabIndex = 34;
            this.labelEnterprise.Text = "Enterprise:";
            // 
            // labelOM
            // 
            this.labelOM.AutoSize = true;
            this.labelOM.Location = new System.Drawing.Point(10, 80);
            this.labelOM.Name = "labelOM";
            this.labelOM.Size = new System.Drawing.Size(27, 13);
            this.labelOM.TabIndex = 33;
            this.labelOM.Text = "OM:";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(9, 26);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 13);
            this.labelHost.TabIndex = 32;
            this.labelHost.Text = "Host:";
            // 
            // checkBoxRemPass
            // 
            this.checkBoxRemPass.AutoSize = true;
            this.checkBoxRemPass.Location = new System.Drawing.Point(184, 154);
            this.checkBoxRemPass.Name = "checkBoxRemPass";
            this.checkBoxRemPass.Size = new System.Drawing.Size(77, 17);
            this.checkBoxRemPass.TabIndex = 6;
            this.checkBoxRemPass.Text = "Remember";
            this.checkBoxRemPass.UseVisualStyleBackColor = true;
            this.checkBoxRemPass.CheckedChanged += new System.EventHandler(this.checkBoxRemPass_CheckedChanged);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(192, 194);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(111, 194);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(85, 128);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(176, 20);
            this.textPass.TabIndex = 5;
            this.textPass.Text = "Password0";
            this.textPass.Leave += new System.EventHandler(this.textPass_TextChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(10, 133);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(56, 13);
            this.labelPass.TabIndex = 31;
            this.labelPass.Text = "Password:";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(85, 101);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(176, 20);
            this.textUser.TabIndex = 4;
            this.textUser.Text = "sadmin";
            this.textUser.Leave += new System.EventHandler(this.textUser_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(10, 106);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 13);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Admin User:";
            // 
            // panelConfig
            // 
            this.panelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfig.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfig.Controls.Add(this.tabConfigFunctions);
            this.panelConfig.Location = new System.Drawing.Point(122, 27);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(621, 485);
            this.panelConfig.TabIndex = 18;
            this.panelConfig.Visible = false;
            // 
            // tabConfigFunctions
            // 
            this.tabConfigFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConfigFunctions.Controls.Add(this.tabChangeLog);
            this.tabConfigFunctions.Controls.Add(this.tabPageConfigProbs);
            this.tabConfigFunctions.Location = new System.Drawing.Point(3, 3);
            this.tabConfigFunctions.Name = "tabConfigFunctions";
            this.tabConfigFunctions.SelectedIndex = 0;
            this.tabConfigFunctions.Size = new System.Drawing.Size(613, 478);
            this.tabConfigFunctions.TabIndex = 8;
            // 
            // tabChangeLog
            // 
            this.tabChangeLog.Controls.Add(this.buttonConfigExportCSV);
            this.tabChangeLog.Controls.Add(this.comboBoxUser);
            this.tabChangeLog.Controls.Add(this.labelLogin);
            this.tabChangeLog.Controls.Add(this.buttonExportChangeLogXML);
            this.tabChangeLog.Controls.Add(this.textBoxUpdated);
            this.tabChangeLog.Controls.Add(this.textBoxUpdatedBy);
            this.tabChangeLog.Controls.Add(this.textBoxCreated);
            this.tabChangeLog.Controls.Add(this.textBoxCreatedBy);
            this.tabChangeLog.Controls.Add(this.labelUpdated);
            this.tabChangeLog.Controls.Add(this.labelUpdatedBy);
            this.tabChangeLog.Controls.Add(this.labelCreated);
            this.tabChangeLog.Controls.Add(this.labelCreatedBy);
            this.tabChangeLog.Controls.Add(this.treeViewAllChanges);
            this.tabChangeLog.Controls.Add(this.buttonShowChanges);
            this.tabChangeLog.Controls.Add(this.dateTimeChanges);
            this.tabChangeLog.Controls.Add(this.label1);
            this.tabChangeLog.Location = new System.Drawing.Point(4, 22);
            this.tabChangeLog.Name = "tabChangeLog";
            this.tabChangeLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeLog.Size = new System.Drawing.Size(605, 452);
            this.tabChangeLog.TabIndex = 1;
            this.tabChangeLog.Text = "Change Log";
            this.tabChangeLog.UseVisualStyleBackColor = true;
            // 
            // buttonConfigExportCSV
            // 
            this.buttonConfigExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigExportCSV.Enabled = false;
            this.buttonConfigExportCSV.Location = new System.Drawing.Point(435, 408);
            this.buttonConfigExportCSV.Name = "buttonConfigExportCSV";
            this.buttonConfigExportCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigExportCSV.TabIndex = 17;
            this.buttonConfigExportCSV.Text = "Export CSV";
            this.buttonConfigExportCSV.UseVisualStyleBackColor = true;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "All"});
            this.comboBoxUser.Location = new System.Drawing.Point(322, 7);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(188, 21);
            this.comboBoxUser.TabIndex = 16;
            this.comboBoxUser.Text = "All";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.Leave += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(279, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login:";
            // 
            // buttonExportChangeLogXML
            // 
            this.buttonExportChangeLogXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportChangeLogXML.Location = new System.Drawing.Point(518, 408);
            this.buttonExportChangeLogXML.Name = "buttonExportChangeLogXML";
            this.buttonExportChangeLogXML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportChangeLogXML.TabIndex = 14;
            this.buttonExportChangeLogXML.Text = "Export XML";
            this.buttonExportChangeLogXML.UseVisualStyleBackColor = true;
            this.buttonExportChangeLogXML.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxUpdated
            // 
            this.textBoxUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUpdated.Location = new System.Drawing.Point(267, 426);
            this.textBoxUpdated.Name = "textBoxUpdated";
            this.textBoxUpdated.ReadOnly = true;
            this.textBoxUpdated.Size = new System.Drawing.Size(114, 20);
            this.textBoxUpdated.TabIndex = 11;
            // 
            // textBoxUpdatedBy
            // 
            this.textBoxUpdatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUpdatedBy.Location = new System.Drawing.Point(267, 400);
            this.textBoxUpdatedBy.Name = "textBoxUpdatedBy";
            this.textBoxUpdatedBy.ReadOnly = true;
            this.textBoxUpdatedBy.Size = new System.Drawing.Size(114, 20);
            this.textBoxUpdatedBy.TabIndex = 10;
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCreated.Location = new System.Drawing.Point(75, 426);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(114, 20);
            this.textBoxCreated.TabIndex = 9;
            // 
            // textBoxCreatedBy
            // 
            this.textBoxCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCreatedBy.Location = new System.Drawing.Point(75, 400);
            this.textBoxCreatedBy.Name = "textBoxCreatedBy";
            this.textBoxCreatedBy.ReadOnly = true;
            this.textBoxCreatedBy.Size = new System.Drawing.Size(114, 20);
            this.textBoxCreatedBy.TabIndex = 8;
            // 
            // labelUpdated
            // 
            this.labelUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpdated.AutoSize = true;
            this.labelUpdated.Location = new System.Drawing.Point(195, 429);
            this.labelUpdated.Name = "labelUpdated";
            this.labelUpdated.Size = new System.Drawing.Size(51, 13);
            this.labelUpdated.TabIndex = 7;
            this.labelUpdated.Text = "Updated:";
            // 
            // labelUpdatedBy
            // 
            this.labelUpdatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpdatedBy.AutoSize = true;
            this.labelUpdatedBy.Location = new System.Drawing.Point(195, 403);
            this.labelUpdatedBy.Name = "labelUpdatedBy";
            this.labelUpdatedBy.Size = new System.Drawing.Size(66, 13);
            this.labelUpdatedBy.TabIndex = 6;
            this.labelUpdatedBy.Text = "Updated By:";
            // 
            // labelCreated
            // 
            this.labelCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(7, 429);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(47, 13);
            this.labelCreated.TabIndex = 5;
            this.labelCreated.Text = "Created:";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Location = new System.Drawing.Point(7, 403);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(62, 13);
            this.labelCreatedBy.TabIndex = 4;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // treeViewAllChanges
            // 
            this.treeViewAllChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAllChanges.Location = new System.Drawing.Point(10, 33);
            this.treeViewAllChanges.Name = "treeViewAllChanges";
            this.treeViewAllChanges.Size = new System.Drawing.Size(581, 361);
            this.treeViewAllChanges.TabIndex = 3;
            this.treeViewAllChanges.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAllChanges_AfterSelect);
            // 
            // buttonShowChanges
            // 
            this.buttonShowChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowChanges.Enabled = false;
            this.buttonShowChanges.Location = new System.Drawing.Point(516, 6);
            this.buttonShowChanges.Name = "buttonShowChanges";
            this.buttonShowChanges.Size = new System.Drawing.Size(75, 23);
            this.buttonShowChanges.TabIndex = 2;
            this.buttonShowChanges.Text = "Show Changes";
            this.buttonShowChanges.UseVisualStyleBackColor = true;
            this.buttonShowChanges.Click += new System.EventHandler(this.buttonShowChanges_Click);
            // 
            // dateTimeChanges
            // 
            this.dateTimeChanges.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeChanges.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeChanges.Location = new System.Drawing.Point(96, 7);
            this.dateTimeChanges.Name = "dateTimeChanges";
            this.dateTimeChanges.Size = new System.Drawing.Size(177, 20);
            this.dateTimeChanges.TabIndex = 1;
            this.dateTimeChanges.Value = new System.DateTime(2012, 3, 28, 18, 0, 0, 0);
            this.dateTimeChanges.Leave += new System.EventHandler(this.dateTimeChanges_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changes Since:";
            // 
            // tabPageConfigProbs
            // 
            this.tabPageConfigProbs.Controls.Add(this.buttonConfigExportProbCSV);
            this.tabPageConfigProbs.Controls.Add(this.buttonExportConfigProblemsXML);
            this.tabPageConfigProbs.Controls.Add(this.checkBoxConfigLinkSpec);
            this.tabPageConfigProbs.Controls.Add(this.checkBoxConfigForceActive);
            this.tabPageConfigProbs.Controls.Add(this.buttonConfigFind);
            this.tabPageConfigProbs.Controls.Add(this.dataGridViewConfigProbs);
            this.tabPageConfigProbs.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigProbs.Name = "tabPageConfigProbs";
            this.tabPageConfigProbs.Size = new System.Drawing.Size(605, 452);
            this.tabPageConfigProbs.TabIndex = 2;
            this.tabPageConfigProbs.Text = "Problems";
            this.tabPageConfigProbs.UseVisualStyleBackColor = true;
            // 
            // buttonConfigExportProbCSV
            // 
            this.buttonConfigExportProbCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigExportProbCSV.Location = new System.Drawing.Point(437, 417);
            this.buttonConfigExportProbCSV.Name = "buttonConfigExportProbCSV";
            this.buttonConfigExportProbCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigExportProbCSV.TabIndex = 18;
            this.buttonConfigExportProbCSV.Text = "Export CSV";
            this.buttonConfigExportProbCSV.UseVisualStyleBackColor = true;
            this.buttonConfigExportProbCSV.Click += new System.EventHandler(this.buttonConfigExportProbCSV_Click);
            // 
            // buttonExportConfigProblemsXML
            // 
            this.buttonExportConfigProblemsXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportConfigProblemsXML.Location = new System.Drawing.Point(518, 416);
            this.buttonExportConfigProblemsXML.Name = "buttonExportConfigProblemsXML";
            this.buttonExportConfigProblemsXML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportConfigProblemsXML.TabIndex = 15;
            this.buttonExportConfigProblemsXML.Text = "Export XML";
            this.buttonExportConfigProblemsXML.UseVisualStyleBackColor = true;
            this.buttonExportConfigProblemsXML.Click += new System.EventHandler(this.buttonExportConfigProblemsXML_Click);
            // 
            // checkBoxConfigLinkSpec
            // 
            this.checkBoxConfigLinkSpec.AutoSize = true;
            this.checkBoxConfigLinkSpec.Location = new System.Drawing.Point(11, 38);
            this.checkBoxConfigLinkSpec.Name = "checkBoxConfigLinkSpec";
            this.checkBoxConfigLinkSpec.Size = new System.Drawing.Size(74, 17);
            this.checkBoxConfigLinkSpec.TabIndex = 3;
            this.checkBoxConfigLinkSpec.Text = "Link Spec";
            this.checkBoxConfigLinkSpec.UseVisualStyleBackColor = true;
            this.checkBoxConfigLinkSpec.CheckedChanged += new System.EventHandler(this.checkBoxConfigLinkSpec_CheckedChanged);
            // 
            // checkBoxConfigForceActive
            // 
            this.checkBoxConfigForceActive.AutoSize = true;
            this.checkBoxConfigForceActive.Location = new System.Drawing.Point(11, 15);
            this.checkBoxConfigForceActive.Name = "checkBoxConfigForceActive";
            this.checkBoxConfigForceActive.Size = new System.Drawing.Size(86, 17);
            this.checkBoxConfigForceActive.TabIndex = 2;
            this.checkBoxConfigForceActive.Text = "Force Active";
            this.checkBoxConfigForceActive.UseVisualStyleBackColor = true;
            this.checkBoxConfigForceActive.CheckedChanged += new System.EventHandler(this.checkBoxConfigForceActive_CheckedChanged);
            // 
            // buttonConfigFind
            // 
            this.buttonConfigFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigFind.Location = new System.Drawing.Point(516, 6);
            this.buttonConfigFind.Name = "buttonConfigFind";
            this.buttonConfigFind.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigFind.TabIndex = 1;
            this.buttonConfigFind.Text = "Find!";
            this.buttonConfigFind.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConfigProbs
            // 
            this.dataGridViewConfigProbs.AllowUserToAddRows = false;
            this.dataGridViewConfigProbs.AllowUserToDeleteRows = false;
            this.dataGridViewConfigProbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConfigProbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigProbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnObject,
            this.ColumnProperty,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewConfigProbs.Location = new System.Drawing.Point(6, 64);
            this.dataGridViewConfigProbs.Name = "dataGridViewConfigProbs";
            this.dataGridViewConfigProbs.Size = new System.Drawing.Size(585, 347);
            this.dataGridViewConfigProbs.TabIndex = 0;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            // 
            // ColumnObject
            // 
            this.ColumnObject.HeaderText = "Object";
            this.ColumnObject.Name = "ColumnObject";
            // 
            // ColumnProperty
            // 
            this.ColumnProperty.HeaderText = "Property";
            this.ColumnProperty.Name = "ColumnProperty";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Problem";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 242;
            // 
            // panelScript
            // 
            this.panelScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScript.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScript.Controls.Add(this.tabScriptFunctions);
            this.panelScript.Location = new System.Drawing.Point(122, 27);
            this.panelScript.Name = "panelScript";
            this.panelScript.Size = new System.Drawing.Size(621, 485);
            this.panelScript.TabIndex = 8;
            // 
            // tabScriptFunctions
            // 
            this.tabScriptFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabScriptFunctions.Controls.Add(this.tabCount);
            this.tabScriptFunctions.Controls.Add(this.tabPageScriptSearch);
            this.tabScriptFunctions.Controls.Add(this.tabPageProbFinder);
            this.tabScriptFunctions.Location = new System.Drawing.Point(3, 3);
            this.tabScriptFunctions.Name = "tabScriptFunctions";
            this.tabScriptFunctions.SelectedIndex = 0;
            this.tabScriptFunctions.Size = new System.Drawing.Size(613, 478);
            this.tabScriptFunctions.TabIndex = 8;
            // 
            // tabCount
            // 
            this.tabCount.Controls.Add(this.textBoxCustLines);
            this.tabCount.Controls.Add(this.textBoxVanLines);
            this.tabCount.Controls.Add(this.labelCustomLines);
            this.tabCount.Controls.Add(this.labelVanLines);
            this.tabCount.Controls.Add(this.labelTotalLines);
            this.tabCount.Controls.Add(this.labelVanillaLines);
            this.tabCount.Controls.Add(this.comboBoxVer);
            this.tabCount.Controls.Add(this.labelRefVer);
            this.tabCount.Controls.Add(this.textTotalLines);
            this.tabCount.Controls.Add(this.dataGridViewCodeLines);
            this.tabCount.Controls.Add(this.buttonCodeLines);
            this.tabCount.Location = new System.Drawing.Point(4, 22);
            this.tabCount.Name = "tabCount";
            this.tabCount.Padding = new System.Windows.Forms.Padding(3);
            this.tabCount.Size = new System.Drawing.Size(605, 452);
            this.tabCount.TabIndex = 0;
            this.tabCount.Text = "Line Count";
            this.tabCount.UseVisualStyleBackColor = true;
            // 
            // textBoxCustLines
            // 
            this.textBoxCustLines.Location = new System.Drawing.Point(85, 234);
            this.textBoxCustLines.Name = "textBoxCustLines";
            this.textBoxCustLines.ReadOnly = true;
            this.textBoxCustLines.Size = new System.Drawing.Size(128, 20);
            this.textBoxCustLines.TabIndex = 12;
            // 
            // textBoxVanLines
            // 
            this.textBoxVanLines.Location = new System.Drawing.Point(85, 208);
            this.textBoxVanLines.Name = "textBoxVanLines";
            this.textBoxVanLines.ReadOnly = true;
            this.textBoxVanLines.Size = new System.Drawing.Size(128, 20);
            this.textBoxVanLines.TabIndex = 11;
            // 
            // labelCustomLines
            // 
            this.labelCustomLines.AutoSize = true;
            this.labelCustomLines.Location = new System.Drawing.Point(10, 237);
            this.labelCustomLines.Name = "labelCustomLines";
            this.labelCustomLines.Size = new System.Drawing.Size(72, 13);
            this.labelCustomLines.TabIndex = 10;
            this.labelCustomLines.Text = "Total Custom:";
            // 
            // labelVanLines
            // 
            this.labelVanLines.AutoSize = true;
            this.labelVanLines.Location = new System.Drawing.Point(10, 211);
            this.labelVanLines.Name = "labelVanLines";
            this.labelVanLines.Size = new System.Drawing.Size(68, 13);
            this.labelVanLines.TabIndex = 9;
            this.labelVanLines.Text = "Total Vanilla:";
            // 
            // labelTotalLines
            // 
            this.labelTotalLines.AutoSize = true;
            this.labelTotalLines.Location = new System.Drawing.Point(9, 187);
            this.labelTotalLines.Name = "labelTotalLines";
            this.labelTotalLines.Size = new System.Drawing.Size(62, 13);
            this.labelTotalLines.TabIndex = 8;
            this.labelTotalLines.Text = "Total Lines:";
            // 
            // labelVanillaLines
            // 
            this.labelVanillaLines.AutoSize = true;
            this.labelVanillaLines.Location = new System.Drawing.Point(219, 13);
            this.labelVanillaLines.Name = "labelVanillaLines";
            this.labelVanillaLines.Size = new System.Drawing.Size(221, 13);
            this.labelVanillaLines.TabIndex = 7;
            this.labelVanillaLines.Text = "Number of vanilla lines will appear in brackets";
            // 
            // comboBoxVer
            // 
            this.comboBoxVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVer.FormattingEnabled = true;
            this.comboBoxVer.Items.AddRange(new object[] {
            "(Show All)",
            "7.8 SIA",
            "8.1 SIA",
            "8.2 SIA"});
            this.comboBoxVer.Location = new System.Drawing.Point(62, 7);
            this.comboBoxVer.Name = "comboBoxVer";
            this.comboBoxVer.Size = new System.Drawing.Size(151, 21);
            this.comboBoxVer.TabIndex = 6;
            // 
            // labelRefVer
            // 
            this.labelRefVer.AutoSize = true;
            this.labelRefVer.Location = new System.Drawing.Point(10, 7);
            this.labelRefVer.Name = "labelRefVer";
            this.labelRefVer.Size = new System.Drawing.Size(45, 13);
            this.labelRefVer.TabIndex = 5;
            this.labelRefVer.Text = "Version:";
            // 
            // textTotalLines
            // 
            this.textTotalLines.Location = new System.Drawing.Point(85, 182);
            this.textTotalLines.Name = "textTotalLines";
            this.textTotalLines.ReadOnly = true;
            this.textTotalLines.Size = new System.Drawing.Size(128, 20);
            this.textTotalLines.TabIndex = 4;
            // 
            // dataGridViewCodeLines
            // 
            this.dataGridViewCodeLines.AllowUserToAddRows = false;
            this.dataGridViewCodeLines.AllowUserToDeleteRows = false;
            this.dataGridViewCodeLines.AllowUserToResizeColumns = false;
            this.dataGridViewCodeLines.AllowUserToResizeRows = false;
            this.dataGridViewCodeLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCodeLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCodeLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.columnTotal,
            this.ColumnCustom});
            this.dataGridViewCodeLines.Location = new System.Drawing.Point(9, 33);
            this.dataGridViewCodeLines.Name = "dataGridViewCodeLines";
            this.dataGridViewCodeLines.Size = new System.Drawing.Size(593, 135);
            this.dataGridViewCodeLines.TabIndex = 3;
            // 
            // buttonCodeLines
            // 
            this.buttonCodeLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCodeLines.Enabled = false;
            this.buttonCodeLines.Location = new System.Drawing.Point(497, 182);
            this.buttonCodeLines.Name = "buttonCodeLines";
            this.buttonCodeLines.Size = new System.Drawing.Size(102, 23);
            this.buttonCodeLines.TabIndex = 0;
            this.buttonCodeLines.Text = "Get Code Lines";
            this.buttonCodeLines.UseVisualStyleBackColor = true;
            this.buttonCodeLines.Click += new System.EventHandler(this.buttonCodeLines_Click);
            // 
            // tabPageScriptSearch
            // 
            this.tabPageScriptSearch.Controls.Add(this.richTextBoxExScript);
            this.tabPageScriptSearch.Controls.Add(this.treeViewSearchResults);
            this.tabPageScriptSearch.Controls.Add(this.buttonScriptSearch);
            this.tabPageScriptSearch.Controls.Add(this.textBoxSearch);
            this.tabPageScriptSearch.Controls.Add(this.labelSearch);
            this.tabPageScriptSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageScriptSearch.Name = "tabPageScriptSearch";
            this.tabPageScriptSearch.Size = new System.Drawing.Size(605, 452);
            this.tabPageScriptSearch.TabIndex = 1;
            this.tabPageScriptSearch.Text = "Search";
            this.tabPageScriptSearch.UseVisualStyleBackColor = true;
            // 
            // treeViewSearchResults
            // 
            this.treeViewSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewSearchResults.Location = new System.Drawing.Point(6, 42);
            this.treeViewSearchResults.Name = "treeViewSearchResults";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Results";
            this.treeViewSearchResults.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewSearchResults.Size = new System.Drawing.Size(309, 397);
            this.treeViewSearchResults.TabIndex = 5;
            this.treeViewSearchResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSearchResults_AfterSelect);
            // 
            // buttonScriptSearch
            // 
            this.buttonScriptSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScriptSearch.Location = new System.Drawing.Point(516, 6);
            this.buttonScriptSearch.Name = "buttonScriptSearch";
            this.buttonScriptSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonScriptSearch.TabIndex = 3;
            this.buttonScriptSearch.Text = "Search";
            this.buttonScriptSearch.UseVisualStyleBackColor = true;
            this.buttonScriptSearch.Click += new System.EventHandler(this.buttonScriptSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(58, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(452, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Test";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(8, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // tabPageProbFinder
            // 
            this.tabPageProbFinder.Controls.Add(this.buttonScriptExportProbCSV);
            this.tabPageProbFinder.Controls.Add(this.buttonExportScriptProblemsXML);
            this.tabPageProbFinder.Controls.Add(this.checkBoxScriptIgnoreVan);
            this.tabPageProbFinder.Controls.Add(this.checkBoxForwardBack);
            this.tabPageProbFinder.Controls.Add(this.checkBoxScriptNoComm);
            this.tabPageProbFinder.Controls.Add(this.checkBoxScriptVars);
            this.tabPageProbFinder.Controls.Add(this.checkBoxScriptDestruction);
            this.tabPageProbFinder.Controls.Add(this.checkBoxScriptFinally);
            this.tabPageProbFinder.Controls.Add(this.buttonFindScriptProbs);
            this.tabPageProbFinder.Controls.Add(this.dataGridViewScriptProbs);
            this.tabPageProbFinder.Location = new System.Drawing.Point(4, 22);
            this.tabPageProbFinder.Name = "tabPageProbFinder";
            this.tabPageProbFinder.Size = new System.Drawing.Size(605, 452);
            this.tabPageProbFinder.TabIndex = 2;
            this.tabPageProbFinder.Text = "Problems";
            this.tabPageProbFinder.UseVisualStyleBackColor = true;
            // 
            // buttonScriptExportProbCSV
            // 
            this.buttonScriptExportProbCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScriptExportProbCSV.Location = new System.Drawing.Point(437, 417);
            this.buttonScriptExportProbCSV.Name = "buttonScriptExportProbCSV";
            this.buttonScriptExportProbCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonScriptExportProbCSV.TabIndex = 16;
            this.buttonScriptExportProbCSV.Text = "Export CSV";
            this.buttonScriptExportProbCSV.UseVisualStyleBackColor = true;
            this.buttonScriptExportProbCSV.Click += new System.EventHandler(this.buttonScriptExportProbCSV_Click);
            // 
            // buttonExportScriptProblemsXML
            // 
            this.buttonExportScriptProblemsXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportScriptProblemsXML.Location = new System.Drawing.Point(518, 416);
            this.buttonExportScriptProblemsXML.Name = "buttonExportScriptProblemsXML";
            this.buttonExportScriptProblemsXML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportScriptProblemsXML.TabIndex = 15;
            this.buttonExportScriptProblemsXML.Text = "Export XML";
            this.buttonExportScriptProblemsXML.UseVisualStyleBackColor = true;
            this.buttonExportScriptProblemsXML.Click += new System.EventHandler(this.buttonExportScriptProblemsXML_Click);
            // 
            // checkBoxScriptIgnoreVan
            // 
            this.checkBoxScriptIgnoreVan.AutoSize = true;
            this.checkBoxScriptIgnoreVan.Checked = true;
            this.checkBoxScriptIgnoreVan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptIgnoreVan.Location = new System.Drawing.Point(188, 41);
            this.checkBoxScriptIgnoreVan.Name = "checkBoxScriptIgnoreVan";
            this.checkBoxScriptIgnoreVan.Size = new System.Drawing.Size(90, 17);
            this.checkBoxScriptIgnoreVan.TabIndex = 9;
            this.checkBoxScriptIgnoreVan.Text = "Ignore Vanilla";
            this.checkBoxScriptIgnoreVan.UseVisualStyleBackColor = true;
            this.checkBoxScriptIgnoreVan.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreVan_CheckedChanged);
            // 
            // checkBoxForwardBack
            // 
            this.checkBoxForwardBack.AutoSize = true;
            this.checkBoxForwardBack.Checked = true;
            this.checkBoxForwardBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxForwardBack.Location = new System.Drawing.Point(188, 15);
            this.checkBoxForwardBack.Name = "checkBoxForwardBack";
            this.checkBoxForwardBack.Size = new System.Drawing.Size(112, 17);
            this.checkBoxForwardBack.TabIndex = 8;
            this.checkBoxForwardBack.Text = "ForwardBackward";
            this.checkBoxForwardBack.UseVisualStyleBackColor = true;
            this.checkBoxForwardBack.CheckedChanged += new System.EventHandler(this.checkBoxForwardBack_CheckedChanged);
            // 
            // checkBoxScriptNoComm
            // 
            this.checkBoxScriptNoComm.AutoSize = true;
            this.checkBoxScriptNoComm.Enabled = false;
            this.checkBoxScriptNoComm.Location = new System.Drawing.Point(95, 41);
            this.checkBoxScriptNoComm.Name = "checkBoxScriptNoComm";
            this.checkBoxScriptNoComm.Size = new System.Drawing.Size(92, 17);
            this.checkBoxScriptNoComm.TabIndex = 5;
            this.checkBoxScriptNoComm.Text = "No Comments";
            this.checkBoxScriptNoComm.UseVisualStyleBackColor = true;
            this.checkBoxScriptNoComm.CheckedChanged += new System.EventHandler(this.checkBoxScriptNoComm_CheckedChanged);
            // 
            // checkBoxScriptVars
            // 
            this.checkBoxScriptVars.AutoSize = true;
            this.checkBoxScriptVars.Enabled = false;
            this.checkBoxScriptVars.Location = new System.Drawing.Point(95, 15);
            this.checkBoxScriptVars.Name = "checkBoxScriptVars";
            this.checkBoxScriptVars.Size = new System.Drawing.Size(87, 17);
            this.checkBoxScriptVars.TabIndex = 4;
            this.checkBoxScriptVars.Text = "Unused Vars";
            this.checkBoxScriptVars.UseVisualStyleBackColor = true;
            this.checkBoxScriptVars.CheckedChanged += new System.EventHandler(this.checkBoxScriptVars_CheckedChanged);
            // 
            // checkBoxScriptDestruction
            // 
            this.checkBoxScriptDestruction.AutoSize = true;
            this.checkBoxScriptDestruction.Checked = true;
            this.checkBoxScriptDestruction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptDestruction.Location = new System.Drawing.Point(11, 40);
            this.checkBoxScriptDestruction.Name = "checkBoxScriptDestruction";
            this.checkBoxScriptDestruction.Size = new System.Drawing.Size(80, 17);
            this.checkBoxScriptDestruction.TabIndex = 3;
            this.checkBoxScriptDestruction.Text = "Destruction";
            this.checkBoxScriptDestruction.UseVisualStyleBackColor = true;
            this.checkBoxScriptDestruction.CheckedChanged += new System.EventHandler(this.checkBoxScriptDestruction_CheckedChanged);
            // 
            // checkBoxScriptFinally
            // 
            this.checkBoxScriptFinally.AutoSize = true;
            this.checkBoxScriptFinally.Checked = true;
            this.checkBoxScriptFinally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScriptFinally.Location = new System.Drawing.Point(11, 15);
            this.checkBoxScriptFinally.Name = "checkBoxScriptFinally";
            this.checkBoxScriptFinally.Size = new System.Drawing.Size(86, 17);
            this.checkBoxScriptFinally.TabIndex = 2;
            this.checkBoxScriptFinally.Text = "Ret in Finally";
            this.checkBoxScriptFinally.UseVisualStyleBackColor = true;
            this.checkBoxScriptFinally.CheckedChanged += new System.EventHandler(this.checkBoxSsriptFinally_CheckedChanged);
            // 
            // buttonFindScriptProbs
            // 
            this.buttonFindScriptProbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindScriptProbs.Enabled = false;
            this.buttonFindScriptProbs.Location = new System.Drawing.Point(516, 6);
            this.buttonFindScriptProbs.Name = "buttonFindScriptProbs";
            this.buttonFindScriptProbs.Size = new System.Drawing.Size(75, 23);
            this.buttonFindScriptProbs.TabIndex = 1;
            this.buttonFindScriptProbs.Text = "Find!";
            this.buttonFindScriptProbs.UseVisualStyleBackColor = true;
            this.buttonFindScriptProbs.Click += new System.EventHandler(this.buttonFindScriptProbs_Click);
            // 
            // dataGridViewScriptProbs
            // 
            this.dataGridViewScriptProbs.AllowUserToAddRows = false;
            this.dataGridViewScriptProbs.AllowUserToDeleteRows = false;
            this.dataGridViewScriptProbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScriptProbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScriptProbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnScriptType,
            this.ColObject,
            this.ColumnFunction,
            this.ColumnLine,
            this.ColumnProblem});
            this.dataGridViewScriptProbs.Location = new System.Drawing.Point(6, 64);
            this.dataGridViewScriptProbs.Name = "dataGridViewScriptProbs";
            this.dataGridViewScriptProbs.Size = new System.Drawing.Size(585, 347);
            this.dataGridViewScriptProbs.TabIndex = 0;
            // 
            // ColumnScriptType
            // 
            this.ColumnScriptType.HeaderText = "Type";
            this.ColumnScriptType.Name = "ColumnScriptType";
            // 
            // ColObject
            // 
            this.ColObject.HeaderText = "Object";
            this.ColObject.Name = "ColObject";
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.HeaderText = "Function";
            this.ColumnFunction.Name = "ColumnFunction";
            // 
            // ColumnLine
            // 
            this.ColumnLine.HeaderText = "Line";
            this.ColumnLine.Name = "ColumnLine";
            this.ColumnLine.Width = 60;
            // 
            // ColumnProblem
            // 
            this.ColumnProblem.HeaderText = "Problem";
            this.ColumnProblem.Name = "ColumnProblem";
            this.ColumnProblem.Width = 182;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(755, 24);
            this.menuStripMain.TabIndex = 19;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.Logout;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHome.Controls.Add(this.webBrowserNews);
            this.panelHome.Controls.Add(this.labelAuthor);
            this.panelHome.Controls.Add(this.labelAppTitle);
            this.panelHome.Controls.Add(this.buttonDonate);
            this.panelHome.Location = new System.Drawing.Point(122, 27);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(621, 485);
            this.panelHome.TabIndex = 25;
            // 
            // webBrowserNews
            // 
            this.webBrowserNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserNews.Location = new System.Drawing.Point(7, 78);
            this.webBrowserNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNews.Name = "webBrowserNews";
            this.webBrowserNews.Size = new System.Drawing.Size(599, 349);
            this.webBrowserNews.TabIndex = 25;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(226, 56);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(121, 13);
            this.labelAuthor.TabIndex = 24;
            this.labelAuthor.Text = "©Iain Ollerenshaw 2012";
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.Location = new System.Drawing.Point(87, 10);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(430, 45);
            this.labelAppTitle.TabIndex = 23;
            this.labelAppTitle.Text = "Siebel Repository Analyser";
            // 
            // buttonDonate
            // 
            this.buttonDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDonate.FlatAppearance.BorderSize = 0;
            this.buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonate.Image = global::SiebelReposAnalyser.Properties.Resources.Donate;
            this.buttonDonate.Location = new System.Drawing.Point(507, 433);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(99, 38);
            this.buttonDonate.TabIndex = 22;
            this.buttonDonate.UseVisualStyleBackColor = true;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBoxExScript
            // 
            this.richTextBoxExScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxExScript.HideSelection = false;
            this.richTextBoxExScript.Location = new System.Drawing.Point(322, 42);
            this.richTextBoxExScript.Name = "richTextBoxExScript";
            this.richTextBoxExScript.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxExScript.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxExScript.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxExScript.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxExScript.NumberBorderThickness = 1F;
            this.richTextBoxExScript.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxExScript.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxExScript.NumberLeadingZeroes = false;
            this.richTextBoxExScript.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxExScript.NumberPadding = 2;
            this.richTextBoxExScript.ShowLineNumbers = true;
            this.richTextBoxExScript.Size = new System.Drawing.Size(277, 397);
            this.richTextBoxExScript.TabIndex = 6;
            this.richTextBoxExScript.Text = "";
            this.richTextBoxExScript.WordWrap = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Object Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Server Script";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Browser Script";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // columnTotal
            // 
            this.columnTotal.HeaderText = "Total";
            this.columnTotal.Name = "columnTotal";
            // 
            // ColumnCustom
            // 
            this.ColumnCustom.HeaderText = "Custom";
            this.ColumnCustom.Name = "ColumnCustom";
            // 
            // checkBoxAutoConnect
            // 
            this.checkBoxAutoConnect.AutoSize = true;
            this.checkBoxAutoConnect.Location = new System.Drawing.Point(85, 154);
            this.checkBoxAutoConnect.Name = "checkBoxAutoConnect";
            this.checkBoxAutoConnect.Size = new System.Drawing.Size(91, 17);
            this.checkBoxAutoConnect.TabIndex = 42;
            this.checkBoxAutoConnect.Text = "Auto Connect";
            this.checkBoxAutoConnect.UseVisualStyleBackColor = true;
            // 
            // FormReposAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 541);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.panelScript);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(771, 579);
            this.Name = "FormReposAnalyser";
            this.Text = "Siebel Repository Analyser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReposAnalyser_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelConnect.ResumeLayout(false);
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxScript.ResumeLayout(false);
            this.groupBoxScript.PerformLayout();
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.tabConfigFunctions.ResumeLayout(false);
            this.tabChangeLog.ResumeLayout(false);
            this.tabChangeLog.PerformLayout();
            this.tabPageConfigProbs.ResumeLayout(false);
            this.tabPageConfigProbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigProbs)).EndInit();
            this.panelScript.ResumeLayout(false);
            this.tabScriptFunctions.ResumeLayout(false);
            this.tabCount.ResumeLayout(false);
            this.tabCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodeLines)).EndInit();
            this.tabPageScriptSearch.ResumeLayout(false);
            this.tabPageScriptSearch.PerformLayout();
            this.tabPageProbFinder.ResumeLayout(false);
            this.tabPageProbFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScriptProbs)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonScript;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Panel panelScript;
        private System.Windows.Forms.TabControl tabScriptFunctions;
        private System.Windows.Forms.TabPage tabCount;
        private System.Windows.Forms.TextBox textTotalLines;
        private System.Windows.Forms.DataGridView dataGridViewCodeLines;
        private System.Windows.Forms.Button buttonCodeLines;
        private System.Windows.Forms.TabControl tabConfigFunctions;
        private System.Windows.Forms.TabPage tabChangeLog;
        private System.Windows.Forms.TextBox textBoxUpdated;
        private System.Windows.Forms.TextBox textBoxUpdatedBy;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBoxCreatedBy;
        private System.Windows.Forms.Label labelUpdated;
        private System.Windows.Forms.Label labelUpdatedBy;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.TreeView treeViewAllChanges;
        private System.Windows.Forms.Button buttonShowChanges;
        private System.Windows.Forms.DateTimePicker dateTimeChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelRefVer;
        private System.Windows.Forms.ComboBox comboBoxVer;
        private System.Windows.Forms.Label labelVanillaLines;
        private System.Windows.Forms.Button buttonExportChangeLogXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnStatus;
        private System.Windows.Forms.TabPage tabPageConfigProbs;
        private System.Windows.Forms.TabPage tabPageScriptSearch;
        private System.Windows.Forms.TabPage tabPageProbFinder;
        private System.Windows.Forms.Button buttonScriptSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.CheckBox checkBoxScriptNoComm;
        private System.Windows.Forms.CheckBox checkBoxScriptVars;
        private System.Windows.Forms.CheckBox checkBoxScriptDestruction;
        private System.Windows.Forms.CheckBox checkBoxScriptFinally;
        private System.Windows.Forms.Button buttonFindScriptProbs;
        private System.Windows.Forms.DataGridView dataGridViewScriptProbs;
        private System.Windows.Forms.CheckBox checkBoxConfigLinkSpec;
        private System.Windows.Forms.CheckBox checkBoxConfigForceActive;
        private System.Windows.Forms.Button buttonConfigFind;
        private System.Windows.Forms.DataGridView dataGridViewConfigProbs;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.CheckBox checkBoxForwardBack;
        private System.Windows.Forms.CheckBox checkBoxScriptIgnoreVan;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.TextBox textBoxEnt;
        private System.Windows.Forms.TextBox textBoxOM;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelEnterprise;
        private System.Windows.Forms.Label labelOM;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.CheckBox checkBoxRemPass;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelConType;
        private System.Windows.Forms.ComboBox comboBoxConType;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.ComboBox comboBoxDataSrc;
        private System.Windows.Forms.TextBox textBoxCFG;
        private System.Windows.Forms.Label labelCFG;
        private System.Windows.Forms.Button buttonGetCFG;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.WebBrowser webBrowserNews;
        private System.Windows.Forms.GroupBox groupBoxScript;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.TextBox textBoxConfigNameFilter;
        private System.Windows.Forms.Label labelConfigNameFilter;
        private System.Windows.Forms.TextBox textBoxScriptNameFilter;
        private System.Windows.Forms.Label labelScriptNameFilter;
        private System.Windows.Forms.Label labelConfigCreatedFilter;
        private System.Windows.Forms.Label labelConfigCreatedByFilter;
        private System.Windows.Forms.Label labelConfigUpdatedFilter;
        private System.Windows.Forms.Label labelConfigUpdatedByFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScriptUpdatedByFilter;
        private System.Windows.Forms.DateTimePicker dateTimeConfigCreatedFilter;
        private System.Windows.Forms.DateTimePicker dateTimeConfigUpdatedFilter;
        private System.Windows.Forms.DateTimePicker dateTimeScriptCreatedFilter;
        private System.Windows.Forms.DateTimePicker dateTimeScriptUpdatedFilter;
        private System.Windows.Forms.ComboBox comboBoxScriptCreatedByFilter;
        private System.Windows.Forms.ComboBox comboBoxScriptUpdatedByFilter;
        private System.Windows.Forms.ComboBox comboBoxConfigCreatedByFilter;
        private System.Windows.Forms.ComboBox comboBoxConfigUpdatedByFilter;
        private System.Windows.Forms.Button buttonExportConfigProblemsXML;
        private System.Windows.Forms.Button buttonExportScriptProblemsXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScriptType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProblem;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonConnect;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label labelDonate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonConfigExportCSV;
        private System.Windows.Forms.Button buttonConfigExportProbCSV;
        private System.Windows.Forms.Button buttonScriptExportProbCSV;
        private System.Windows.Forms.TextBox textBoxCustLines;
        private System.Windows.Forms.TextBox textBoxVanLines;
        private System.Windows.Forms.Label labelCustomLines;
        private System.Windows.Forms.Label labelVanLines;
        private System.Windows.Forms.Label labelTotalLines;
        private System.Windows.Forms.ComboBox comboBoxRepName;
        private System.Windows.Forms.Label labelRepName;
        private System.Windows.Forms.TreeView treeViewSearchResults;
        private Ionic.WinForms.RichTextBoxEx richTextBoxExScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustom;
        private System.Windows.Forms.CheckBox checkBoxAutoConnect;
    }
}

