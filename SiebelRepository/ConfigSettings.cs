using System;

namespace SiebelRepositoryWrapper
{
    public class ConfigSettings
    {
        public ConfigSettings()
        {
            DateFilter = "";
            UserFilter = "";
            NameFilter = "";

            CheckForceActive = false;
            IgnoreInactive = true;
        }

        public string DateFilter { get; set; }
        public string UserFilter { get; set; }
        public string NameFilter { get; set; }
        public Boolean CheckForceActive { get; set; }
        public Boolean IgnoreInactive { get; set; }
    }
}