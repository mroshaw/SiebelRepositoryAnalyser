#region

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Media;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs;
using SiebelReposAnalyser.Properties;
using SiebelRepositoryWrapper;
using System.Drawing;
using ScintillaNET;

#endregion

namespace SiebelReposAnalyser
{
    public partial class FormReposAnalyser : Form
    {
        public int OsVersion;
        private List<SiebelUsers> _allSiebelUsers;

        private string _configChangedFromDateFilter;
        private string _configChangedUserNameFilter;
        private string _configObjectNameFilter;
        private string _configUserNameFilter;
        private Boolean _connected;
        private int _currentTab;

        private string _sciptVersion;
        private string _scriptCountObjectNameFilter;
        private string _scriptCountUserNameFilter;
        private string _scriptObjectNameFilter;
        private string _scriptUserNameFilter;

        private Settings _settings;
        private SiebelRepository _siebelApp;

        // Ribbon
        private int _orbStyleIndex;
        private String _orbStyleName;
        private RibbonTheme _orbTheme;
        private int _orbThemeIndex;
        private String _orbThemeName;
        private RibbonOrbStyle _orbStyle;

        public FormReposAnalyser()
        {
            InitializeComponent();
            SetOsVersion();
            InitScintilla();
            comboBoxVer.SelectedIndex = 0;

            // Load Settings
            LoadSettings();

            // Apply defaults
            SetDefaults();

            // Update control state
            SetControlState();
        }

        /// <summary>
        ///     Set default values on initialisation
        /// </summary>
        private void SetDefaults()
        {
            _siebelApp = new SiebelRepository(_settings.ConnReposName);
            _connected = false;
            _currentTab = 0;

            // Config Changes
            _configChangedUserNameFilter = "All";
            _configChangedFromDateFilter = new DateTime().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     Sets the OS version so that we can display appropriate dialogs
        /// </summary>
        private void SetOsVersion()
        {
            // Get Operating system information
            OperatingSystem os = Environment.OSVersion;

            //Get version information about the os
            Version vs = os.Version;

            // Set the Major OS version so that we can enable 'nice' error display for Vista / 7 / 2008
            OsVersion = vs.Major;
        }

        /// <summary>
        ///     Get settings from the Settings XML
        /// </summary>
        private void LoadSettings()
        {
            // Determine whether we need to migrate the settings
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
            }

            // Load Orb Style
            _orbStyle = Settings.Default.OfficeStyle;
            _orbStyleIndex = Settings.Default.OfficeStyleIndex;

            ribbonMain.OrbStyle = _orbStyle;
            ribbonButtonStyle.DropDownItems[_orbStyleIndex].Checked = true;

            _orbTheme = Settings.Default.ThemeColour;
            _orbThemeIndex = Settings.Default.ThemeIndex;

            Theme.ThemeColor = _orbTheme;
            ribbonMain.Refresh();
            ribbonButtonTheme.DropDownItems[_orbThemeIndex].Checked = true;

            _settings = Settings.Default;

        }

        /// <summary>
        ///     Load settings from the Settings XML
        /// </summary>
        private void SaveSettings()
        {
            if (!Settings.Default.ConnectRemPassword)
            {
                Settings.Default.ConnectPassword = "";
            }

            // Save the Office Style
            Settings.Default.OfficeStyle = _orbStyle;
            Settings.Default.OfficeStyleIndex = _orbStyleIndex;

            // Save the Ribbon Theme
            Settings.Default.ThemeColour = _orbTheme;
            Settings.Default.ThemeIndex = _orbThemeIndex;

            _settings = Settings.Default;
            _settings.Save();
        }

        /// <summary>
        ///     Toggle controls based on connection to Siebel
        /// </summary>
        private void SetControlState()
        {
            // Toggle controls
            ribbonButtonConnect.Enabled = !_connected;
            ribbonButtonDisconnect.Enabled = _connected;
            ribbonButtonGo.Enabled = _connected;
            if (_connected)
            {
                toolStripStatusLabelConnStatus.Text = Properties.Resources.ToggleControls_Connected;
                toolStripSplitButtonConnect.Image = Properties.Resources.REPOS_computer_ok_16;
            }
            else
            {
                toolStripStatusLabelConnStatus.Text = Properties.Resources.ToggleControls_Not_Connected;
                toolStripSplitButtonConnect.Image = Properties.Resources.REPOS_computer_delete2_16;
            }
        }

        private void InitScintilla()
        {
            scintillaScriptSearch.Margins[0].Width = 32;
             scintillaScriptSearch.Lexer = Lexer.Cpp;

            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            scintillaScriptSearch.StyleResetDefault();
            scintillaScriptSearch.Styles[Style.Default].Font = "Courier";
            scintillaScriptSearch.Styles[Style.Default].Size = 7;
            scintillaScriptSearch.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            scintillaScriptSearch.Styles[Style.Cpp.Default].ForeColor = Color.Silver;
            scintillaScriptSearch.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintillaScriptSearch.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintillaScriptSearch.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
            scintillaScriptSearch.Styles[Style.Cpp.Number].ForeColor = Color.Olive;
            scintillaScriptSearch.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            scintillaScriptSearch.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
            scintillaScriptSearch.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintillaScriptSearch.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintillaScriptSearch.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintillaScriptSearch.Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
            scintillaScriptSearch.Styles[Style.Cpp.Operator].ForeColor = Color.Purple;
            scintillaScriptSearch.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Maroon;

            String keywords = "abstract arguments boolean break byte case catch char class* const continue debugger default delete do double else enum* eval export* extends* false final finally float for function goto if implements import* in instanceof int interface let long native new null package private protected public return short static super* switch synchronized this throw throws transient true try typeof var void volatile while with yield";
            keywords += " TheApplication SetSharedGlobal SetProfileAttr ClearToQuery SetViewMode ActivateField SetSearchSpec ExecuteQuery FirstRecord NextRecord GetBusObject GetBusComp RaiseErrorText InvokeMethod";

            scintillaScriptSearch.SetKeywords(0, keywords);

            scintillaScriptSearch.SetKeywords(1, "var chars bool BusObject BusComp ");
        }

        /// <summary>
        ///     Handle the Siebel login event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LogOn();
        }

        private void PopulateUserControl(ComboBox target)
        {
            foreach (SiebelUsers user in _allSiebelUsers)
            {
                target.Items.Add(user.Login);
            }
        }

        private void LogOn()
        {
            // Set wait pointer
            using (new HourGlass())
            {
                toolStripStatusLabel.Text = Properties.Resources.Logging_In;
                Application.DoEvents();

                // Login with the corresponding criteria
                try
                {
                    if (_settings.ConnectServerType)
                    {
                        // Get connect string and user details and connected
                        _siebelApp.Connect(_settings.ConnectUser,
                            _settings.ConnectPassword, _settings.ConnectHost,
                            _settings.ConnectEnterprise, _settings.ConnectOM);
                    }
                    else
                    {
                        _siebelApp.Connect();
                    }
                    _connected = _siebelApp.IsConnected();
                    // Check connection
                    if (_connected)
                    {
                        // Toggle the control
                        SetControlState();

                        if (!_settings.ConnectPrePropUsers) return;
                        // Obtain list of employees
                        toolStripStatusLabel.Text = Properties.Resources.Preloading_Siebel_Users;
                        Application.DoEvents();
                        _allSiebelUsers = new List<SiebelUsers>();
                        _siebelApp.GetAllUsers(_allSiebelUsers);
                        PopulateUserControl(comboBoxUser);
                        PopulateUserControl(comboBoxScriptUserFilter);
                        PopulateUserControl(comboBoxScriptCountUserFilter);
                    }
                    else
                    {
                        ShowError("Siebel Connection Error",
                            "A problem has occurred connecting to Siebel. Please check the connect string, username and password parameters",
                            "");
                    }
                }
                catch (ReposAnalyserException e1)
                {
                    ShowError("Siebel Connection Error",
                        "A problem has occurred connecting to Siebel. Please check the connect string, username and password parameters",
                        e1.ToString());
                }
                catch (Exception e2)
                {
                    ShowError("Unexpected Connection Error", "An unexpected error has occurred",
                        e2.ToString());
                }
                finally
                {
                    // Set wait pointer
                    toolStripStatusLabel.Text = Properties.Resources.Ready;
                    Application.DoEvents();
                }
            }
        }

        /// <summary>
        ///     Display error dialog via the TaskDialog control
        /// </summary>
        /// <param name="instrText"></param>
        /// <param name="errText"></param>
        /// <param name="exceptionText"></param>
        private void ShowError(string instrText, string errText, string exceptionText)
        {
            if (OsVersion >= 6)
            {
                TaskDialog dialog = new TaskDialog
                {
                    Caption = Properties.Resources.Error,
                    InstructionText = instrText,
                    Icon = TaskDialogStandardIcon.Error,
                    Cancelable = false,
                    Text = errText,
                    DetailsCollapsedLabel = "Show Error Details",
                    DetailsExpandedLabel = "Hide Error Details",
                    DetailsExpandedText = exceptionText
                };
                SystemSounds.Exclamation.Play();
                dialog.Show();
            }
            else
            {
                MessageBox.Show(errText + Environment.NewLine + Environment.NewLine + exceptionText,
                    Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        ///     Handle the logout event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogOff();
        }

        private void LogOff()
        {
            using (new HourGlass())
            {
                // Log out of the Siebel application

                Cursor.Current = Cursors.WaitCursor;
                toolStripStatusLabel.Text = Properties.Resources.Logging_out;
                Application.DoEvents();

                try
                {
                    // Log out of the session
                    _siebelApp.Disconnect();
                    _connected = false;
                    // Toggle controls to prevent use
                    SetControlState();
                }
                catch (ReposAnalyserException e1)
                {
                    ShowError("Siebel Logoff Error", "A problem has occurred closing the Siebel connection",
                        e1.ToString());
                }
                catch (Exception e2)
                {
                    ShowError("Unexcpeted Error", "An unexpected error has occurred",
                        e2.ToString());
                }
                finally
                {
                    toolStripStatusLabel.Text = Properties.Resources.Ready;
                    Application.DoEvents();
                }
            }
        }

        private void FindScriptCounts()
        {
            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = Properties.Resources.Counting_Code_Lines;
            Application.DoEvents();
            try
            {
                // Get codelines object
                SiebelScriptLines codeLines = new SiebelScriptLines(_sciptVersion);

                // Apply settings
                ScriptSettings settings = new ScriptSettings
                {
                    CountObjNameFilter = _scriptCountObjectNameFilter,
                    CountUserNameFIlter = _scriptCountUserNameFilter,
                    Version = _sciptVersion,
                    IgnoreInactive = Settings.Default.ScriptIgnoreInactive
                };
                _siebelApp.GetCodeLineCount(codeLines, settings, UpdateStatusBar);
                PopulateCodeLine(codeLines);
            }
            catch (Exception e3)
            {
                ShowError("Siebel Error", "A problem has occurred while counting code lines",
                    e3.ToString());
            }
            finally
            {
                // Set wait pointer
                Cursor.Current = Cursors.Default;
                toolStripStatusLabel.Text = Properties.Resources.Ready;
                Application.DoEvents();
            }
        }

        /// <summary>
        ///     Go through the object types and calculate the number of lines of code
        ///     for both Browser and Server script
        /// </summary>
        /// <returns></returns>
        private void PopulateCodeLine(SiebelScriptLines codeLines)
        {
            // Populate result grid for Application

            int totalAppLines = codeLines.ApplicationBsLine + codeLines.ApplicationSsLine;
            int totalAdjAppLines = codeLines.AdjustApplicationBsLine + codeLines.AdjustApplicationSsLine;

            int totalAppletLines = codeLines.AppletBsLine + codeLines.AppletSsLine;
            int totalAdjAppletLines = codeLines.AdjustAppletBsLine + codeLines.AdjustAppletSsLine;

            int totalBcLines = codeLines.BcbsLine + codeLines.BcssLine;
            int totalAdjBcLines = codeLines.AdjustBcbsLine + codeLines.AdjustBcssLine;

            int totalBsLines = codeLines.BsbsLine + codeLines.BsssLine;
            int totalAdjBsLines = codeLines.AdjustBsbsLine + codeLines.AdjustBsssLine;

            int totalServerLines = codeLines.ApplicationSsLine + codeLines.AppletSsLine + codeLines.BcssLine +
                                   codeLines.BsssLine;
            int totalBrowserLines = codeLines.ApplicationBsLine + codeLines.AppletBsLine + codeLines.BcbsLine +
                                    codeLines.BsbsLine;

            int totalAdjustServerLines = codeLines.AdjustApplicationSsLine + codeLines.AdjustAppletSsLine +
                                         codeLines.AdjustBcssLine + codeLines.AdjustBsssLine;
            int totalAdjustBrowserLines = codeLines.AdjustApplicationBsLine + codeLines.AdjustAppletBsLine +
                                          codeLines.AdjustBcbsLine + codeLines.AdjustBsbsLine;

            List<ScriptCountResult> results = new List<ScriptCountResult>
            {
                new ScriptCountResult("Application",
                    codeLines.ApplicationSsLine.ToString(CultureInfo.InvariantCulture) + " (" +
                    codeLines.AdjustApplicationSsLine.ToString(CultureInfo.InvariantCulture) + ")",
                    codeLines.ApplicationBsLine.ToString(CultureInfo.InvariantCulture) + " (" +
                    codeLines.AdjustApplicationBsLine.ToString(CultureInfo.InvariantCulture) + ")",
                    totalAppLines.ToString(CultureInfo.InvariantCulture) + " (" +
                    totalAdjAppLines.ToString(CultureInfo.InvariantCulture) + ")",
                    (totalAppLines - totalAdjAppLines).ToString(CultureInfo.InvariantCulture)),
                new ScriptCountResult("Applet",
                    codeLines.AppletSsLine.ToString(CultureInfo.InvariantCulture) + " (" +
                    codeLines.AdjustAppletSsLine.ToString(CultureInfo.InvariantCulture) + ")",
                    codeLines.AppletBsLine.ToString(CultureInfo.InvariantCulture) + " (" +
                    codeLines.AdjustAppletBsLine.ToString(CultureInfo.InvariantCulture) + ")",
                    totalAppletLines.ToString(CultureInfo.InvariantCulture) + " (" +
                    totalAdjAppletLines.ToString(CultureInfo.InvariantCulture) + ")",
                    (totalAppletLines - totalAdjAppletLines).ToString(CultureInfo.InvariantCulture))
            };

            // Populate result grid for Applet
            Application.DoEvents();

            // Populate result grid for Bus Comp
            results.Add(new ScriptCountResult("Business Component",
                codeLines.BcssLine.ToString(CultureInfo.InvariantCulture) + " (" +
                codeLines.AdjustBcssLine.ToString(CultureInfo.InvariantCulture) + ")",
                codeLines.BcbsLine.ToString(CultureInfo.InvariantCulture) + " (" +
                codeLines.AdjustBcbsLine.ToString(CultureInfo.InvariantCulture) + ")",
                totalBcLines.ToString(CultureInfo.InvariantCulture) + " (" +
                totalAdjBcLines.ToString(CultureInfo.InvariantCulture) + ")",
                (totalBcLines - totalAdjBcLines).ToString(CultureInfo.InvariantCulture)));
            Application.DoEvents();

            // Populate result grid for Bus Service
            results.Add(new ScriptCountResult("Business Service",
                codeLines.BsssLine.ToString(CultureInfo.InvariantCulture) + " (" +
                codeLines.AdjustBsssLine.ToString(CultureInfo.InvariantCulture) + ")",
                codeLines.BsbsLine.ToString(CultureInfo.InvariantCulture) + " (" + codeLines.AdjustBsbsLine + ")",
                totalBsLines + " (" + totalAdjBsLines.ToString(CultureInfo.InvariantCulture) + ")",
                (totalBsLines - totalAdjBsLines).ToString(CultureInfo.InvariantCulture)));
            Application.DoEvents();

            // Populate overall results
            results.Add(new ScriptCountResult("Total",
                totalServerLines.ToString(CultureInfo.InvariantCulture) + " (" +
                totalAdjustServerLines.ToString(CultureInfo.InvariantCulture) + ")",
                totalBrowserLines.ToString(CultureInfo.InvariantCulture) + " (" +
                totalAdjustBrowserLines.ToString(CultureInfo.InvariantCulture) + ")",
                codeLines.TotalLine.ToString(CultureInfo.InvariantCulture) + " (" +
                codeLines.AdjustTotalLine.ToString(CultureInfo.InvariantCulture) + ")",
                (codeLines.TotalLine - codeLines.AdjustTotalLine).ToString(CultureInfo.InvariantCulture)));
            Application.DoEvents();

            // Populate custom results
            results.Add(new ScriptCountResult("Custom", (totalServerLines - totalAdjustServerLines).ToString(CultureInfo.InvariantCulture),
                (totalBrowserLines - totalAdjustBrowserLines).ToString(CultureInfo.InvariantCulture),
                (codeLines.TotalLine - codeLines.AdjustTotalLine).ToString(CultureInfo.InvariantCulture), ""));
            Application.DoEvents();

            // Populate the OLV
            objectListViewScriptCount.Objects = results;

            // Add to totals
            textTotalLines.Text = codeLines.TotalLine.ToString(CultureInfo.InvariantCulture);
            textBoxVanLines.Text = codeLines.AdjustTotalLine.ToString(CultureInfo.InvariantCulture);
            textBoxCustLines.Text =
                (codeLines.TotalLine - codeLines.AdjustTotalLine).ToString(CultureInfo.InvariantCulture);
            Application.DoEvents();
        }

        private void FindChanges()
        {
            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = Properties.Resources.Showing_Object_Changes;
            Application.DoEvents();

            // Create new list of items for the tree view
            try
            {
                List<SiebelReposChange> changeList = _siebelApp.GetAllChanges(_configChangedFromDateFilter,
                    _configChangedUserNameFilter, UpdateStatusBar);

                // Populate the Tree View with our results
                objectListViewAllChanges.Objects = changeList;
                foreach (OLVColumn column in objectListViewAllChanges.Columns)
                {
                    column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (Exception e2)
            {
                ShowError("Siebel Error", "An error occurred while parsing the repository",
                    e2.ToString());
            }
            finally
            {
                // Set wait pointer
                Cursor.Current = Cursors.Default;
                toolStripStatusLabel.Text = Properties.Resources.Ready;
                Application.DoEvents();
            }
        }

        /// <summary>
        ///     Make sure that the Siebel Connection is closed when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormReposAnalyser_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the Siebel connection, if it's open
            if (_siebelApp.IsConnected())
            {
                _siebelApp.Disconnect();
            }

            // Save settings to registry
            SaveSettings();
        }

        private void FindScriptProbs()
        {
            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = Properties.Resources.Analysing_objects;
            Application.DoEvents();

            // Get problems
            List<SiebelProblem> allProblems = new List<SiebelProblem>();
            ScriptSettings settings = new ScriptSettings
            {
                CheckDestruction = Settings.Default.ScriptCheckDestruction,
                CheckForwardBackward = Settings.Default.ScriptCheckForwardBackward,
                CheckNoComments = Settings.Default.ScriptCheckNoComments,
                CheckRetInFinally = Settings.Default.ScriptCheckFinally,
                UserFilter = _scriptUserNameFilter,
                ObjNameFilter = _scriptObjectNameFilter,
                IgnoreInactive = Settings.Default.ScriptIgnoreInactive
            };

            _siebelApp.GetCodeProblems(allProblems, settings, UpdateStatusBar);

            // Set wait pointer
            toolStripStatusLabel.Text = Properties.Resources.Building_list;
            Application.DoEvents();

            // Populate Object List View
            fastObjectListViewScriptProbs.Objects = allProblems;
            foreach (OLVColumn column in fastObjectListViewScriptProbs.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            // Set wait pointer
            Cursor.Current = Cursors.Default;
            toolStripStatusLabel.Text = Properties.Resources.Ready;
            Application.DoEvents();
        }

        public String GetCsvFileName()
        {
            saveFileDialog.Title = Properties.Resources.Save_to_CSV_file;
            saveFileDialog.Filter = Properties.Resources.CSV_File;
            saveFileDialog.ShowDialog();
            String fileName = saveFileDialog.FileName;
            return fileName;
        }

        public String GetHtmlFileName()
        {
            saveFileDialog.Title = Properties.Resources.Save_to_HTML_file;
            saveFileDialog.Filter = Properties.Resources.HTML_File;
            saveFileDialog.ShowDialog();
            String fileName = saveFileDialog.FileName;
            return fileName;
        }

        public void ExportOlvToCsv(FastObjectListView olv)
        {
            String fileName = GetCsvFileName();
            if (fileName != "")
            {
                FileUtils.ExportFOlvToCsv(olv, fileName);
            }
        }

        public void ExportOlvToHtml(FastObjectListView olv)
        {
            String fileName = GetHtmlFileName();
            if (fileName != "")
            {
                FileUtils.ExportFOlvToHtml(olv, fileName);
            }
        }

        public void ExportOlvToCsv(ObjectListView olv)
        {
            String fileName = GetCsvFileName();
            if (fileName != "")
            {
                FileUtils.ExportOlvToCsv(olv, fileName);
            }
        }

        public void ExportOlvToHtml(ObjectListView olv)
        {
            String fileName = GetHtmlFileName();
            if (fileName != "")
            {
                FileUtils.ExportOlvToHtml(olv, fileName);
            }
        }

        public void ExportOlvToReport(FastObjectListView olv)
        {
            ListViewPrinter lvp = new ListViewPrinter {ListView = olv};
            lvp.PrintPreview();
        }

        public void ExportOlvToReport(ObjectListView olv)
        {
            ListViewPrinter lvp = new ListViewPrinter {ListView = olv};
            lvp.PrintPreview();
        }

        private void FindScriptSearch()
        {
            // Get search term
            string searchTerm = textBoxSearch.Text;
            Boolean ignoreCase = checkBoxIgnoreCase.Checked;
            if (searchTerm == "") return;
            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = Properties.Resources.Analysing_objects;
            Application.DoEvents();

            // Get search results
            List<SearchResults> allResults = new List<SearchResults>();
            _siebelApp.SearchScript(allResults, searchTerm, UpdateStatusBar, ignoreCase);

            // Set wait pointer
            toolStripStatusLabel.Text = Properties.Resources.Building_list;
            Application.DoEvents();

            PopulateSearchTree(allResults);

            // Set wait pointer
            Cursor.Current = Cursors.Default;
            toolStripStatusLabel.Text = Properties.Resources.Ready;
            Application.DoEvents();
        }

        /// <summary>
        ///     Populate the search tree
        /// </summary>
        /// <param name="results"></param>
        private void PopulateSearchTree(List<SearchResults> results)
        {
            objectListViewSearchResults.Objects = results;
            foreach (OLVColumn column in objectListViewSearchResults.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            _configChangedUserNameFilter = comboBoxUser.Text;
        }

        private void dateTimeChanges_ValueChanged(object sender, EventArgs e)
        {
            _configChangedFromDateFilter = dateTimeChanges.Text;
        }

        private void comboBoxScriptUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _scriptUserNameFilter = comboBoxScriptUserFilter.Text;
        }

        private void comboBoxScriptUserFilter_TextChanged(object sender, EventArgs e)
        {
            _scriptUserNameFilter = comboBoxScriptUserFilter.Text;
        }

        /// <summary>
        ///     Delegate function to allow the SiebelRepository Class to update the UI
        /// </summary>
        /// <param name="status"></param>
        public void UpdateStatusBar(string status)
        {
            toolStripStatusLabel.Text = status;
            Application.DoEvents();
        }

        private void textBoxScriptCountObjFilter_TextChanged(object sender, EventArgs e)
        {
            _scriptCountObjectNameFilter = textBoxScriptCountObjFilter.Text;
        }

        private void comboBoxScriptCountUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _scriptCountUserNameFilter = comboBoxScriptCountUserFilter.Text;
        }

        private void FindConfigProbs()
        {
            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = Properties.Resources.Analysing_objects;
            Application.DoEvents();

            // Get problems
            List<SiebelProblem> allProblems = new List<SiebelProblem>();
            ConfigSettings settings = new ConfigSettings
            {
                CheckForceActive = Settings.Default.ConfigCheckForceActive,
                UserFilter = _configUserNameFilter,
                NameFilter = _configObjectNameFilter,
                IgnoreInactive = Settings.Default.ConfigIgnoreInactive
            };

            _siebelApp.GetConfigProblems(allProblems, settings, UpdateStatusBar);

            // Set wait pointer
            toolStripStatusLabel.Text = Properties.Resources.Building_list;
            Application.DoEvents();

            // Build Object List Viw
            objectListViewConfigProbs.Objects = allProblems;
            foreach (OLVColumn column in objectListViewConfigProbs.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            // Set wait pointer
            Cursor.Current = Cursors.Default;
            toolStripStatusLabel.Text = Properties.Resources.Ready;
            Application.DoEvents();
        }

        private void textBoxConfigNameFilter_TextChanged(object sender, EventArgs e)
        {
            _configObjectNameFilter = textBoxConfigNameFilter.Text;
        }

        private void comboBoxConfigUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _configUserNameFilter = comboBoxConfigUserFilter.Text;
        }

        private void comboBoxVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sciptVersion = comboBoxVer.Text;
        }


        private void FormReposAnalyser_Load(object sender, EventArgs e)
        {
            try
            {
                Icon = Properties.Resources.REPOS_application_find;
            }
            catch (Exception)
            {
                // this.Icon = Properties.Resources.App_Icon_16;
            }
        }

        private void ribbonButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings { StartPosition = FormStartPosition.CenterParent };
            settings.ShowDialog();
        }

        private void ribbonButtonConnect_Click(object sender, EventArgs e)
        {
            LogOn();
        }

        private void ribbonButtonDisconnect_Click(object sender, EventArgs e)
        {
            LogOff();
        }

        private void ribbonButtonAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private static void ShowAbout()
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void ribbonButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateApplication();
        }

        private void UpdateApplication()
        {
            automaticUpdater.ForceCheckForUpdate();
        }

        private void textBoxScriptNameFilter_TextChanged(object sender, EventArgs e)
        {
            _scriptObjectNameFilter = textBoxScriptNameFilter.Text;
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTab = tabControlMain.SelectedIndex;
        }

        private void ribbonButtonExportCSV_Click(object sender, EventArgs e)
        {
            ExportResults("CSV");
        }

        private void ribbonButtonExportHTML_Click(object sender, EventArgs e)
        {
            ExportResults("HTML");
        }

        private void ExportResults(String format)
        {
            if (_currentTab == 0 && format == "CSV")
            {
                ExportOlvToCsv(fastObjectListViewScriptProbs);
            }
            if (_currentTab == 0 && format == "HTML")
            {
                ExportOlvToHtml(fastObjectListViewScriptProbs);
            }
            if (_currentTab == 0 && format == "Report")
            {
                ExportOlvToReport(fastObjectListViewScriptProbs);
            }
            if (_currentTab == 1 && format == "CSV")
            {
                ExportOlvToCsv(objectListViewScriptCount);
            }
            if (_currentTab == 1 && format == "HTML")
            {
                ExportOlvToHtml(objectListViewScriptCount);
            }
            if (_currentTab == 1 && format == "Report")
            {
                ExportOlvToReport(objectListViewScriptCount);
            }
            if (_currentTab == 2 && format == "CSV")
            {
                ExportOlvToCsv(objectListViewSearchResults);
            }
            if (_currentTab == 2 && format == "HTML")
            {
                ExportOlvToHtml(objectListViewSearchResults);
            }
            if (_currentTab == 2 && format == "Report")
            {
                ExportOlvToReport(objectListViewSearchResults);
            }
            if (_currentTab == 3 && format == "CSV")
            {
                ExportOlvToCsv(objectListViewConfigProbs);
            }
            if (_currentTab == 3 && format == "HTML")
            {
                ExportOlvToHtml(objectListViewConfigProbs);
            }
            if (_currentTab == 3 && format == "Report")
            {
                ExportOlvToReport(objectListViewConfigProbs);
            }
            if (_currentTab == 4 && format == "CSV")
            {
                ExportOlvToCsv(objectListViewAllChanges);
            }
            if (_currentTab == 4 && format == "HTML")
            {
                ExportOlvToHtml(objectListViewAllChanges);
            }
            if (_currentTab == 4 && format == "Report")
            {
                ExportOlvToReport(objectListViewAllChanges);
            }
        }

        private void ribbonButtonGo_Click(object sender, EventArgs e)
        {
            // ribbonButtonGo.Enabled = false;
            // ribbonButtonStop.Enabled = true;
            // _worker = new BackgroundWorker();
            // _worker.DoWork += new DoWorkEventHandler(DoWork);
            // _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerCompleted);
            // _worker.WorkerSupportsCancellation = true;

            // _worker.RunWorkerAsync();
            DoWork();
        }

        private void DoWork()
        {
            toolStripProgressBar.MarqueeAnimationSpeed = 100;

            if (_currentTab == 0)
            {
                FindScriptProbs();
            }
            if (_currentTab == 1)
            {
                FindScriptCounts();
            }
            if (_currentTab == 2)
            {
                FindScriptSearch();
            }
            if (_currentTab == 3)
            {
                FindConfigProbs();
            }
            if (_currentTab == 4)
            {
                FindChanges();
            }
            toolStripProgressBar.MarqueeAnimationSpeed = 0;
        }

        private void ribbonButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.siebel-tech.com/forums/forum/siebel-store-support/product-support/siebel-repository-analyser/");
        }

        private void ribbonButtonUpdateSmall_Click(object sender, EventArgs e)
        {
            UpdateApplication();

        }

        private void ribbonButtonReport_Click(object sender, EventArgs e)
        {
            ExportResults("Report");
        }

        private void objectListViewSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView olv = (ObjectListView)sender;
            SearchResults searchResults = (SearchResults)olv.SelectedObject;
            if (searchResults != null)
            {
                // Populate the text boxes with appropriate record info data
                scintillaScriptSearch.Text = searchResults.ScriptCode;
                int lineNum = searchResults.LineNum;
                // Move the cursor to the line with the search term
                // Set the selection start and end position
                scintillaScriptSearch.Lines[lineNum - 1].Goto();
                int position = scintillaScriptSearch.CurrentPosition;
                scintillaScriptSearch.SetSelection(position, position + scintillaScriptSearch.Lines[lineNum - 1].Length);
                scintillaScriptSearch.Focus();
            }
        }

        private void splitContainerMain_Paint(object sender, PaintEventArgs e)
        {
            SplitContainer control = sender as SplitContainer;
            if (control == null) return;

            // Paint the three dots'
            Point[] points = new Point[3];
            int w = control.Width;
            int h = control.Height;
            int d = control.SplitterDistance;
            int sW = control.SplitterWidth;

            // Calculate the position of the points
            if (control.Orientation == Orientation.Horizontal)
            {
                points[0] = new Point((w / 2), d + (sW / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
            }
            else
            {
                points[0] = new Point(d + (sW / 2), (h / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
            }

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(SystemBrushes.ControlDark,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }
        }

        private void ribbonButtonStyle_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            _orbStyleName = e.Item.Text;
            switch (_orbStyleName)
            {
                case "Office 2007":
                    {
                        _orbStyle = RibbonOrbStyle.Office_2007;
                        _orbStyleIndex = 0;
                        break;
                    }
                case "Office 2010":
                    {
                        _orbStyle = RibbonOrbStyle.Office_2010;
                        _orbStyleIndex = 1;
                        break;
                    }
                default:
                    {
                        _orbStyle = RibbonOrbStyle.Office_2013;
                        _orbStyleIndex = 2;
                        break;
                    }
            }
            ribbonMain.OrbStyle = _orbStyle;
        }

        private void ribbonButtonTheme_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            _orbThemeName = e.Item.Text;
            switch (_orbThemeName)
            {
                case "Normal":
                    {
                        _orbTheme = RibbonTheme.Normal;
                        _orbThemeIndex = 0;
                        break;
                    }
                case "Blue":
                    {
                        _orbTheme = RibbonTheme.Blue;
                        _orbThemeIndex = 1;
                        break;
                    }
                case "Black":
                    {
                        _orbTheme = RibbonTheme.Black;
                        _orbThemeIndex = 2;
                        break;
                    }
                case "Green":
                    {
                        _orbTheme = RibbonTheme.Green;
                        _orbThemeIndex = 3;
                        break;
                    }
                case "Purple":
                    {
                        _orbTheme = RibbonTheme.Purple;
                        _orbThemeIndex = 4;
                        break;
                    }
                case "JellyBelly":
                    {
                        _orbTheme = RibbonTheme.JellyBelly;
                        _orbThemeIndex = 5;
                        break;
                    }
                default:
                    {
                        _orbTheme = RibbonTheme.Halloween;
                        _orbThemeIndex = 6;
                        break;
                    }
            }
            Theme.ThemeColor = _orbTheme;
            ribbonMain.Refresh();

        }
    }
}