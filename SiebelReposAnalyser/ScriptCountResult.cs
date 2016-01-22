using System;

namespace SiebelReposAnalyser
{
    class ScriptCountResult
    {
        public String ObjectType;
        public String ServerScript;
        public String BrowserScript;
        public String TotalScript;
        public String CustomScript;

        public ScriptCountResult(string objectType, string serverScript, string browserScript, string totalScript, string customScript)
        {
            ObjectType = objectType;
            ServerScript = serverScript;
            BrowserScript = browserScript;
            TotalScript = totalScript;
            CustomScript = customScript;
        }
    }


}
