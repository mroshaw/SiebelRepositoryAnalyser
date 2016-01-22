using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SiebelBusObjectInterfaces;
using Microsoft.WindowsAPICodePack.Dialogs;
using OliAboutBox;
using System.IO;
using System.Configuration;

namespace SiebelReposAnalyser
{
    public partial class FormReposAnalyser : Form
    {
        private SiebelApp siebelApp;
        private SiebelRepository siebelRep;
        private Settings settings;

        public FormReposAnalyser()
        {
            InitializeComponent();
            settings = new Settings();
            panelHome.BringToFront();
            comboBoxVer.SelectedIndex = 0;
            comboBoxConType.SelectedIndex = 0;

            siebelApp = new SiebelApp();

            toggleConnectControls(false);

            // Load defaults
            loadDefaults();

            siebelRep = new SiebelRepository("Siebel Repository");

            // Load the news page
            webBrowserNews.Navigate("http://www.mroshaw.co.uk/OllerenshawIT/files/RepAnalyser/News.htm");
            // webBrowserNews.Navigate(Application.StartupPath + @"\News.htm");          
        }

        private void loadDefaults()
        {
            settings.loadSettingsFromReg();

            comboBoxConType.SelectedIndex = settings.conType;
            textBoxCFG.Text = settings.conCFG;
            if (File.Exists(textBoxCFG.Text))
            {
                refreshDataSource(textBoxCFG.Text);
                try
                {
                    comboBoxDataSrc.SelectedIndex = settings.conDataSource;
                }
                catch { }
            }

            textBoxHost.Text = settings.conHost;
            textBoxEnt.Text = settings.conEnt;
            textBoxOM.Text = settings.conOM;
            textUser.Text = settings.conUser;
            textPass.Text = settings.conPassword;
            checkBoxRemPass.Checked = settings.conRemember;

            textBoxScriptNameFilter.Text = settings.scriptNameFilter;
            comboBoxScriptUpdatedByFilter.Text = settings.scriptUpdatedByFilter;
            comboBoxScriptUpdatedByFilter.SelectedIndex = 0;
            dateTimeScriptUpdatedFilter.Value = settings.scriptUpdatedFilter;
            comboBoxScriptCreatedByFilter.Text = settings.scriptCreatedByFilter;
            comboBoxScriptCreatedByFilter.SelectedIndex = 0;
            dateTimeScriptCreatedFilter.Value = settings.scriptCreatedFilter;

            textBoxConfigNameFilter.Text = settings.configNameFilter;
            comboBoxConfigUpdatedByFilter.Text = settings.configUpdatedByFilter;
            comboBoxUser.Text = settings.configUpdatedByFilter;
            dateTimeConfigUpdatedFilter.Value = settings.configUpdatedFilter;
            dateTimeChanges.Value = settings.configUpdatedFilter;
            comboBoxConfigCreatedByFilter.Text = settings.configCreatedByFilter;
            dateTimeConfigCreatedFilter.Value = settings.configCreatedFilter;

            dateTimeChanges.Value = settings.configUpdatedFilter;

            checkBoxConfigForceActive.Checked = settings.configForceActiveCheck;
            checkBoxConfigLinkSpec.Checked = settings.configLinkSpecCheck;

            checkBoxForwardBack.Checked = settings.scriptForBackCheck;
            checkBoxScriptDestruction.Checked = settings.scriptDestCheck;
            checkBoxScriptNoComm.Checked = settings.scriptNoCommCheck;
            checkBoxScriptVars.Checked = settings.scriptUnusedCheck;
            checkBoxScriptFinally.Checked = settings.scriptForBackCheck;
            checkBoxScriptIgnoreVan.Checked = settings.scriptIgnoreVanCheck;
        }

        private void saveDefaults()
        {
            settings.saveSettingsToReg();
        }

        /// <summary>
        /// Toggle controls based on connection to Siebel
        /// </summary>
        private void toggleControls()
        {
            // Toggle controls
            buttonLogout.Enabled = !buttonLogout.Enabled;
            buttonLogin.Enabled = !buttonLogin.Enabled;
            buttonCodeLines.Enabled = !buttonCodeLines.Enabled;
            buttonShowChanges.Enabled = !buttonShowChanges.Enabled;
            buttonFindScriptProbs.Enabled = !buttonFindScriptProbs.Enabled;
            if (siebelApp.Connected)
            {
                toolStripStatusLabelConnStatus.Text = "(Connected)";
                toolStripSplitButtonConnect.Image = SiebelReposAnalyser.Properties.Resources.Connected;
            }
            else
            {
                toolStripStatusLabelConnStatus.Text = "(Not Connected)";
                toolStripSplitButtonConnect.Image = SiebelReposAnalyser.Properties.Resources.Disconnected;
            }

        }

        /// <summary>
        /// Handle the Siebel login event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Set wait pointer
            using (new HourGlass())
            {
                toolStripStatusLabel.Text = "Logging in...";
                Application.DoEvents();

                // Get connect string and user details
                string userName = settings.conUser;
                string password = settings.conPassword;
                string host = settings.conHost;
                string ent = settings.conEnt;
                string om = settings.conOM;

                siebelApp = new SiebelApp(userName, password, host, ent, om);

                // Login with the corresponding criteria
                try
                {
                    // Connect to the Siebel App
                    siebelApp.Connect(true);
                    // Toggle the controls
                    toggleControls();

                    // Obtain list of employees
                    List<SiebelUsers> siebelUsers = new List<SiebelUsers>();
                    siebelApp.GetAllUsers(siebelUsers);
                    populateUserControl(comboBoxConfigUpdatedByFilter, siebelUsers);
                    populateUserControl(comboBoxScriptUpdatedByFilter, siebelUsers);
                    populateUserControl(comboBoxConfigCreatedByFilter, siebelUsers);
                    populateUserControl(comboBoxScriptCreatedByFilter, siebelUsers);
                    populateUserControl(comboBoxUser, siebelUsers);

                }
                catch (ReposAnalyserException e1)
                {
                    showError("Siebel Connection Error", "A problem has occurred connecting to Siebel. Please check the connect string, username and password parameters",
                        e1.ToString());
                }
                catch (Exception e2)
                {
                    showError("Unexpected Connection Error", "An unexpected error has occurred",
                        e2.ToString());
                }
                finally
                {
                    // Set wait pointer
                    toolStripStatusLabel.Text = "Ready";
                    Application.DoEvents();
                }
            }
        }

        private void populateUserControl(ComboBox target, List<SiebelUsers> siebelUsers)
        {
            foreach (SiebelUsers user in siebelUsers)
            {
                target.Items.Add(user.Login);
            }

        }

        /// <summary>
        /// Display error dialog via the TaskDialog control
        /// </summary>
        /// <param name="errText"></param>
        private void showError(string instrText, string errText, string exceptionText)
        {
            TaskDialog dialog = new TaskDialog();
            dialog.Caption = "Error!";
            dialog.InstructionText = instrText;
            dialog.Icon = TaskDialogStandardIcon.Error;
            dialog.Cancelable = false;
            dialog.Text = errText;
            dialog.DetailsCollapsedLabel = "Show Error Details";
            dialog.DetailsExpandedLabel = "Hide Error Details";
            dialog.DetailsExpandedText = exceptionText;
            System.Media.SystemSounds.Exclamation.Play();
            dialog.Show();
        }

        /// <summary>
        /// Handle the logout event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            using (new HourGlass())
            {
                // Log out of the Siebel application

                Cursor.Current = Cursors.WaitCursor;
                toolStripStatusLabel.Text = "Logging out...";
                Application.DoEvents();

                try
                {
                    // Log out of the session
                    siebelApp.Disconnect();
                    // Toggle controls to prevent use
                    toggleControls();
                }
                catch (ReposAnalyserException e1)
                {
                    showError("Siebel Logoff Error", "A problem has occurred closing the Siebel connection",
                        e1.ToString());
                }
                catch (Exception e2)
                {
                    showError("Unexcpeted Error", "An unexpected error has occurred",
                        e2.ToString());
                }
                finally
                {
                    toolStripStatusLabel.Text = "Ready";
                    Application.DoEvents();

                }
            }
        }

        /// <summary>
        /// Handle the button click event for the code line calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCodeLines_Click(object sender, EventArgs e)
        {

            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Counting code lines...";
            dataGridViewCodeLines.Rows.Clear();
            Application.DoEvents();
            try
            {
                SiebelScriptLines codeLines = new SiebelScriptLines(comboBoxVer.Text);

                siebelRep.GetCodeLineCount(siebelApp, codeLines);
                populateCodeLine(codeLines);

            }
            catch (Exception e3)
            {
                showError("Siebel Error", "A problem has occurred while counting code lines",
                    e3.ToString());
            }
            finally
            {
                // Set wait pointer
                Cursor.Current = Cursors.Default;
                toolStripStatusLabel.Text = "Ready";
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Go through the object types and calculate the number of lines of code
        /// for both Browser and Server script
        /// </summary>
        /// <returns></returns>
        private void populateCodeLine(SiebelScriptLines codeLines)
        {

            // Populate result grid for Application

            int totalAppLines = codeLines.ApplicationBSLine + codeLines.ApplicationSSLine;
            int totalAdjAppLines = codeLines.AdjustApplicationBSLine + codeLines.AdjustApplicationSSLine;

            int totalAppletLines = codeLines.AppletBSLine + codeLines.AppletSSLine;
            int totalAdjAppletLines = codeLines.AdjustAppletBSLine + codeLines.AdjustAppletSSLine;

            int totalBCLines = codeLines.BCBSLine + codeLines.BCSSLine;
            int totalAdjBCLines = codeLines.AdjustBCBSLine + codeLines.AdjustBCSSLine;

            int totalBSLines = codeLines.BSBSLine + codeLines.BSSSLine;
            int totalAdjBSLines = codeLines.AdjustBSBSLine + codeLines.AdjustBSSSLine;

            int totalServerLines = codeLines.ApplicationSSLine + codeLines.AppletSSLine + codeLines.BCSSLine + codeLines.BSSSLine;
            int totalBrowserLines = codeLines.ApplicationBSLine + codeLines.AppletBSLine + codeLines.BCBSLine + codeLines.BSBSLine;

            int totalAdjustServerLines = codeLines.AdjustApplicationSSLine + codeLines.AdjustAppletSSLine + codeLines.AdjustBCSSLine + codeLines.AdjustBSSSLine;
            int totalAdjustBrowserLines = codeLines.AdjustApplicationBSLine + codeLines.AdjustAppletBSLine + codeLines.AdjustBCBSLine + codeLines.AdjustBSBSLine;

            // Populate result grid for Application
            addRowToGrid("Application", codeLines.ApplicationBSLine.ToString() + " (" + codeLines.AdjustApplicationBSLine.ToString() + ")",
                codeLines.ApplicationSSLine.ToString() + " (" + codeLines.AdjustApplicationSSLine.ToString() + ")", 
                totalAppLines.ToString() + " (" + totalAdjAppLines.ToString() + ")", (totalAppLines - totalAdjAppLines).ToString());
            Application.DoEvents();

            // Populate result grid for Applet
            addRowToGrid("Applet", codeLines.AppletBSLine.ToString() + " (" + codeLines.AdjustAppletBSLine.ToString() + ")",
                codeLines.AppletSSLine.ToString() + " (" + codeLines.AdjustAppletSSLine.ToString() + ")", 
                totalAppletLines.ToString() + " (" + totalAdjAppletLines.ToString() + ")", (totalAppletLines - totalAdjAppletLines).ToString());
            Application.DoEvents();

            // Populate result grid for Bus Comp
            addRowToGrid("Bus Comp", codeLines.BCBSLine.ToString() + " (" + codeLines.AdjustBCBSLine.ToString() + ")",
                codeLines.BCSSLine.ToString() + " (" + codeLines.AdjustBCSSLine.ToString() + ")",
                totalBCLines.ToString() + " (" + totalAdjBCLines.ToString() + ")", (totalBCLines - totalAdjBCLines).ToString());
            Application.DoEvents();

            // Populate result grid for Bus Service
            addRowToGrid("Bus Serv", codeLines.BSBSLine.ToString() + " (" + codeLines.AdjustBSBSLine.ToString() + ")",
                codeLines.BSSSLine.ToString() + " (" + codeLines.AdjustBSSSLine.ToString() + ")",
                totalBSLines.ToString() + " (" + totalAdjBSLines.ToString() + ")", (totalBSLines - totalAdjBSLines).ToString());
            Application.DoEvents();

            // Populate overall results
            addRowToGrid("Total", totalServerLines.ToString() + " (" + totalAdjustServerLines.ToString() + ")",
                totalBrowserLines.ToString() + " (" + totalAdjustBrowserLines.ToString() + ")",
                codeLines.TotalLine.ToString() + " (" + codeLines.AdjustTotalLine.ToString() + ")", (codeLines.TotalLine - codeLines.AdjustTotalLine).ToString());
            Application.DoEvents();

            // Add to totals
            textTotalLines.Text = codeLines.TotalLine.ToString();
            textBoxVanLines.Text = codeLines.AdjustTotalLine.ToString();
            textBoxCustLines.Text = (codeLines.TotalLine - codeLines.AdjustTotalLine).ToString();
            Application.DoEvents();
        }

        /// <summary>
        /// Add a new row to our result grid
        /// </summary>
        /// <param name="type"></param>
        /// <param name="browseNum"></param>
        /// <param name="serverNum"></param>

        private void addRowToGrid(string type, string browseNum, string serverNum, string totalNum, string customNum)
        {
            int newRow = dataGridViewCodeLines.Rows.Add();

            dataGridViewCodeLines.Rows[newRow].Cells[0].Value = type;
            dataGridViewCodeLines.Rows[newRow].Cells[1].Value = serverNum;
            dataGridViewCodeLines.Rows[newRow].Cells[2].Value = browseNum;
            dataGridViewCodeLines.Rows[newRow].Cells[3].Value = totalNum;
            dataGridViewCodeLines.Rows[newRow].Cells[4].Value = customNum;

        }

        /// <summary>
        /// Show the changes made to the repository since the date specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowChanges_Click(object sender, EventArgs e)
        {

            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Showing object changes...";
            Application.DoEvents();

            // Clear the existing Tree View
            treeViewAllChanges.Nodes.Clear();

            // Create new list of items for the tree view
            List<ReposTreeItem> treeViewList = new List<ReposTreeItem>();

            try
            {
                siebelRep.GetAllChanges(siebelApp, settings, treeViewList);
                // Populate the Tree View with our results
                populateTreeView(0, null, treeViewList);
                treeViewAllChanges.ExpandAll();
            }
            catch (Exception e2)
            {
                showError("Siebel Error", "An error occurred while parsing the repository",
                    e2.ToString());
            }
            finally
            {
                // Set wait pointer
                Cursor.Current = Cursors.Default;
                toolStripStatusLabel.Text = "Ready";
                Application.DoEvents();
            }


        }


        /// <summary>
        /// Populates the Tree View based on the items passed in
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="parentNode"></param>
        /// <param name="treeViewList"></param>
        private void populateTreeView(int parentId, TreeNode parentNode, List<ReposTreeItem> treeViewList)
        {
            var filteredItems = treeViewList.Where(item => item.ParentId == parentId);

            TreeNode childNode;
            foreach (var i in filteredItems.ToList())
            {
                if (parentNode == null)
                    childNode = treeViewAllChanges.Nodes.Add(i.Name);
                else
                    childNode = parentNode.Nodes.Add(i.Name);

                // Tag the node so that we can refer back to these values later
                childNode.Tag = i.CreatedBy + "^" + i.CreatedDate + "^" + i.ModBy + "^" + i.ModDate;

                populateTreeView(i.Id, childNode, treeViewList);
            }
        }

        /// <summary>
        /// Make sure that the Siebel Connection is closed when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormReposAnalyser_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the Siebel connection, if it's open
            if (buttonLogout.Enabled)
            {
                siebelApp.Disconnect();
            }

            // Save settings to registry
            saveDefaults();

        }

        /// <summary>
        /// Handle clicking of the nodes to display the record information from the Tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewAllChanges_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node and it's tag
            TreeNode selItem = treeViewAllChanges.SelectedNode;
            string[] stringSeparators = new string[] { "^" };

            // Get the data from the tag
            string tag = selItem.Tag.ToString();

            // If date is present
            if (tag != "^^^")
            {
                // Split the tag out into the 4 data pieces
                string[] tagArray = tag.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                // Populate the text boxes with appropriate record info data
                textBoxCreated.Text = tagArray[1];
                textBoxCreatedBy.Text = tagArray[0];
                textBoxUpdated.Text = tagArray[3];
                textBoxUpdatedBy.Text = tagArray[2];
            }
        }

        /// <summary>
        /// Handles the main form button click - Connect screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            togglePanel("Connect");
        }

        /// <summary>
        /// Toggles the panels depending on the screen button clicked
        /// </summary>
        /// <param name="activePanel"></param>
        private void togglePanel(string activePanel)
        {
            switch (activePanel)
            {

                case "Home":
                    panelHome.Visible = true;
                    panelHome.BringToFront();
                    panelConnect.Visible = false;
                    panelScript.Visible = false;
                    panelConfig.Visible = false;
                    buttonHome.BackColor = SystemColors.ButtonHighlight;
                    buttonConnect.BackColor = SystemColors.ControlLight;
                    buttonConnect.UseVisualStyleBackColor = true;
                    buttonScript.BackColor = SystemColors.ControlLight;
                    buttonScript.UseVisualStyleBackColor = true;
                    buttonConfig.BackColor = SystemColors.ControlLight;
                    buttonConfig.UseVisualStyleBackColor = true;
                    break;

                case "Connect":
                    panelConnect.Visible = true;
                    panelConnect.BringToFront();
                    panelHome.Visible = false;
                    panelScript.Visible = false;
                    panelConfig.Visible = false;
                    buttonConnect.BackColor = SystemColors.ButtonHighlight;
                    buttonHome.BackColor = SystemColors.ControlLight;
                    buttonHome.UseVisualStyleBackColor = true;
                    buttonScript.BackColor = SystemColors.ControlLight;
                    buttonScript.UseVisualStyleBackColor = true;
                    buttonConfig.BackColor = SystemColors.ControlLight;
                    buttonConfig.UseVisualStyleBackColor = true;
                    break;

                case "Script":
                    panelHome.Visible = false;
                    panelConnect.Visible = false;
                    panelScript.Visible = true;
                    panelScript.BringToFront();
                    panelConfig.Visible = false;
                    buttonHome.BackColor = SystemColors.ControlLight;
                    buttonHome.UseVisualStyleBackColor = true;
                    buttonConnect.BackColor = SystemColors.ControlLight;
                    buttonConnect.UseVisualStyleBackColor = true;
                    buttonScript.BackColor = SystemColors.ButtonHighlight;
                    buttonConfig.BackColor = SystemColors.ControlLight;
                    buttonConfig.UseVisualStyleBackColor = true;
                    break;

                case "Config":
                    panelHome.Visible = false;
                    panelConnect.Visible = false;
                    panelScript.Visible = false;
                    panelConfig.Visible = true;
                    panelConfig.BringToFront();
                    buttonHome.BackColor = SystemColors.ControlLight;
                    buttonHome.UseVisualStyleBackColor = true;
                    buttonConnect.BackColor = SystemColors.ControlLight;
                    buttonConnect.UseVisualStyleBackColor = true;
                    buttonScript.BackColor = SystemColors.ControlLight;
                    buttonScript.UseVisualStyleBackColor = true;
                    buttonConfig.BackColor = SystemColors.ButtonHighlight;
                    break;

                default:
                    break;

            }

        }

        /// <summary>
        /// Handles the main form button click - Config screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            togglePanel("Config");
        }

        /// <summary>
        /// Handles the main form button click - Script screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScript_Click(object sender, EventArgs e)
        {
            togglePanel("Script");
        }

        /// <summary>
        /// Handles the 'Exit' menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the 'About' menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /// <summary>
        /// Handles the 'Exit' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private StreamWriter sr;

        public void exportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sr.WriteLine("<ChangeLog>");
            sr.WriteLine("<DateRange>");
            sr.WriteLine("<DateFrom>" + dateTimeChanges.Text + "</DateFrom>");
            sr.WriteLine("<DateTo>" + DateTime.Now.ToString("ddd, MMM dd, yyyy HH:mm:ss") + "</DateTo>");
            sr.WriteLine("</DateRange>");
            //Write our root node
            sr.WriteLine("<" + tv.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            //Close the root node
            sr.WriteLine("</" + tv.Nodes[0].Text + ">");
            sr.WriteLine("</ChangeLog>");
            sr.Close();
        }

        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + node.Text.Replace(" ", "") + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text.Replace(" ", "") + ">");
                }
                else //No child nodes, so we just write the text
                {
                    sr.WriteLine("<Object>");
                    sr.WriteLine(node.Text);
                    sr.WriteLine("</Object>");
                }
            }

        }

        /// <summary>
        /// Handle the 'Export to XML' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save to XML file";
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            if (fileName != "")
            {
                exportToXml(treeViewAllChanges, fileName);
            }
        }

        private void buttonFindScriptProbs_Click(object sender, EventArgs e)
        {

            // Set wait pointer
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Analysing objects...";
            Application.DoEvents();

            // Clear list
            dataGridViewScriptProbs.Rows.Clear();

            // Get problems
            List<SiebelProblem> allProblems = new List<SiebelProblem>();
            siebelRep.GetCodeProblems(siebelApp, allProblems, settings);

            // Set wait pointer
            toolStripStatusLabel.Text = "Building list...";
            Application.DoEvents();

            buildProblemLists(allProblems, dataGridViewScriptProbs);

            // Set wait pointer
            Cursor.Current = Cursors.Default;
            toolStripStatusLabel.Text = "Ready";
            Application.DoEvents();

        }

        private void buildProblemLists(List<SiebelProblem> allProblems, DataGridView gridView)
        {
            // Do stuff
            foreach (SiebelProblem problem in allProblems)
            {
                gridView.Rows.Add(problem.Type, problem.Object, problem.Function, problem.Line, problem.Details);
            }

        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "paypal@mroshaw.co.uk";  // your paypal email
            string description = "Donation";            // '%20' represents a space. remember HTML!
            string country = "GB";                  // AU, US, etc.
            string currency = "GBP";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            togglePanel("Home");
        }

        private void buttonGetCFG_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textBoxCFG.Text = fileName;
                refreshDataSource(fileName);
            }
        }

        private void refreshDataSource(string cfgFile)
        {

            SiebelConfigFile cfg = new SiebelConfigFile();
            cfg.Load(cfgFile);

            comboBoxDataSrc.Items.Clear();

            Dictionary<string, string> sect = cfg.GetSection("DataSources");
            foreach (KeyValuePair<string, string> pair in sect)
            {
                comboBoxDataSrc.Items.Add(pair.Value);
            }
        }

        private void comboBoxConType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConType.SelectedIndex == 1)
            {
                toggleConnectControls(true);
            }
            else
            {
                toggleConnectControls(false);
            }
            settings.conType = comboBoxConType.SelectedIndex;
        }

        private void toggleConnectControls(bool isLocal)
        {
            textBoxCFG.Enabled = isLocal;
            comboBoxDataSrc.Enabled = isLocal;
            buttonGetCFG.Enabled = isLocal;

            textBoxHost.Enabled = !isLocal;
            textBoxOM.Enabled = !isLocal;
            textBoxEnt.Enabled = !isLocal;

        }

        private void textBoxCFG_TextChanged(object sender, EventArgs e)
        {
            settings.conCFG = textBoxCFG.Text;
        }

        private void comboBoxDataSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.conDataSource = comboBoxDataSrc.SelectedIndex;
        }

        private void textBoxHost_TextChanged(object sender, EventArgs e)
        {
            settings.conHost = textBoxHost.Text;
        }

        private void textBoxEnt_TextChanged(object sender, EventArgs e)
        {
            settings.conEnt = textBoxEnt.Text;
        }

        private void textBoxOM_TextChanged(object sender, EventArgs e)
        {
            settings.conOM = textBoxOM.Text;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            settings.conUser = textUser.Text;
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            settings.conPassword = textPass.Text;
        }

        private void checkBoxRemPass_CheckedChanged(object sender, EventArgs e)
        {
            settings.conRemember = checkBoxRemPass.Checked;
        }

        private void textBoxScriptNameFilter_TextChanged(object sender, EventArgs e)
        {
            settings.scriptNameFilter = textBoxScriptNameFilter.Text;
        }

        private void textBoxScriptUpdatedByFilter_TextChanged(object sender, EventArgs e)
        {
            settings.scriptUpdatedByFilter = textBoxUpdatedBy.Text;
        }

        private void textBoxConfigNameFilter_TextChanged(object sender, EventArgs e)
        {
            settings.configNameFilter = textBoxConfigNameFilter.Text;
        }

        private void dateTimeScriptUpdatedFilter_ValueChanged(object sender, EventArgs e)
        {
            settings.scriptUpdatedFilter = dateTimeScriptUpdatedFilter.Value;
        }

        private void dateTimeScriptCreatedFilter_ValueChanged(object sender, EventArgs e)
        {
            settings.scriptCreatedFilter = dateTimeScriptCreatedFilter.Value;
        }

        private void dateTimeConfigUpdatedFilter_ValueChanged(object sender, EventArgs e)
        {
            settings.configUpdatedFilter = dateTimeConfigUpdatedFilter.Value;
            dateTimeChanges.Value = dateTimeConfigUpdatedFilter.Value;
        }

        private void dateTimeConfigCreatedFilter_ValueChanged(object sender, EventArgs e)
        {
            settings.configCreatedFilter = dateTimeConfigCreatedFilter.Value;
        }

        private void comboBoxScriptUpdatedByFilter_TextChanged(object sender, EventArgs e)
        {
            settings.scriptUpdatedByFilter = comboBoxScriptUpdatedByFilter.Text;
        }

        private void comboBoxScriptCreatedByFilter_TextChanged(object sender, EventArgs e)
        {
            settings.scriptCreatedByFilter = comboBoxScriptCreatedByFilter.Text;
        }

        private void comboBoxConfigUpdatedByFilter_TextChanged(object sender, EventArgs e)
        {
            settings.configUpdatedByFilter = comboBoxConfigUpdatedByFilter.Text;
            comboBoxUser.Text = comboBoxConfigUpdatedByFilter.Text;
        }

        private void comboBoxScriptCreatedByFilter_TextUpdate(object sender, EventArgs e)
        {
            settings.configCreatedByFilter = comboBoxScriptCreatedByFilter.Text;
        }

        private void dateTimeChanges_ValueChanged(object sender, EventArgs e)
        {
            settings.configUpdatedFilter = dateTimeChanges.Value;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.configUpdatedByFilter = comboBoxUser.Text;
        }

        private void checkBoxConfigForceActive_CheckedChanged(object sender, EventArgs e)
        {
            settings.configForceActiveCheck = checkBoxConfigForceActive.Checked;
        }

        private void checkBoxConfigLinkSpec_CheckedChanged(object sender, EventArgs e)
        {
            settings.configLinkSpecCheck = checkBoxConfigLinkSpec.Checked;
        }

        private void checkBoxSsriptFinally_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptRetCheck = checkBoxScriptFinally.Checked;
        }

        private void checkBoxScriptDestruction_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptDestCheck = checkBoxScriptDestruction.Checked;
        }

        private void checkBoxScriptVars_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptUnusedCheck = checkBoxScriptVars.Checked;
        }

        private void checkBoxScriptNoComm_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptNoCommCheck = checkBoxScriptNoComm.Checked;
        }

        private void checkBoxForwardBack_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptForBackCheck = checkBoxForwardBack.Checked;
        }

        private void checkBoxIgnoreVan_CheckedChanged(object sender, EventArgs e)
        {
            settings.scriptIgnoreVanCheck = checkBoxScriptIgnoreVan.Checked;
        }

        private void buttonExportScriptProblemsXML_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save to XML file";
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            if (fileName != "")
            {
                exportProblemsToXML(dataGridViewScriptProbs, fileName);
            }
        }

        private void exportProblemsToXML(DataGridView gridView, string fileName)
        {

            sr = new StreamWriter(fileName, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sr.WriteLine("<ScriptProblems>");
            sr.WriteLine("<Date>" + DateTime.Now.ToString("ddd, MMM dd, yyyy HH:mm:ss") + "</Date>");
            sr.WriteLine("<Problems>");

            foreach (DataGridViewRow row in gridView.Rows)
            {
                sr.WriteLine("<Problem>");
                sr.WriteLine("<Type>" + row.Cells[0].Value + "</Type>");
                sr.WriteLine("<Object>" + row.Cells[1].Value + "</Object>");
                sr.WriteLine("<Function>" + row.Cells[2].Value + "</Function>");
                sr.WriteLine("<Line>" + row.Cells[3].Value + "</Line>");
                sr.WriteLine("<Detail>" + row.Cells[4].Value + "</Detail>");
                sr.WriteLine("</Problem>");
            }
            sr.WriteLine("</Problems>");
            sr.WriteLine("</ScriptProblems>");
            sr.Close();

        }

        private void buttonExportConfigProblemsXML_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save to XML file";
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            if (fileName != "")
            {
                exportProblemsToXML(dataGridViewConfigProbs, fileName);
            }
        }

        private void toolStripSplitButtonConnect_Click(object sender, EventArgs e)
        {
            if (siebelApp.Connected)
            {
                buttonLogout_Click(this, new EventArgs());
            }
            else
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void buttonScriptExportProbCSV_Click(object sender, EventArgs e)
        {
            exportGridToCSV(dataGridViewScriptProbs);
        }

        public void exportGridToCSV(DataGridView grid)
        {

            saveFileDialog.Title = "Save to XML file";
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            if (fileName != "")
            {
                System.IO.StreamWriter strWri = new System.IO.StreamWriter(fileName);
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    string strRowVal = "";
                    for (int j = 0; j < grid.Rows[i].Cells.Count; j++)
                    {
                        if (strRowVal == "")
                        {
                            strRowVal = grid.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            strRowVal = strRowVal + "," + grid.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    strWri.WriteLine(strRowVal);
                }
                strWri.Close();

            }
        }

        private void buttonConfigExportProbCSV_Click(object sender, EventArgs e)
        {
            exportGridToCSV(dataGridViewConfigProbs);
        }

        private void buttonScriptSearch_Click(object sender, EventArgs e)
        {

            // Get search term
            string searchTerm = textBoxSearch.Text;

            if (searchTerm != "")
            {
                // Set wait pointer
                Cursor.Current = Cursors.WaitCursor;
                toolStripStatusLabel.Text = "Analysing objects...";
                Application.DoEvents();

                // Clear list
                treeViewSearchResults.Nodes.Clear();

                // Get search results
                List<SearchResults> allResults = new List<SearchResults>();
                siebelRep.SearchScript(siebelApp, allResults, searchTerm, settings);

                // Set wait pointer
                toolStripStatusLabel.Text = "Building list...";
                Application.DoEvents();

                populateSearchTree(0, null, allResults);

                // Set wait pointer
                Cursor.Current = Cursors.Default;
                toolStripStatusLabel.Text = "Ready";
                Application.DoEvents();
            }
        }

        private void populateSearchTree(int parentId, TreeNode parentNode, List<SearchResults> results)
        {
            // Add parent node
            TreeNode parent = treeViewSearchResults.Nodes.Add("Results");
            TreeNode current = new TreeNode();
            TreeNode currItem = new TreeNode();
            TreeNode tagNode = new TreeNode();

            string currObjectName = "";
            string currObjectType = "";

            foreach (SearchResults result in results)
            {
                // If we move to a new Object Type, reset current Node to one below parent
                if (result.ObjectType != currObjectType)
                {
                    current = parent.Nodes.Add(result.ObjectType);
                    
                }
                
                // IF we move to a new Object, reset current node to one below current
                if (result.ObjectName != currObjectName)
                {
                    currItem =  current.Nodes.Add(result.ObjectName);
                }

                tagNode = currItem.Nodes.Add(result.MethodName + "(" + result.LineNum.ToString() + ")");
                tagNode.Tag = result.ScriptCode.Replace("\n", Environment.NewLine) +"^" + result.LineNum.ToString();

                currObjectType = result.ObjectType;
                currObjectName = result.ObjectName;
            }
 
        }

        private void treeViewSearchResults_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node and it's tag
            TreeNode selItem = treeViewSearchResults.SelectedNode;

            // Get the data from the tag
            object tag = selItem.Tag;

            if (tag != null)
            {
                string[] stringSeparators = new string[] { "^" };

                // Get the data from the tag
                string tagString = tag.ToString();

                // If date is present
                if (tagString != "^")
                {
                    // Split the tag out into the 4 data pieces
                    string[] tagArray = tagString.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                    // Populate the text boxes with appropriate record info data
                    richTextBoxExScript.Text = tagArray[0];
                    int lineNum = Convert.ToInt16(tagArray[1]);
                    // Move the cursor to the line with the search term
                    // Set the selection start and end position
                    richTextBoxExScript.SelectionStart = richTextBoxExScript.GetFirstCharIndexFromLine(lineNum - 1);
                    richTextBoxExScript.SelectionLength = richTextBoxExScript.Lines[lineNum - 1].Length;

                    // Move the cursor to the new position
                    richTextBoxExScript.ScrollToCaret();
                }
            }
        }
    }
}
