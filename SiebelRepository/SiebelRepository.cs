#region

using System;
using System.Collections.Generic;
using System.Globalization;
using SiebelBusObjectInterfaces;

#endregion

namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Class to represent an instance of a Siebel Repository
    /// </summary>
    public class SiebelRepository
    {
        public delegate void StatusUpdateCallback(string status);

        private readonly SiebelAppWrapper _siebelAppWrapper;
        private dynamic _siebApp;

        public SiebelRepository(String reposName)
        {
            _siebelAppWrapper = new SiebelAppWrapper();
            Name = reposName;
        }

        /// <summary>
        ///     Allow setting and getting of name
        /// </summary>
        public string Name { set; get; }

        public bool Connected { get; set; }

        // Handles calling back to the Form Class to update the UI
        public void UpdateStatus(string status, StatusUpdateCallback callBack)
        {
            callBack(status);
        }

        /// <summary>
        ///     Connect to Client
        /// </summary>
        public void Connect()
        {
            _siebelAppWrapper.InitClient();
            _siebApp = _siebelAppWrapper.SiebelAppInstance;
            _siebelAppWrapper.Connect();
            Connected = _siebelAppWrapper.IsConnected();
        }

        /// <summary>
        ///     Connect to Server
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="enterprise"></param>
        /// <param name="om"></param>
        public void Connect(string userName, string password, string host, string enterprise, string om)
        {
            _siebelAppWrapper.InitServer(userName, password, host, enterprise, om);
            _siebApp = _siebelAppWrapper.SiebelAppInstance;
            _siebelAppWrapper.Connect();
            Connected = _siebelAppWrapper.IsConnected();
        }

        public void Disconnect()
        {
            _siebelAppWrapper.Disconnect();
        }

        /// <summary>
        ///     Gets the Login Name of the user, based on the ROW_ID passed in
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public string GetUserLogin(string rowId)
        {
            try
            {
                // Set up Employee BC context
                SiebelBusObject empBo = _siebApp.GetBusObject("Employee");
                SiebelBusComp empBc = empBo.GetBusComp("Employee");

                empBc.ClearToQuery();
                empBc.SetViewMode(SiebelConstants.AllView);
                empBc.SetSearchSpec("Id", rowId);
                empBc.ActivateField("Login Name");
                empBc.ExecuteQuery(SiebelConstants.ForwardOnly);

                if (!empBc.FirstRecord()) return ("Unknown User");
                string login = empBc.GetFieldValue("Login Name");
                return (login);
            }
            catch (Exception)
            {
                return ("Unknown User");
            }
        }

        public Boolean IsConnected()
        {
            return _siebelAppWrapper.IsConnected();
        }

        /// <summary>
        ///     Get the Login Id of the user, based on the login name passed in
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public string GetUserLoginId(string loginName)
        {
            try
            {
                // Set up Employee BC context
                SiebelBusObject empBo = _siebApp.GetBusObject("Employee");
                SiebelBusComp empBc = empBo.GetBusComp("Employee");

                empBc.ClearToQuery();
                empBc.SetViewMode(SiebelConstants.AllView);
                empBc.SetSearchSpec("Login Name", loginName);
                empBc.ExecuteQuery(SiebelConstants.ForwardOnly);

                if (!empBc.FirstRecord()) return ("Unknown User");
                string loginId = empBc.GetFieldValue("Id");
                return (loginId);
            }
            catch (Exception)
            {
                return ("Unknown User");
            }
        }

        public void GetAllUsers(List<SiebelUsers> users)
        {
            // Set up Employee BC context
            SiebelBusObject empBo = _siebApp.GetBusObject("Employee");
            SiebelBusComp empBc = empBo.GetBusComp("Employee");

            empBc.ClearToQuery();
            empBc.SetViewMode(SiebelConstants.AllView);
            empBc.SetSortSpec("Login Name");
            empBc.ExecuteQuery(SiebelConstants.ForwardOnly);

            Boolean isRecord = empBc.FirstRecord();

            while (isRecord)
            {
                SiebelUsers user = new SiebelUsers(empBc.GetFieldValue("Id"), empBc.GetFieldValue("Login Name"));
                users.Add(user);
                isRecord = empBc.NextRecord();
            }
        }

        /// <summary>
        /// Return the number of lines of code across the whole repository
        /// </summary>
        /// <param name="scriptLine"></param>
        /// <param name="settings"></param>
        /// <param name="updateStatusBar"></param>
        /// <returns></returns>
        public SiebelScriptLines GetCodeLineCount(SiebelScriptLines scriptLine, ScriptSettings settings, StatusUpdateCallback updateStatusBar)
        {
            scriptLine.ApplicationBsLine = GetObjCodeLines("Repository Application", "Repository Application Browser Script", "Script", settings, updateStatusBar);
            scriptLine.ApplicationSsLine = GetObjCodeLines("Repository Application", "Repository Application Server Script", "Script", settings, updateStatusBar);

            scriptLine.AppletBsLine = GetObjCodeLines("Repository Applet", "Repository Applet Browser Script", "Script", settings, updateStatusBar);
            scriptLine.AppletSsLine = GetObjCodeLines("Repository Applet", "Repository Applet Server Script", "Script", settings, updateStatusBar);

            scriptLine.BcbsLine = GetObjCodeLines("Repository Business Component", "Repository BusComp Browser Script", "Script", settings, updateStatusBar);
            scriptLine.BcssLine = GetObjCodeLines("Repository Business Component", "Repository BusComp Server Script", "Script", settings, updateStatusBar);

            scriptLine.BsbsLine = GetObjCodeLines("Repository Business Service", "Repository Business Service Browser Script", "Script", settings, updateStatusBar);
            scriptLine.BsssLine = GetObjCodeLines("Repository Business Service", "Repository Business Service Server Script", "Script", settings, updateStatusBar);

            scriptLine.TotalLine = scriptLine.ApplicationBsLine + scriptLine.ApplicationSsLine + scriptLine.AppletBsLine +
                                   scriptLine.AppletSsLine +
                                   scriptLine.BcbsLine + scriptLine.BcssLine + scriptLine.BsbsLine + scriptLine.BsssLine;

            return scriptLine;
        }

        /// <summary>
        ///     Gets the number of code lines for a specific object type
        /// </summary>
        /// <param name="busObjName"></param>
        /// <param name="busCompName"></param>
        /// <param name="codeFieldName"></param>
        /// <param name="settings"></param>
        /// <param name="updateStatusBar"></param>
        /// <returns></returns>
        private int GetObjCodeLines(string busObjName, string busCompName, string codeFieldName, ScriptSettings settings, StatusUpdateCallback updateStatusBar)
        {
            // Reset counts
            int numLines = 0;

            // Declare Siebel objects

            // Initialise BO and BC objects
            SiebelBusObject busObj = _siebApp.GetBusObject(busObjName);
            SiebelBusComp busComp = busObj.GetBusComp(busCompName);

            // Set up query context
            busComp.SetViewMode(SiebelConstants.AllView);
            busComp.ActivateField(codeFieldName);
            busComp.ActivateField("Inactive");
            busComp.ActivateField("Parent Inactive");
            busComp.ClearToQuery();
            busComp.SetSearchSpec("Repository Name", Name);

            string userFilter = settings.CountUserNameFIlter;
            string objFilter = settings.CountObjNameFilter;

            // Filter by Update Date and Obj Name, if required
            if (!string.IsNullOrEmpty(userFilter) && userFilter != "All")
            {
                busComp.SetSearchSpec("Updated By", "'" + GetUserLoginId(userFilter) + "'");
            }

            if (!string.IsNullOrEmpty(objFilter))
            {
                busComp.SetSearchSpec("Parent Name", "'" + objFilter + "'");
            }

            if (settings.IgnoreInactive)
            {
                busComp.SetSearchSpec("Inactive", "'N'");
                busComp.SetSearchSpec("Parent Inactive", "'N'");
            }
            busComp.ExecuteQuery(SiebelConstants.ForwardOnly);

            // Check that records are returned
            bool isRecord = busComp.FirstRecord();

            // Process each record
            while (isRecord)
            {
                // Get the script field from the BC
                string script = busComp.GetFieldValue(codeFieldName);

                SiebelScript scriptObject = new SiebelScript(script);
                updateStatusBar("Processing: " + busCompName);
                
                // Count the lines in the single script object and add to the total
                numLines += scriptObject.NumberOfLines();

                // Get the next record
                isRecord = busComp.NextRecord();
            }

            return numLines;
        }

        /// <summary>
        ///     Select appropriate Business Objects to process and send for processing
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="userName"></param>
        /// <param name="updateStatusBar"></param>
        public List<SiebelReposChange> GetAllChanges(string fromDate, string userName,
            StatusUpdateCallback updateStatusBar)
        {
            // Parent Object (e.g Applet), child Object (i.e. Applet Browser Script) and Object name (e.g. HLS Case List Applet)
            List<SiebelReposChange> reposChanges = new List<SiebelReposChange>();

            try
            {
                // Construct BO context

                // Top level, allowing recovery of all 'Repository' Business Components which reflect all object types in the repository
                SiebelBusObject reposBo = _siebApp.GetBusObject("Repository Business Object");

                // Parent BC of all Repository objects
                SiebelBusComp reposBobc = reposBo.GetBusComp("Repository Business Object");

                // Query the top level BO, getting all objects with the name 'Repository*'
                // We have to exclude a couple of items, as Siebel is not happy creating context with these two
                reposBobc.ClearToQuery();
                reposBobc.SetViewMode(SiebelConstants.AllView);
                reposBobc.SetSearchSpec("Name",
                    "LIKE 'Repository*' And [Name] <> 'Repository Details' And [Name] <> 'Repository Entity Relationship Diagram' And [Name] Not Like 'Repository IFMgr*'");
                reposBobc.SetSearchSpec("Repository Name", Name);
                reposBobc.SetSortSpec("Name(ASCENDING)");
                reposBobc.ExecuteQuery(SiebelConstants.ForwardOnly);

                // Check we have some records
                bool isRecord = reposBobc.FirstRecord();

                // Loop through the top level object types
                while (isRecord)
                {
                    string objName = reposBobc.GetFieldValue("Name");
                    updateStatusBar("Processing: " + objName);
                    ProcessBo(objName, reposChanges, reposBo, fromDate, userName);

                    // Process the next object type
                    isRecord = reposBobc.NextRecord();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return reposChanges;
        }

        /// <summary>
        ///     Processes a given Business Object
        /// </summary>
        /// <param name="objName"></param>
        /// <param name="fromDate"></param>
        /// <param name="treeViewList"></param>
        /// <param name="reposBo"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        private void ProcessBo(string objName, List<SiebelReposChange> treeViewList, SiebelBusObject reposBo,
            string fromDate, string userName)
        {
            // BC representing all object types in the repository
            SiebelBusComp reposBcbc = reposBo.GetBusComp("Repository Business Object Component");

            reposBcbc.ClearToQuery();
            reposBcbc.SetViewMode(SiebelConstants.AllView);
            reposBcbc.ActivateField("Link");
            reposBcbc.SetSearchSpec("Link", "IS NULL");

            // Sort by name and query
            reposBcbc.SetSortSpec("Link(DESCENDING), Name(ASCENDING)");
            reposBcbc.ExecuteQuery(SiebelConstants.ForwardOnly);

            bool isChildRecord = reposBcbc.FirstRecord();

            // Parse all child objects
            while (isChildRecord)
            {
                // Get the name of the BC
                string childObjName = reposBcbc.GetFieldValue("Name");
                QueryForChanges(objName, childObjName, treeViewList, fromDate, userName);

                // Go to the next child
                isChildRecord = reposBcbc.NextRecord();
            }
        }

        /// <summary>
        ///     Queries for changes against a specific BC
        /// </summary>
        /// <param name="objName"></param>
        /// <param name="childObjName"></param>
        /// <param name="fromDate"></param>
        /// <param name="treeViewList"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        private void QueryForChanges(string objName, string childObjName, List<SiebelReposChange> treeViewList,
            string fromDate, string userName)
        {
            // Now query that BC for all changes to that specific object type
            // Made since the date given
            // Get date in Siebel format
            DateTime tempDate = DateTime.Parse(fromDate, new CultureInfo("en-Us"));
            String siebfromDate = tempDate.ToString("MM/dd/yyyy HH:mm:ss");
            SiebelBusObject queryBo = _siebApp.GetBusObject(objName);
            SiebelBusComp queryBc = queryBo.GetBusComp(childObjName);
            queryBc.ClearToQuery();
            queryBc.SetViewMode(SiebelConstants.AllView);
            queryBc.SetSearchSpec("Updated", ">= '" + siebfromDate + "'");
            queryBc.SetSearchSpec("Repository Name", Name);

            if (userName != "All")
            {
                string loginId = GetUserLoginId(userName);
                queryBc.SetSearchSpec("Updated By", loginId);
            }

            queryBc.ExecuteQuery(SiebelConstants.ForwardOnly);

            bool isUpdatedRec = queryBc.FirstRecord();

            // If modified record found, add to tree and process children
            if (!isUpdatedRec) return;
            // We'll eventually add a hierarchy of child items, showing greater detail of what has been changed within
            // the parent object type (i.e. Applet Server Script)

            // Loop through the updated records
            while (isUpdatedRec)
            {
                // Retrieve the name, updated date and login ID (ROW_ID) of the user who made the change
                string itemName = queryBc.GetFieldValue("Name");
                string itemUpdated = queryBc.GetFieldValue("Updated");
                string itemUpdatedBy = GetUserLogin(queryBc.GetFieldValue("Updated By"));
                string itemCreated = queryBc.GetFieldValue("Created");
                string itemCreatedBy = GetUserLogin(queryBc.GetFieldValue("Created By"));
                string itemObjectType = childObjName.Substring(11);
                DateTime itemUpdatedDate = DateTime.Parse(itemUpdated, CultureInfo.CreateSpecificCulture("en-us"));
                itemUpdated = itemUpdatedDate.ToString(CultureInfo.CurrentCulture);

                DateTime itemCreatedDate = DateTime.Parse(itemCreated, CultureInfo.CreateSpecificCulture("en-us"));
                itemCreated = itemCreatedDate.ToString(CultureInfo.CurrentCulture);

                // Add an item to the tree - we need to lookup the Login Name based on the ID obtained above
                treeViewList.Add(new SiebelReposChange(0, 0, itemObjectType, itemName, itemUpdatedBy, itemUpdated,
                    itemCreatedBy, itemCreated));

                // Go to the next record in the record set
                isUpdatedRec = queryBc.NextRecord();
            }
        }

        /// <summary>
        ///     Returns a list of code problems across the whole repository
        /// </summary>
        /// <param name="allProblems"></param>
        /// <param name="settings"></param>
        /// <param name="updateStatusBar"></param>
        public void GetCodeProblems(List<SiebelProblem> allProblems, ScriptSettings settings,
            StatusUpdateCallback updateStatusBar)
        {
            GetObjectCodeProblems("Application", "Repository Application", "Repository Application Browser Script",
                "Script", allProblems, settings, updateStatusBar);
            GetObjectCodeProblems("Application", "Repository Application", "Repository Application Server Script",
                "Script", allProblems, settings, updateStatusBar);

            GetObjectCodeProblems("Applet", "Repository Applet", "Repository Applet Browser Script", "Script",
                allProblems, settings, updateStatusBar);
            GetObjectCodeProblems("Applet", "Repository Applet", "Repository Applet Server Script", "Script",
                allProblems, settings, updateStatusBar);

            GetObjectCodeProblems("Business Component", "Repository Business Component",
                "Repository BusComp Browser Script", "Script", allProblems, settings, updateStatusBar);
            GetObjectCodeProblems("Business Component", "Repository Business Component",
                "Repository BusComp Server Script", "Script", allProblems, settings, updateStatusBar);

            GetObjectCodeProblems("Business Service", "Repository Business Service",
                "Repository Business Service Browser Script", "Script", allProblems, settings, updateStatusBar);
            GetObjectCodeProblems("Business Service", "Repository Business Service",
                "Repository Business Service Server Script", "Script", allProblems, settings, updateStatusBar);
        }

        /// <summary>
        ///     Returns a list of code problems for a given object
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="busObjName"></param>
        /// <param name="busCompName"></param>
        /// <param name="codeFieldName"></param>
        /// <param name="allProblems"></param>
        /// <param name="settings"></param>
        /// <param name="updateStatusBar"></param>
        private void GetObjectCodeProblems(string objType, string busObjName, string busCompName, string codeFieldName,
            List<SiebelProblem> allProblems, ScriptSettings settings, StatusUpdateCallback updateStatusBar)
        {
            // Declare Siebel objects

            // Initialise BO and BC objects
            SiebelBusObject busObj = _siebApp.GetBusObject(busObjName);
            SiebelBusComp busComp = busObj.GetBusComp(busCompName);

            // Set up query context
            busComp.ClearToQuery();
            busComp.SetViewMode(SiebelConstants.AllView);
            busComp.ActivateField(codeFieldName);
            busComp.ActivateField("Name");
            busComp.ActivateField("Updated By");
            busComp.ActivateField("Parent Name");
            busComp.ActivateField("Inactive");
            busComp.ActivateField("Parent Inactive");
            busComp.SetSearchSpec("Repository Name", Name);
            busComp.SetSortSpec("Parent Name(ASC), Name(ASC)");

            string userFilter = settings.UserFilter;
            string objFilter = settings.ObjNameFilter;

            // Filter by Update Date and Obj Name, if required
            if (userFilter != "" && userFilter != "All" && userFilter != null)
            {
                busComp.SetSearchSpec("Updated By", "'" + GetUserLoginId(userFilter) + "'");
            }

            if (!string.IsNullOrEmpty(objFilter))
            {
                busComp.SetSearchSpec("Parent Name", "'" + objFilter + "'");
            }

            if (settings.IgnoreInactive)
            {
                busComp.SetSearchSpec("Inactive", "'N'");
                busComp.SetSearchSpec("Parent Inactive", "'N'");
            }

            busComp.ExecuteQuery(SiebelConstants.ForwardOnly);

            // Check that records are returned
            bool isRecord = busComp.FirstRecord();

            // Determine if Server or Browser script
            string scriptType = busCompName.IndexOf("Browser Script", StringComparison.Ordinal) > 0 ? "Browser" : "Server";

            // Process each record
            while (isRecord)
            {
                // Get the script field from the BC
                string script = busComp.GetFieldValue(codeFieldName);
                string methodName = busComp.GetFieldValue("Name");
                string parentName = busComp.GetFieldValue("Parent Name");

                // Update UI status bar
                updateStatusBar("Processing: " + busCompName + " (" + parentName + "." + methodName + ")");

                SiebelScript scriptObject = new SiebelScript(script, parentName, methodName, objType, scriptType);

                // Search the script for problems
                scriptObject.GetScriptProblems(allProblems, settings);
                // Get the next record
                isRecord = busComp.NextRecord();
            }
        }

        /// <summary>
        /// Search for the specified search term
        /// </summary>
        /// <param name="results"></param>
        /// <param name="searchTerm"></param>
        /// <param name="updateStatusBar"></param>
        /// <param name="ignoreCase"></param>
        public void SearchScript(List<SearchResults> results, string searchTerm, StatusUpdateCallback updateStatusBar, Boolean ignoreCase)
        {
            SearchObjectScript("Application", "Repository Application", "Repository Application Browser Script", "Script", searchTerm, results, updateStatusBar, "Browser", ignoreCase);
            SearchObjectScript("Application", "Repository Application", "Repository Application Server Script", "Script", searchTerm, results, updateStatusBar, "Server", ignoreCase);

            SearchObjectScript("Applet", "Repository Applet", "Repository Applet Browser Script", "Script", searchTerm, results, updateStatusBar, "Browser", ignoreCase);
            SearchObjectScript("Applet", "Repository Applet", "Repository Applet Server Script", "Script", searchTerm, results, updateStatusBar, "Server", ignoreCase);

            SearchObjectScript("Business Component", "Repository Business Component", "Repository BusComp Browser Script", "Script", searchTerm, results, updateStatusBar, "Browser", ignoreCase);
            SearchObjectScript("Business Component", "Repository Business Component", "Repository BusComp Server Script", "Script", searchTerm, results, updateStatusBar, "Server", ignoreCase);

            SearchObjectScript("Business Service", "Repository Business Service", "Repository Business Service Browser Script", "Script", searchTerm, results, updateStatusBar, "Browser", ignoreCase);
            SearchObjectScript("Business Service", "Repository Business Service", "Repository Business Service Server Script", "Script", searchTerm, results, updateStatusBar, "Server", ignoreCase);
        }

        private void SearchObjectScript(string objType, string busObjName, string busCompName, string codeFieldName,
            string searchTerm, List<SearchResults> results, StatusUpdateCallback updateStatusBar, string scriptType, Boolean ignoreCase)
        {
            // Declare Siebel objects
            // Initialise BO and BC objects
            SiebelBusObject busObj = _siebApp.GetBusObject(busObjName);
            SiebelBusComp busComp = busObj.GetBusComp(busCompName);

            // Set up query context
            busComp.ClearToQuery();
            busComp.SetViewMode(SiebelConstants.AllView);
            busComp.ActivateField(codeFieldName);
            busComp.ActivateField("Parent Name");
            busComp.ActivateField("Inactive");
            busComp.ActivateField("Parent Inactive");
            busComp.SetSearchSpec("Repository Name", Name);
            busComp.SetSortSpec("Parent Name(ASC), Name(ASC)");

            if (ignoreCase)
            {
                busComp.SetSearchSpec("Inactive", "N");
                busComp.SetSearchSpec("Parent Inactive", "N");
            }

            busComp.ExecuteQuery(SiebelConstants.ForwardOnly);

            // Check that records are returned
            bool isRecord = busComp.FirstRecord();

             // Process each record
            while (isRecord)
            {
                // Get the script field from the BC
                string script = busComp.GetFieldValue(codeFieldName);
                string methodName = busComp.GetFieldValue("Name");
                string parentName = busComp.GetFieldValue("Parent Name");
                SiebelScript scriptObject = new SiebelScript(script, parentName, methodName, objType, scriptType);
                updateStatusBar("Searching: " + parentName + "." + methodName);
                // Search the script for problems
                scriptObject.Search(searchTerm, results, ignoreCase);
                // Get the next record
                isRecord = busComp.NextRecord();
            }
        }

        public void GetConfigProblems(List<SiebelProblem> allProblems, ConfigSettings settings,
            StatusUpdateCallback updateStatusBar)
        {
            // Check for BC specific configuration issues
            if (settings.CheckForceActive)
            {
                GetObjectConfigProblems("Business Component", "Repository Business Component", "Repository Field",
                    allProblems, settings, updateStatusBar);
            }
        }

        private void GetObjectConfigProblems(string objType, string busObjName, string busCompName,
            List<SiebelProblem> allProblems,
            ConfigSettings settings, StatusUpdateCallback updateStatusBar)
        {
            // Declare Siebel objects

            // Initialise BO and BC objects
            SiebelBusObject busObj = _siebApp.GetBusObject(busObjName);
            SiebelBusComp busComp = busObj.GetBusComp(busCompName);

            // Set up query context
            busComp.ClearToQuery();
            busComp.SetViewMode(SiebelConstants.AllView);
            busComp.ActivateField("Name");
            busComp.ActivateField("Updated By");
            busComp.ActivateField("Parent Name");
            busComp.ActivateField("Inactive");
            busComp.ActivateField("Parent Inactive");

            busComp.SetSearchSpec("Repository Name", Name);
            busComp.SetSearchSpec("Force Active", "Y");
            busComp.SetSearchSpec("Join", "<> ''");
            busComp.SetSortSpec("Parent Name(ASC), Name(ASC)");

            string userFilter = settings.UserFilter;
            string objFilter = settings.NameFilter;

            // Filter by Update Date and Obj Name, if required
            if (userFilter != "" && userFilter != "All" && userFilter != null)
            {
                busComp.SetSearchSpec("Updated By", "'" + GetUserLoginId(userFilter) + "'");
            }

            if (!string.IsNullOrEmpty(objFilter))
            {
                busComp.SetSearchSpec("Parent Name", "'" + objFilter + "'");
            }

            if (settings.IgnoreInactive)
            {
                busComp.SetSearchSpec("Inactive", "N");
                busComp.SetSearchSpec("Parent Inactive", "N");
            }

            busComp.ExecuteQuery(SiebelConstants.ForwardOnly);

            // Check that records are returned
            bool isRecord = busComp.FirstRecord();

            // Update UI status bar
            updateStatusBar("Processing: " + busObjName);

            // Process each record
            while (isRecord)
            {
                // Get the parent name
                string parentName = busComp.GetFieldValue("Parent Name");

                // Get the field name
                string fieldName = busComp.GetFieldValue("Name");

                SiebelProblem problem = new SiebelProblem("Config", "Performance",
                    "Review 'Force Active' on Join field",
                    parentName, objType, fieldName, 0);
                allProblems.Add(problem);

                // Get the next record
                isRecord = busComp.NextRecord();
            }
        }
    }
}