#region

using System;

#endregion

namespace SiebelRepositoryWrapper
{
    public class ScriptSettings
    {
        public ScriptSettings()
        {
            CheckForwardBackward = false;
            CheckNoComments = false;
            CheckRetInFinally = false;
            CheckDestruction = false;
            DateFilter = "";
            ObjNameFilter = "";
            UserFilter = "";
            CountObjNameFilter = "";
            CountUserNameFIlter = "";
            Version = "";
            IgnoreInactive = true;
        }

        public Boolean CheckForwardBackward { get; set; }
        public Boolean CheckNoComments { get; set; }
        public Boolean CheckDestruction { get; set; }
        public Boolean CheckRetInFinally { get; set; }
        public string UserFilter { get; set; }
        public string DateFilter { get; set; }
        public string ObjNameFilter { get; set; }
        public string CountObjNameFilter { get; set; }
        public string CountUserNameFIlter { get; set; }
        public string Version { get; set; }
        public Boolean IgnoreInactive { get; set; }
    }
}