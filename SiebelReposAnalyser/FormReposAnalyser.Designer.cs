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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReposAnalyser));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.comboBoxConfigUserFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConfigNameFilter = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.dateTimeChanges = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxScriptCountUserFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScriptCountObjFilter = new System.Windows.Forms.TextBox();
            this.textBoxCustLines = new System.Windows.Forms.TextBox();
            this.textBoxVanLines = new System.Windows.Forms.TextBox();
            this.labelCustomLines = new System.Windows.Forms.Label();
            this.labelVanLines = new System.Windows.Forms.Label();
            this.labelTotalLines = new System.Windows.Forms.Label();
            this.labelVanillaLines = new System.Windows.Forms.Label();
            this.comboBoxVer = new System.Windows.Forms.ComboBox();
            this.labelRefVer = new System.Windows.Forms.Label();
            this.textTotalLines = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxScriptUserFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScriptNameFilter = new System.Windows.Forms.Label();
            this.buttonExportScriptProblemsXML = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.automaticUpdater = new wyDay.Controls.AutomaticUpdater();
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButtonUpdateSmall = new System.Windows.Forms.RibbonButton();
            this.ribbonTabMain = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelHome = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonConnect = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDisconnect = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSettings = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelControl = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonGo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStop = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelExport = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonExportCSV = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExportHTML = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonReport = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelHelp = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonHelp = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAbout = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonUpdate = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelView = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonStyle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2007 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2010 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2013 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTheme = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNormal = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonBlue = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonBlack = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGreen = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPurple = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonJellyBelly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonHalloween = new System.Windows.Forms.RibbonButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageScriptProblems = new System.Windows.Forms.TabPage();
            this.fastObjectListViewScriptProbs = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnObject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFunction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLine = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDetails = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textBoxScriptNameFilter = new System.Windows.Forms.TextBox();
            this.tabPageScriptCount = new System.Windows.Forms.TabPage();
            this.objectListViewScriptCount = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnObjectType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnServerScript = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBrowserScript = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTotalScript = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCustomScript = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageScriptSearc = new System.Windows.Forms.TabPage();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.objectListViewSearchResults = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnObjType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnObjName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnScriptType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMethodName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLineNum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.scintillaScriptSearch = new ScintillaNET.Scintilla();
            this.tabPageConfigProblems = new System.Windows.Forms.TabPage();
            this.objectListViewConfigProbs = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnTypeConf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnObjectConf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFunctionConf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDetailsConf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageConfigChanges = new System.Windows.Forms.TabPage();
            this.objectListViewAllChanges = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnObjectTypeChng = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnNameChng = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnModBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnModDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCreatedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCreatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageScriptProblems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewScriptProbs)).BeginInit();
            this.tabPageScriptCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewScriptCount)).BeginInit();
            this.tabPageScriptSearc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewSearchResults)).BeginInit();
            this.tabPageConfigProblems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewConfigProbs)).BeginInit();
            this.tabPageConfigChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewAllChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelConnStatus,
            this.toolStripSplitButtonConnect,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 687);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1058, 22);
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
            this.toolStripStatusLabelConnStatus.Size = new System.Drawing.Size(870, 17);
            this.toolStripStatusLabelConnStatus.Spring = true;
            this.toolStripStatusLabelConnStatus.Text = "Not Connected";
            this.toolStripStatusLabelConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSplitButtonConnect
            // 
            this.toolStripSplitButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.toolStripSplitButtonConnect.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_computer_delete2_16;
            this.toolStripSplitButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonConnect.Name = "toolStripSplitButtonConnect";
            this.toolStripSplitButtonConnect.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButtonConnect.Text = "toolStripSplitButton1";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_computer_delete2_16;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_computer_ok_16;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.MarqueeAnimationSpeed = 0;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // comboBoxConfigUserFilter
            // 
            this.comboBoxConfigUserFilter.FormattingEnabled = true;
            this.comboBoxConfigUserFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxConfigUserFilter.Location = new System.Drawing.Point(131, 35);
            this.comboBoxConfigUserFilter.Name = "comboBoxConfigUserFilter";
            this.comboBoxConfigUserFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxConfigUserFilter.TabIndex = 21;
            this.comboBoxConfigUserFilter.Text = "All";
            this.toolTipMain.SetToolTip(this.comboBoxConfigUserFilter, "Set the Update By user search filter");
            this.comboBoxConfigUserFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigUserFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Updated By Name Filter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Object Name Filter:";
            // 
            // textBoxConfigNameFilter
            // 
            this.textBoxConfigNameFilter.Location = new System.Drawing.Point(131, 9);
            this.textBoxConfigNameFilter.Name = "textBoxConfigNameFilter";
            this.textBoxConfigNameFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxConfigNameFilter.TabIndex = 22;
            this.toolTipMain.SetToolTip(this.textBoxConfigNameFilter, "Set the Object Name search filter");
            this.textBoxConfigNameFilter.TextChanged += new System.EventHandler(this.textBoxConfigNameFilter_TextChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "All"});
            this.comboBoxUser.Location = new System.Drawing.Point(316, 12);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(202, 21);
            this.comboBoxUser.TabIndex = 16;
            this.comboBoxUser.Text = "All";
            this.toolTipMain.SetToolTip(this.comboBoxUser, "Set the Update By User search filter");
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.TextChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(274, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login:";
            // 
            // dateTimeChanges
            // 
            this.dateTimeChanges.CustomFormat = "ddd, MMM dd, yyyy HH:mm:ss";
            this.dateTimeChanges.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeChanges.Location = new System.Drawing.Point(91, 12);
            this.dateTimeChanges.Name = "dateTimeChanges";
            this.dateTimeChanges.Size = new System.Drawing.Size(177, 20);
            this.dateTimeChanges.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.dateTimeChanges, "Set the Update By Date search filter");
            this.dateTimeChanges.ValueChanged += new System.EventHandler(this.dateTimeChanges_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changes Since:";
            // 
            // comboBoxScriptCountUserFilter
            // 
            this.comboBoxScriptCountUserFilter.FormattingEnabled = true;
            this.comboBoxScriptCountUserFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxScriptCountUserFilter.Location = new System.Drawing.Point(131, 35);
            this.comboBoxScriptCountUserFilter.Name = "comboBoxScriptCountUserFilter";
            this.comboBoxScriptCountUserFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxScriptCountUserFilter.TabIndex = 21;
            this.comboBoxScriptCountUserFilter.Text = "All";
            this.toolTipMain.SetToolTip(this.comboBoxScriptCountUserFilter, "Set the Updated By user search filter");
            this.comboBoxScriptCountUserFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptCountUserFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Updated By Name Filter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Object Name Filter:";
            // 
            // textBoxScriptCountObjFilter
            // 
            this.textBoxScriptCountObjFilter.Location = new System.Drawing.Point(131, 9);
            this.textBoxScriptCountObjFilter.Name = "textBoxScriptCountObjFilter";
            this.textBoxScriptCountObjFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxScriptCountObjFilter.TabIndex = 22;
            this.toolTipMain.SetToolTip(this.textBoxScriptCountObjFilter, "Set the Object Name search filter");
            this.textBoxScriptCountObjFilter.TextChanged += new System.EventHandler(this.textBoxScriptCountObjFilter_TextChanged);
            // 
            // textBoxCustLines
            // 
            this.textBoxCustLines.Location = new System.Drawing.Point(83, 284);
            this.textBoxCustLines.Name = "textBoxCustLines";
            this.textBoxCustLines.ReadOnly = true;
            this.textBoxCustLines.Size = new System.Drawing.Size(128, 20);
            this.textBoxCustLines.TabIndex = 12;
            this.toolTipMain.SetToolTip(this.textBoxCustLines, "Total lines of custom code");
            // 
            // textBoxVanLines
            // 
            this.textBoxVanLines.Location = new System.Drawing.Point(82, 258);
            this.textBoxVanLines.Name = "textBoxVanLines";
            this.textBoxVanLines.ReadOnly = true;
            this.textBoxVanLines.Size = new System.Drawing.Size(128, 20);
            this.textBoxVanLines.TabIndex = 11;
            this.toolTipMain.SetToolTip(this.textBoxVanLines, "Total lines of standard code based on selected Siebel version");
            // 
            // labelCustomLines
            // 
            this.labelCustomLines.AutoSize = true;
            this.labelCustomLines.Location = new System.Drawing.Point(8, 286);
            this.labelCustomLines.Name = "labelCustomLines";
            this.labelCustomLines.Size = new System.Drawing.Size(72, 13);
            this.labelCustomLines.TabIndex = 10;
            this.labelCustomLines.Text = "Total Custom:";
            // 
            // labelVanLines
            // 
            this.labelVanLines.AutoSize = true;
            this.labelVanLines.Location = new System.Drawing.Point(8, 260);
            this.labelVanLines.Name = "labelVanLines";
            this.labelVanLines.Size = new System.Drawing.Size(68, 13);
            this.labelVanLines.TabIndex = 9;
            this.labelVanLines.Text = "Total Vanilla:";
            // 
            // labelTotalLines
            // 
            this.labelTotalLines.AutoSize = true;
            this.labelTotalLines.Location = new System.Drawing.Point(7, 236);
            this.labelTotalLines.Name = "labelTotalLines";
            this.labelTotalLines.Size = new System.Drawing.Size(62, 13);
            this.labelTotalLines.TabIndex = 8;
            this.labelTotalLines.Text = "Total Lines:";
            // 
            // labelVanillaLines
            // 
            this.labelVanillaLines.AutoSize = true;
            this.labelVanillaLines.Location = new System.Drawing.Point(284, 236);
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
            this.comboBoxVer.Location = new System.Drawing.Point(390, 9);
            this.comboBoxVer.Name = "comboBoxVer";
            this.comboBoxVer.Size = new System.Drawing.Size(128, 21);
            this.comboBoxVer.TabIndex = 6;
            this.toolTipMain.SetToolTip(this.comboBoxVer, "Select base Siebel version");
            this.comboBoxVer.SelectedIndexChanged += new System.EventHandler(this.comboBoxVer_SelectedIndexChanged);
            // 
            // labelRefVer
            // 
            this.labelRefVer.AutoSize = true;
            this.labelRefVer.Location = new System.Drawing.Point(339, 12);
            this.labelRefVer.Name = "labelRefVer";
            this.labelRefVer.Size = new System.Drawing.Size(45, 13);
            this.labelRefVer.TabIndex = 5;
            this.labelRefVer.Text = "Version:";
            // 
            // textTotalLines
            // 
            this.textTotalLines.Location = new System.Drawing.Point(83, 232);
            this.textTotalLines.Name = "textTotalLines";
            this.textTotalLines.ReadOnly = true;
            this.textTotalLines.Size = new System.Drawing.Size(128, 20);
            this.textTotalLines.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.textTotalLines, "Total lines of code");
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(67, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(275, 20);
            this.textBoxSearch.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.textBoxSearch, "Search text");
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(17, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // comboBoxScriptUserFilter
            // 
            this.comboBoxScriptUserFilter.FormattingEnabled = true;
            this.comboBoxScriptUserFilter.Items.AddRange(new object[] {
            "All"});
            this.comboBoxScriptUserFilter.Location = new System.Drawing.Point(131, 35);
            this.comboBoxScriptUserFilter.Name = "comboBoxScriptUserFilter";
            this.comboBoxScriptUserFilter.Size = new System.Drawing.Size(202, 21);
            this.comboBoxScriptUserFilter.TabIndex = 17;
            this.comboBoxScriptUserFilter.Text = "All";
            this.toolTipMain.SetToolTip(this.comboBoxScriptUserFilter, "Set the Update By user search filter");
            this.comboBoxScriptUserFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptUserFilter_SelectedIndexChanged);
            this.comboBoxScriptUserFilter.TextChanged += new System.EventHandler(this.comboBoxScriptUserFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Updated By Name Filter:";
            // 
            // labelScriptNameFilter
            // 
            this.labelScriptNameFilter.AutoSize = true;
            this.labelScriptNameFilter.Location = new System.Drawing.Point(3, 12);
            this.labelScriptNameFilter.Name = "labelScriptNameFilter";
            this.labelScriptNameFilter.Size = new System.Drawing.Size(97, 13);
            this.labelScriptNameFilter.TabIndex = 18;
            this.labelScriptNameFilter.Text = "Object Name Filter:";
            // 
            // buttonExportScriptProblemsXML
            // 
            this.buttonExportScriptProblemsXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportScriptProblemsXML.Location = new System.Drawing.Point(1051, 475);
            this.buttonExportScriptProblemsXML.Name = "buttonExportScriptProblemsXML";
            this.buttonExportScriptProblemsXML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportScriptProblemsXML.TabIndex = 15;
            this.buttonExportScriptProblemsXML.Text = "Export XML";
            this.toolTipMain.SetToolTip(this.buttonExportScriptProblemsXML, "Export results to XML");
            this.buttonExportScriptProblemsXML.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // automaticUpdater
            // 
            this.automaticUpdater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.automaticUpdater.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.automaticUpdater.ContainerForm = this;
            this.automaticUpdater.Location = new System.Drawing.Point(1030, 12);
            this.automaticUpdater.Name = "automaticUpdater";
            this.automaticUpdater.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdater.TabIndex = 26;
            this.automaticUpdater.wyUpdateCommandline = null;
            // 
            // ribbonMain
            // 
            this.ribbonMain.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbonMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.Minimized = false;
            this.ribbonMain.Name = "ribbonMain";
            // 
            // 
            // 
            this.ribbonMain.OrbDropDown.BorderRoundness = 8;
            this.ribbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExit);
            this.ribbonMain.OrbDropDown.Name = "";
            this.ribbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 116);
            this.ribbonMain.OrbDropDown.TabIndex = 0;
            this.ribbonMain.OrbImage = null;
            this.ribbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbonMain.OrbText = "File";
            // 
            // 
            // 
            this.ribbonMain.QuickAcessToolbar.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_install_16;
            this.ribbonMain.QuickAcessToolbar.Items.Add(this.ribbonButtonUpdateSmall);
            this.ribbonMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMain.Size = new System.Drawing.Size(1058, 136);
            this.ribbonMain.TabIndex = 27;
            this.ribbonMain.Tabs.Add(this.ribbonTabMain);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMain.Text = "ribbonMain";
            this.ribbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonOrbMenuItemExit
            // 
            this.ribbonOrbMenuItemExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemExit.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_close_window_16;
            this.ribbonOrbMenuItemExit.SmallImage = global::SiebelReposAnalyser.Properties.Resources.REPOS_close_window_16;
            this.ribbonOrbMenuItemExit.Text = "Exit";
            this.ribbonOrbMenuItemExit.Click += new System.EventHandler(this.ribbonOrbMenuItemExit_Click);
            // 
            // ribbonButtonUpdateSmall
            // 
            this.ribbonButtonUpdateSmall.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUpdateSmall.Image")));
            this.ribbonButtonUpdateSmall.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonUpdateSmall.SmallImage = global::SiebelReposAnalyser.Properties.Resources.REPOS_install_16;
            this.ribbonButtonUpdateSmall.Text = "ribbonButton1";
            this.ribbonButtonUpdateSmall.Click += new System.EventHandler(this.ribbonButtonUpdateSmall_Click);
            // 
            // ribbonTabMain
            // 
            this.ribbonTabMain.Panels.Add(this.ribbonPanelHome);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelControl);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelExport);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelHelp);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelView);
            this.ribbonTabMain.Text = "Main";
            // 
            // ribbonPanelHome
            // 
            this.ribbonPanelHome.ButtonMoreEnabled = false;
            this.ribbonPanelHome.ButtonMoreVisible = false;
            this.ribbonPanelHome.Items.Add(this.ribbonButtonConnect);
            this.ribbonPanelHome.Items.Add(this.ribbonButtonDisconnect);
            this.ribbonPanelHome.Items.Add(this.ribbonButtonSettings);
            this.ribbonPanelHome.Text = "Home";
            // 
            // ribbonButtonConnect
            // 
            this.ribbonButtonConnect.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_computer_internet_32;
            this.ribbonButtonConnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonConnect.SmallImage")));
            this.ribbonButtonConnect.Text = "Connect";
            this.ribbonButtonConnect.Click += new System.EventHandler(this.ribbonButtonConnect_Click);
            // 
            // ribbonButtonDisconnect
            // 
            this.ribbonButtonDisconnect.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_computer_delete2_32;
            this.ribbonButtonDisconnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDisconnect.SmallImage")));
            this.ribbonButtonDisconnect.Text = "Disconnect";
            this.ribbonButtonDisconnect.Click += new System.EventHandler(this.ribbonButtonDisconnect_Click);
            // 
            // ribbonButtonSettings
            // 
            this.ribbonButtonSettings.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_gears_32;
            this.ribbonButtonSettings.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSettings.SmallImage")));
            this.ribbonButtonSettings.Text = "Settings";
            this.ribbonButtonSettings.Click += new System.EventHandler(this.ribbonButtonSettings_Click);
            // 
            // ribbonPanelControl
            // 
            this.ribbonPanelControl.ButtonMoreEnabled = false;
            this.ribbonPanelControl.ButtonMoreVisible = false;
            this.ribbonPanelControl.Items.Add(this.ribbonButtonGo);
            this.ribbonPanelControl.Items.Add(this.ribbonButtonStop);
            this.ribbonPanelControl.Text = "Control";
            // 
            // ribbonButtonGo
            // 
            this.ribbonButtonGo.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_flag_green_32;
            this.ribbonButtonGo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGo.SmallImage")));
            this.ribbonButtonGo.Text = "Go!";
            this.ribbonButtonGo.Click += new System.EventHandler(this.ribbonButtonGo_Click);
            // 
            // ribbonButtonStop
            // 
            this.ribbonButtonStop.Enabled = false;
            this.ribbonButtonStop.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_stop_32;
            this.ribbonButtonStop.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStop.SmallImage")));
            this.ribbonButtonStop.Text = "Cancel";
            // 
            // ribbonPanelExport
            // 
            this.ribbonPanelExport.ButtonMoreEnabled = false;
            this.ribbonPanelExport.ButtonMoreVisible = false;
            this.ribbonPanelExport.Items.Add(this.ribbonButtonExportCSV);
            this.ribbonPanelExport.Items.Add(this.ribbonButtonExportHTML);
            this.ribbonPanelExport.Items.Add(this.ribbonButtonReport);
            this.ribbonPanelExport.Text = "Export";
            // 
            // ribbonButtonExportCSV
            // 
            this.ribbonButtonExportCSV.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_document_spreadsheet_32;
            this.ribbonButtonExportCSV.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExportCSV.SmallImage")));
            this.ribbonButtonExportCSV.Text = "CSV";
            this.ribbonButtonExportCSV.Click += new System.EventHandler(this.ribbonButtonExportCSV_Click);
            // 
            // ribbonButtonExportHTML
            // 
            this.ribbonButtonExportHTML.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_document_text_internet_32;
            this.ribbonButtonExportHTML.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExportHTML.SmallImage")));
            this.ribbonButtonExportHTML.Text = "HTML";
            this.ribbonButtonExportHTML.Click += new System.EventHandler(this.ribbonButtonExportHTML_Click);
            // 
            // ribbonButtonReport
            // 
            this.ribbonButtonReport.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_report_32;
            this.ribbonButtonReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonReport.SmallImage")));
            this.ribbonButtonReport.Text = "Report";
            this.ribbonButtonReport.Click += new System.EventHandler(this.ribbonButtonReport_Click);
            // 
            // ribbonPanelHelp
            // 
            this.ribbonPanelHelp.ButtonMoreEnabled = false;
            this.ribbonPanelHelp.ButtonMoreVisible = false;
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonAbout);
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonUpdate);
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonHelp);
            this.ribbonPanelHelp.Text = "Help";
            // 
            // ribbonButtonHelp
            // 
            this.ribbonButtonHelp.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_help2_32;
            this.ribbonButtonHelp.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelp.SmallImage")));
            this.ribbonButtonHelp.Text = "Help";
            this.ribbonButtonHelp.Click += new System.EventHandler(this.ribbonButtonHelp_Click);
            // 
            // ribbonButtonAbout
            // 
            this.ribbonButtonAbout.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_info_32;
            this.ribbonButtonAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAbout.SmallImage")));
            this.ribbonButtonAbout.Text = "About";
            this.ribbonButtonAbout.Click += new System.EventHandler(this.ribbonButtonAbout_Click);
            // 
            // ribbonButtonUpdate
            // 
            this.ribbonButtonUpdate.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_install_32;
            this.ribbonButtonUpdate.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUpdate.SmallImage")));
            this.ribbonButtonUpdate.Text = "Update";
            this.ribbonButtonUpdate.Click += new System.EventHandler(this.ribbonButtonUpdate_Click);
            // 
            // ribbonPanelView
            // 
            this.ribbonPanelView.ButtonMoreEnabled = false;
            this.ribbonPanelView.ButtonMoreVisible = false;
            this.ribbonPanelView.Items.Add(this.ribbonButtonStyle);
            this.ribbonPanelView.Items.Add(this.ribbonButtonTheme);
            this.ribbonPanelView.Text = "Appearance";
            // 
            // ribbonButtonStyle
            // 
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2007);
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2010);
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2013);
            this.ribbonButtonStyle.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_gear_32;
            this.ribbonButtonStyle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle.SmallImage")));
            this.ribbonButtonStyle.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonStyle.Text = "Style";
            this.ribbonButtonStyle.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonStyle_DropDownItemClicked);
            // 
            // ribbonButtonStyle2007
            // 
            this.ribbonButtonStyle2007.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2007.CheckOnClick = true;
            this.ribbonButtonStyle2007.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2007.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2007.Image")));
            this.ribbonButtonStyle2007.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2007.SmallImage")));
            this.ribbonButtonStyle2007.Text = "Office 2007";
            // 
            // ribbonButtonStyle2010
            // 
            this.ribbonButtonStyle2010.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2010.CheckOnClick = true;
            this.ribbonButtonStyle2010.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2010.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2010.Image")));
            this.ribbonButtonStyle2010.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2010.SmallImage")));
            this.ribbonButtonStyle2010.Text = "Office 2010";
            // 
            // ribbonButtonStyle2013
            // 
            this.ribbonButtonStyle2013.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2013.CheckOnClick = true;
            this.ribbonButtonStyle2013.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2013.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2013.Image")));
            this.ribbonButtonStyle2013.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2013.SmallImage")));
            this.ribbonButtonStyle2013.Text = "Office 2013";
            // 
            // ribbonButtonTheme
            // 
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonNormal);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonBlue);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonBlack);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonGreen);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonPurple);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonJellyBelly);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonHalloween);
            this.ribbonButtonTheme.Image = global::SiebelReposAnalyser.Properties.Resources.REPOS_favorite_32;
            this.ribbonButtonTheme.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTheme.SmallImage")));
            this.ribbonButtonTheme.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonTheme.Text = "Theme";
            this.ribbonButtonTheme.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonTheme_DropDownItemClicked);
            // 
            // ribbonButtonNormal
            // 
            this.ribbonButtonNormal.Checked = true;
            this.ribbonButtonNormal.CheckedGroup = "Colours";
            this.ribbonButtonNormal.CheckOnClick = true;
            this.ribbonButtonNormal.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormal.Image")));
            this.ribbonButtonNormal.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormal.SmallImage")));
            this.ribbonButtonNormal.Text = "Normal";
            // 
            // ribbonButtonBlue
            // 
            this.ribbonButtonBlue.CheckedGroup = "Colours";
            this.ribbonButtonBlue.CheckOnClick = true;
            this.ribbonButtonBlue.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonBlue.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlue.Image")));
            this.ribbonButtonBlue.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlue.SmallImage")));
            this.ribbonButtonBlue.Text = "Blue";
            // 
            // ribbonButtonBlack
            // 
            this.ribbonButtonBlack.CheckedGroup = "Colours";
            this.ribbonButtonBlack.CheckOnClick = true;
            this.ribbonButtonBlack.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonBlack.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlack.Image")));
            this.ribbonButtonBlack.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlack.SmallImage")));
            this.ribbonButtonBlack.Text = "Black";
            // 
            // ribbonButtonGreen
            // 
            this.ribbonButtonGreen.CheckedGroup = "Colours";
            this.ribbonButtonGreen.CheckOnClick = true;
            this.ribbonButtonGreen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonGreen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGreen.Image")));
            this.ribbonButtonGreen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGreen.SmallImage")));
            this.ribbonButtonGreen.Text = "Green";
            // 
            // ribbonButtonPurple
            // 
            this.ribbonButtonPurple.CheckedGroup = "Colours";
            this.ribbonButtonPurple.CheckOnClick = true;
            this.ribbonButtonPurple.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonPurple.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPurple.Image")));
            this.ribbonButtonPurple.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPurple.SmallImage")));
            this.ribbonButtonPurple.Text = "Purple";
            // 
            // ribbonButtonJellyBelly
            // 
            this.ribbonButtonJellyBelly.CheckedGroup = "Colours";
            this.ribbonButtonJellyBelly.CheckOnClick = true;
            this.ribbonButtonJellyBelly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonJellyBelly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJellyBelly.Image")));
            this.ribbonButtonJellyBelly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJellyBelly.SmallImage")));
            this.ribbonButtonJellyBelly.Text = "Jelly Belly";
            // 
            // ribbonButtonHalloween
            // 
            this.ribbonButtonHalloween.CheckedGroup = "Colours";
            this.ribbonButtonHalloween.CheckOnClick = true;
            this.ribbonButtonHalloween.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonHalloween.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHalloween.Image")));
            this.ribbonButtonHalloween.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHalloween.SmallImage")));
            this.ribbonButtonHalloween.Text = "Halloween";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageScriptProblems);
            this.tabControlMain.Controls.Add(this.tabPageScriptCount);
            this.tabControlMain.Controls.Add(this.tabPageScriptSearc);
            this.tabControlMain.Controls.Add(this.tabPageConfigProblems);
            this.tabControlMain.Controls.Add(this.tabPageConfigChanges);
            this.tabControlMain.ImageList = this.imageListTabs;
            this.tabControlMain.Location = new System.Drawing.Point(12, 142);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1039, 542);
            this.tabControlMain.TabIndex = 28;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageScriptProblems
            // 
            this.tabPageScriptProblems.Controls.Add(this.fastObjectListViewScriptProbs);
            this.tabPageScriptProblems.Controls.Add(this.textBoxScriptNameFilter);
            this.tabPageScriptProblems.Controls.Add(this.comboBoxScriptUserFilter);
            this.tabPageScriptProblems.Controls.Add(this.label2);
            this.tabPageScriptProblems.Controls.Add(this.labelScriptNameFilter);
            this.tabPageScriptProblems.Controls.Add(this.buttonExportScriptProblemsXML);
            this.tabPageScriptProblems.ImageIndex = 1;
            this.tabPageScriptProblems.Location = new System.Drawing.Point(4, 23);
            this.tabPageScriptProblems.Name = "tabPageScriptProblems";
            this.tabPageScriptProblems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScriptProblems.Size = new System.Drawing.Size(1031, 515);
            this.tabPageScriptProblems.TabIndex = 0;
            this.tabPageScriptProblems.Text = "Script Problems";
            this.tabPageScriptProblems.UseVisualStyleBackColor = true;
            // 
            // fastObjectListViewScriptProbs
            // 
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnType);
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnCategory);
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnObject);
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnFunction);
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnLine);
            this.fastObjectListViewScriptProbs.AllColumns.Add(this.olvColumnDetails);
            this.fastObjectListViewScriptProbs.AllowColumnReorder = true;
            this.fastObjectListViewScriptProbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastObjectListViewScriptProbs.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.fastObjectListViewScriptProbs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnType,
            this.olvColumnCategory,
            this.olvColumnObject,
            this.olvColumnFunction,
            this.olvColumnLine,
            this.olvColumnDetails});
            this.fastObjectListViewScriptProbs.FullRowSelect = true;
            this.fastObjectListViewScriptProbs.GridLines = true;
            this.fastObjectListViewScriptProbs.HideSelection = false;
            this.fastObjectListViewScriptProbs.Location = new System.Drawing.Point(5, 65);
            this.fastObjectListViewScriptProbs.MultiSelect = false;
            this.fastObjectListViewScriptProbs.Name = "fastObjectListViewScriptProbs";
            this.fastObjectListViewScriptProbs.ShowGroups = false;
            this.fastObjectListViewScriptProbs.Size = new System.Drawing.Size(1023, 450);
            this.fastObjectListViewScriptProbs.TabIndex = 22;
            this.fastObjectListViewScriptProbs.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewScriptProbs.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewScriptProbs.VirtualMode = true;
            // 
            // olvColumnType
            // 
            this.olvColumnType.AspectName = "Type";
            this.olvColumnType.Text = "Type";
            // 
            // olvColumnCategory
            // 
            this.olvColumnCategory.AspectName = "Category";
            this.olvColumnCategory.Text = "Category";
            // 
            // olvColumnObject
            // 
            this.olvColumnObject.AspectName = "Object";
            this.olvColumnObject.Text = "Object";
            // 
            // olvColumnFunction
            // 
            this.olvColumnFunction.AspectName = "Function";
            this.olvColumnFunction.Text = "Function";
            // 
            // olvColumnLine
            // 
            this.olvColumnLine.AspectName = "Line";
            this.olvColumnLine.Text = "Line";
            // 
            // olvColumnDetails
            // 
            this.olvColumnDetails.AspectName = "Details";
            this.olvColumnDetails.Text = "Details";
            // 
            // textBoxScriptNameFilter
            // 
            this.textBoxScriptNameFilter.Location = new System.Drawing.Point(131, 9);
            this.textBoxScriptNameFilter.Name = "textBoxScriptNameFilter";
            this.textBoxScriptNameFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxScriptNameFilter.TabIndex = 21;
            this.textBoxScriptNameFilter.TextChanged += new System.EventHandler(this.textBoxScriptNameFilter_TextChanged);
            // 
            // tabPageScriptCount
            // 
            this.tabPageScriptCount.Controls.Add(this.objectListViewScriptCount);
            this.tabPageScriptCount.Controls.Add(this.labelVanillaLines);
            this.tabPageScriptCount.Controls.Add(this.comboBoxScriptCountUserFilter);
            this.tabPageScriptCount.Controls.Add(this.comboBoxVer);
            this.tabPageScriptCount.Controls.Add(this.label3);
            this.tabPageScriptCount.Controls.Add(this.label4);
            this.tabPageScriptCount.Controls.Add(this.textBoxScriptCountObjFilter);
            this.tabPageScriptCount.Controls.Add(this.textTotalLines);
            this.tabPageScriptCount.Controls.Add(this.textBoxCustLines);
            this.tabPageScriptCount.Controls.Add(this.labelRefVer);
            this.tabPageScriptCount.Controls.Add(this.textBoxVanLines);
            this.tabPageScriptCount.Controls.Add(this.labelTotalLines);
            this.tabPageScriptCount.Controls.Add(this.labelCustomLines);
            this.tabPageScriptCount.Controls.Add(this.labelVanLines);
            this.tabPageScriptCount.ImageIndex = 2;
            this.tabPageScriptCount.Location = new System.Drawing.Point(4, 23);
            this.tabPageScriptCount.Name = "tabPageScriptCount";
            this.tabPageScriptCount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScriptCount.Size = new System.Drawing.Size(1031, 515);
            this.tabPageScriptCount.TabIndex = 1;
            this.tabPageScriptCount.Text = "Script Count";
            this.tabPageScriptCount.UseVisualStyleBackColor = true;
            // 
            // objectListViewScriptCount
            // 
            this.objectListViewScriptCount.AllColumns.Add(this.olvColumnObjectType);
            this.objectListViewScriptCount.AllColumns.Add(this.olvColumnServerScript);
            this.objectListViewScriptCount.AllColumns.Add(this.olvColumnBrowserScript);
            this.objectListViewScriptCount.AllColumns.Add(this.olvColumnTotalScript);
            this.objectListViewScriptCount.AllColumns.Add(this.olvColumnCustomScript);
            this.objectListViewScriptCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListViewScriptCount.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.objectListViewScriptCount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnObjectType,
            this.olvColumnServerScript,
            this.olvColumnBrowserScript,
            this.olvColumnTotalScript,
            this.olvColumnCustomScript});
            this.objectListViewScriptCount.FullRowSelect = true;
            this.objectListViewScriptCount.GridLines = true;
            this.objectListViewScriptCount.Location = new System.Drawing.Point(5, 65);
            this.objectListViewScriptCount.MultiSelect = false;
            this.objectListViewScriptCount.Name = "objectListViewScriptCount";
            this.objectListViewScriptCount.ShowGroups = false;
            this.objectListViewScriptCount.Size = new System.Drawing.Size(1023, 159);
            this.objectListViewScriptCount.TabIndex = 25;
            this.objectListViewScriptCount.UseCompatibleStateImageBehavior = false;
            this.objectListViewScriptCount.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnObjectType
            // 
            this.olvColumnObjectType.AspectName = "ObjectType";
            this.olvColumnObjectType.Text = "Type";
            this.olvColumnObjectType.Width = 160;
            // 
            // olvColumnServerScript
            // 
            this.olvColumnServerScript.AspectName = "ServerScript";
            this.olvColumnServerScript.Text = "Server Script";
            this.olvColumnServerScript.Width = 80;
            // 
            // olvColumnBrowserScript
            // 
            this.olvColumnBrowserScript.AspectName = "BrowserScript";
            this.olvColumnBrowserScript.Text = "Browser Script";
            this.olvColumnBrowserScript.Width = 80;
            // 
            // olvColumnTotalScript
            // 
            this.olvColumnTotalScript.AspectName = "TotalScript";
            this.olvColumnTotalScript.Text = "Total";
            this.olvColumnTotalScript.Width = 80;
            // 
            // olvColumnCustomScript
            // 
            this.olvColumnCustomScript.AspectName = "CustomScript";
            this.olvColumnCustomScript.Text = "Custom";
            this.olvColumnCustomScript.Width = 80;
            // 
            // tabPageScriptSearc
            // 
            this.tabPageScriptSearc.Controls.Add(this.checkBoxIgnoreCase);
            this.tabPageScriptSearc.Controls.Add(this.splitContainerMain);
            this.tabPageScriptSearc.Controls.Add(this.labelSearch);
            this.tabPageScriptSearc.Controls.Add(this.textBoxSearch);
            this.tabPageScriptSearc.ImageIndex = 0;
            this.tabPageScriptSearc.Location = new System.Drawing.Point(4, 23);
            this.tabPageScriptSearc.Name = "tabPageScriptSearc";
            this.tabPageScriptSearc.Size = new System.Drawing.Size(1031, 515);
            this.tabPageScriptSearc.TabIndex = 2;
            this.tabPageScriptSearc.Text = "Script Search";
            this.tabPageScriptSearc.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Checked = true;
            this.checkBoxIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(349, 15);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.checkBoxIgnoreCase.TabIndex = 9;
            this.checkBoxIgnoreCase.Text = "Ignore Case";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(4, 38);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.objectListViewSearchResults);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.scintillaScriptSearch);
            this.splitContainerMain.Size = new System.Drawing.Size(1024, 466);
            this.splitContainerMain.SplitterDistance = 341;
            this.splitContainerMain.TabIndex = 8;
            this.splitContainerMain.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerMain_Paint);
            // 
            // objectListViewSearchResults
            // 
            this.objectListViewSearchResults.AllColumns.Add(this.olvColumnObjType);
            this.objectListViewSearchResults.AllColumns.Add(this.olvColumnObjName);
            this.objectListViewSearchResults.AllColumns.Add(this.olvColumnScriptType);
            this.objectListViewSearchResults.AllColumns.Add(this.olvColumnMethodName);
            this.objectListViewSearchResults.AllColumns.Add(this.olvColumnLineNum);
            this.objectListViewSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnObjType,
            this.olvColumnObjName,
            this.olvColumnScriptType,
            this.olvColumnMethodName,
            this.olvColumnLineNum});
            this.objectListViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewSearchResults.FullRowSelect = true;
            this.objectListViewSearchResults.GridLines = true;
            this.objectListViewSearchResults.Location = new System.Drawing.Point(0, 0);
            this.objectListViewSearchResults.Name = "objectListViewSearchResults";
            this.objectListViewSearchResults.Size = new System.Drawing.Size(341, 466);
            this.objectListViewSearchResults.TabIndex = 7;
            this.objectListViewSearchResults.UseCompatibleStateImageBehavior = false;
            this.objectListViewSearchResults.View = System.Windows.Forms.View.Details;
            this.objectListViewSearchResults.SelectedIndexChanged += new System.EventHandler(this.objectListViewSearchResults_SelectedIndexChanged);
            // 
            // olvColumnObjType
            // 
            this.olvColumnObjType.AspectName = "ObjectType";
            this.olvColumnObjType.Text = "Type";
            // 
            // olvColumnObjName
            // 
            this.olvColumnObjName.AspectName = "ObjectName";
            this.olvColumnObjName.Text = "Name";
            // 
            // olvColumnScriptType
            // 
            this.olvColumnScriptType.AspectName = "ScriptType";
            this.olvColumnScriptType.Text = "Script Type";
            // 
            // olvColumnMethodName
            // 
            this.olvColumnMethodName.AspectName = "MethodName";
            this.olvColumnMethodName.Text = "Method Name";
            // 
            // olvColumnLineNum
            // 
            this.olvColumnLineNum.AspectName = "LineNum";
            this.olvColumnLineNum.Text = "Line #";
            // 
            // scintillaScriptSearch
            // 
            this.scintillaScriptSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaScriptSearch.HighlightGuide = 0;
            this.scintillaScriptSearch.Lexer = ScintillaNET.Lexer.Cpp;
            this.scintillaScriptSearch.Location = new System.Drawing.Point(0, 0);
            this.scintillaScriptSearch.Name = "scintillaScriptSearch";
            this.scintillaScriptSearch.RectangularSelectionAnchor = 0;
            this.scintillaScriptSearch.RectangularSelectionAnchorVirtualSpace = 0;
            this.scintillaScriptSearch.RectangularSelectionCaret = 0;
            this.scintillaScriptSearch.RectangularSelectionCaretVirtualSpace = 0;
            this.scintillaScriptSearch.Size = new System.Drawing.Size(679, 466);
            this.scintillaScriptSearch.TabIndex = 0;
            // 
            // tabPageConfigProblems
            // 
            this.tabPageConfigProblems.Controls.Add(this.objectListViewConfigProbs);
            this.tabPageConfigProblems.Controls.Add(this.comboBoxConfigUserFilter);
            this.tabPageConfigProblems.Controls.Add(this.label5);
            this.tabPageConfigProblems.Controls.Add(this.label6);
            this.tabPageConfigProblems.Controls.Add(this.textBoxConfigNameFilter);
            this.tabPageConfigProblems.ImageIndex = 3;
            this.tabPageConfigProblems.Location = new System.Drawing.Point(4, 23);
            this.tabPageConfigProblems.Name = "tabPageConfigProblems";
            this.tabPageConfigProblems.Size = new System.Drawing.Size(1031, 515);
            this.tabPageConfigProblems.TabIndex = 3;
            this.tabPageConfigProblems.Text = "Config Problems";
            this.tabPageConfigProblems.UseVisualStyleBackColor = true;
            // 
            // objectListViewConfigProbs
            // 
            this.objectListViewConfigProbs.AllColumns.Add(this.olvColumnTypeConf);
            this.objectListViewConfigProbs.AllColumns.Add(this.olvColumnObjectConf);
            this.objectListViewConfigProbs.AllColumns.Add(this.olvColumnFunctionConf);
            this.objectListViewConfigProbs.AllColumns.Add(this.olvColumnDetailsConf);
            this.objectListViewConfigProbs.AllowColumnReorder = true;
            this.objectListViewConfigProbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListViewConfigProbs.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.objectListViewConfigProbs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTypeConf,
            this.olvColumnObjectConf,
            this.olvColumnFunctionConf,
            this.olvColumnDetailsConf});
            this.objectListViewConfigProbs.FullRowSelect = true;
            this.objectListViewConfigProbs.GridLines = true;
            this.objectListViewConfigProbs.Location = new System.Drawing.Point(5, 65);
            this.objectListViewConfigProbs.MultiSelect = false;
            this.objectListViewConfigProbs.Name = "objectListViewConfigProbs";
            this.objectListViewConfigProbs.ShowGroups = false;
            this.objectListViewConfigProbs.Size = new System.Drawing.Size(1023, 447);
            this.objectListViewConfigProbs.TabIndex = 25;
            this.objectListViewConfigProbs.UseCompatibleStateImageBehavior = false;
            this.objectListViewConfigProbs.View = System.Windows.Forms.View.Details;
            this.objectListViewConfigProbs.VirtualMode = true;
            // 
            // olvColumnTypeConf
            // 
            this.olvColumnTypeConf.AspectName = "Type";
            this.olvColumnTypeConf.Text = "Type";
            // 
            // olvColumnObjectConf
            // 
            this.olvColumnObjectConf.AspectName = "Object";
            this.olvColumnObjectConf.Text = "Object";
            // 
            // olvColumnFunctionConf
            // 
            this.olvColumnFunctionConf.AspectName = "Function";
            this.olvColumnFunctionConf.Text = "Property / Field";
            // 
            // olvColumnDetailsConf
            // 
            this.olvColumnDetailsConf.AspectName = "Details";
            this.olvColumnDetailsConf.Text = "Details";
            // 
            // tabPageConfigChanges
            // 
            this.tabPageConfigChanges.Controls.Add(this.objectListViewAllChanges);
            this.tabPageConfigChanges.Controls.Add(this.label1);
            this.tabPageConfigChanges.Controls.Add(this.comboBoxUser);
            this.tabPageConfigChanges.Controls.Add(this.dateTimeChanges);
            this.tabPageConfigChanges.Controls.Add(this.labelLogin);
            this.tabPageConfigChanges.ImageIndex = 4;
            this.tabPageConfigChanges.Location = new System.Drawing.Point(4, 23);
            this.tabPageConfigChanges.Name = "tabPageConfigChanges";
            this.tabPageConfigChanges.Size = new System.Drawing.Size(1031, 515);
            this.tabPageConfigChanges.TabIndex = 4;
            this.tabPageConfigChanges.Text = "Object Changes";
            this.tabPageConfigChanges.UseVisualStyleBackColor = true;
            // 
            // objectListViewAllChanges
            // 
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnObjectTypeChng);
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnNameChng);
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnModBy);
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnModDate);
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnCreatedBy);
            this.objectListViewAllChanges.AllColumns.Add(this.olvColumnCreatedDate);
            this.objectListViewAllChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListViewAllChanges.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.objectListViewAllChanges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnObjectTypeChng,
            this.olvColumnNameChng,
            this.olvColumnModBy,
            this.olvColumnModDate,
            this.olvColumnCreatedBy,
            this.olvColumnCreatedDate});
            this.objectListViewAllChanges.FullRowSelect = true;
            this.objectListViewAllChanges.GridLines = true;
            this.objectListViewAllChanges.Location = new System.Drawing.Point(5, 40);
            this.objectListViewAllChanges.MultiSelect = false;
            this.objectListViewAllChanges.Name = "objectListViewAllChanges";
            this.objectListViewAllChanges.Size = new System.Drawing.Size(1023, 475);
            this.objectListViewAllChanges.TabIndex = 18;
            this.objectListViewAllChanges.UseCompatibleStateImageBehavior = false;
            this.objectListViewAllChanges.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnObjectTypeChng
            // 
            this.olvColumnObjectTypeChng.AspectName = "ObjectType";
            this.olvColumnObjectTypeChng.Text = "Type";
            // 
            // olvColumnNameChng
            // 
            this.olvColumnNameChng.AspectName = "Name";
            this.olvColumnNameChng.Text = "Name";
            // 
            // olvColumnModBy
            // 
            this.olvColumnModBy.AspectName = "ModBy";
            this.olvColumnModBy.Text = "Modified By";
            // 
            // olvColumnModDate
            // 
            this.olvColumnModDate.AspectName = "ModDate";
            this.olvColumnModDate.Text = "Modified";
            // 
            // olvColumnCreatedBy
            // 
            this.olvColumnCreatedBy.AspectName = "CreatedBy";
            this.olvColumnCreatedBy.Text = "Created By";
            // 
            // olvColumnCreatedDate
            // 
            this.olvColumnCreatedDate.AspectName = "CreatedDate";
            this.olvColumnCreatedDate.Text = "Created";
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "REPOS_document_search_16.png");
            this.imageListTabs.Images.SetKeyName(1, "REPOS_document_text_error_16.png");
            this.imageListTabs.Images.SetKeyName(2, "REPOS_document_text_info_16.png");
            this.imageListTabs.Images.SetKeyName(3, "REPOS_gear_error_16.png");
            this.imageListTabs.Images.SetKeyName(4, "REPOS_gear_warn_16.png");
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // FormReposAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 709);
            this.Controls.Add(this.automaticUpdater);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.ribbonMain);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(771, 579);
            this.Name = "FormReposAnalyser";
            this.Text = "Siebel Repository Analyser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReposAnalyser_FormClosed);
            this.Load += new System.EventHandler(this.FormReposAnalyser_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageScriptProblems.ResumeLayout(false);
            this.tabPageScriptProblems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewScriptProbs)).EndInit();
            this.tabPageScriptCount.ResumeLayout(false);
            this.tabPageScriptCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewScriptCount)).EndInit();
            this.tabPageScriptSearc.ResumeLayout(false);
            this.tabPageScriptSearc.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewSearchResults)).EndInit();
            this.tabPageConfigProblems.ResumeLayout(false);
            this.tabPageConfigProblems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewConfigProbs)).EndInit();
            this.tabPageConfigChanges.ResumeLayout(false);
            this.tabPageConfigChanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewAllChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textTotalLines;
        private System.Windows.Forms.DateTimePicker dateTimeChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelRefVer;
        private System.Windows.Forms.ComboBox comboBoxVer;
        private System.Windows.Forms.Label labelVanillaLines;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnStatus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonExportScriptProblemsXML;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonConnect;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCustLines;
        private System.Windows.Forms.TextBox textBoxVanLines;
        private System.Windows.Forms.Label labelCustomLines;
        private System.Windows.Forms.Label labelVanLines;
        private System.Windows.Forms.Label labelTotalLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScriptNameFilter;
        private System.Windows.Forms.ComboBox comboBoxScriptUserFilter;
        private System.Windows.Forms.ComboBox comboBoxScriptCountUserFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScriptCountObjFilter;
        private System.Windows.Forms.ComboBox comboBoxConfigUserFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConfigNameFilter;
        private System.Windows.Forms.ToolTip toolTipMain;
        private wyDay.Controls.AutomaticUpdater automaticUpdater;
        private System.Windows.Forms.Ribbon ribbonMain;
        private System.Windows.Forms.RibbonTab ribbonTabMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageScriptProblems;
        private System.Windows.Forms.TabPage tabPageScriptCount;
        private System.Windows.Forms.TabPage tabPageScriptSearc;
        private System.Windows.Forms.TabPage tabPageConfigProblems;
        private System.Windows.Forms.TabPage tabPageConfigChanges;
        private System.Windows.Forms.RibbonPanel ribbonPanelHome;
        private System.Windows.Forms.RibbonButton ribbonButtonConnect;
        private System.Windows.Forms.RibbonPanel ribbonPanelHelp;
        private System.Windows.Forms.RibbonButton ribbonButtonHelp;
        private System.Windows.Forms.RibbonButton ribbonButtonAbout;
        private System.Windows.Forms.RibbonButton ribbonButtonUpdate;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemExit;
        private System.Windows.Forms.RibbonButton ribbonButtonDisconnect;
        private System.Windows.Forms.TextBox textBoxScriptNameFilter;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewScriptProbs;
        private BrightIdeasSoftware.FastObjectListView objectListViewConfigProbs;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnCategory;
        private BrightIdeasSoftware.OLVColumn olvColumnObject;
        private BrightIdeasSoftware.OLVColumn olvColumnFunction;
        private BrightIdeasSoftware.OLVColumn olvColumnLine;
        private BrightIdeasSoftware.OLVColumn olvColumnDetails;
        private BrightIdeasSoftware.OLVColumn olvColumnTypeConf;
        private BrightIdeasSoftware.OLVColumn olvColumnObjectConf;
        private BrightIdeasSoftware.OLVColumn olvColumnFunctionConf;
        private BrightIdeasSoftware.OLVColumn olvColumnDetailsConf;
        private BrightIdeasSoftware.ObjectListView objectListViewAllChanges;
        private BrightIdeasSoftware.OLVColumn olvColumnObjectTypeChng;
        private BrightIdeasSoftware.OLVColumn olvColumnNameChng;
        private BrightIdeasSoftware.OLVColumn olvColumnModBy;
        private BrightIdeasSoftware.OLVColumn olvColumnModDate;
        private BrightIdeasSoftware.OLVColumn olvColumnCreatedBy;
        private BrightIdeasSoftware.OLVColumn olvColumnCreatedDate;
        private System.Windows.Forms.RibbonButton ribbonButtonSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanelExport;
        private System.Windows.Forms.RibbonButton ribbonButtonExportCSV;
        private System.Windows.Forms.RibbonButton ribbonButtonExportHTML;
        private System.Windows.Forms.RibbonPanel ribbonPanelControl;
        private System.Windows.Forms.RibbonButton ribbonButtonGo;
        private System.Windows.Forms.RibbonButton ribbonButtonStop;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.RibbonButton ribbonButtonUpdateSmall;
        private BrightIdeasSoftware.ObjectListView objectListViewScriptCount;
        private BrightIdeasSoftware.OLVColumn olvColumnObjectType;
        private BrightIdeasSoftware.OLVColumn olvColumnServerScript;
        private BrightIdeasSoftware.OLVColumn olvColumnBrowserScript;
        private BrightIdeasSoftware.OLVColumn olvColumnTotalScript;
        private BrightIdeasSoftware.OLVColumn olvColumnCustomScript;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.RibbonButton ribbonButtonReport;
        private BrightIdeasSoftware.ObjectListView objectListViewSearchResults;
        private BrightIdeasSoftware.OLVColumn olvColumnObjType;
        private BrightIdeasSoftware.OLVColumn olvColumnObjName;
        private BrightIdeasSoftware.OLVColumn olvColumnScriptType;
        private BrightIdeasSoftware.OLVColumn olvColumnMethodName;
        private BrightIdeasSoftware.OLVColumn olvColumnLineNum;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
        private ScintillaNET.Scintilla scintillaScriptSearch;
        private System.Windows.Forms.RibbonPanel ribbonPanelView;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle;
        private System.Windows.Forms.RibbonButton ribbonButtonTheme;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2007;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2010;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2013;
        private System.Windows.Forms.RibbonButton ribbonButtonNormal;
        private System.Windows.Forms.RibbonButton ribbonButtonBlue;
        private System.Windows.Forms.RibbonButton ribbonButtonBlack;
        private System.Windows.Forms.RibbonButton ribbonButtonGreen;
        private System.Windows.Forms.RibbonButton ribbonButtonPurple;
        private System.Windows.Forms.RibbonButton ribbonButtonJellyBelly;
        private System.Windows.Forms.RibbonButton ribbonButtonHalloween;
    }
}

