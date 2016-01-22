namespace SiebelRepositoryWrapper
{
    public class SearchResults
    {
        public SearchResults(int lineNum, string scriptCode, string searchTerm, string objectType, string objectName,
            string methodName, string scriptType)
        {
            LineNum = lineNum;
            ScriptCode = scriptCode;
            SearchTerm = searchTerm;
            ObjectType = objectType;
            ObjectName = objectName;
            MethodName = methodName;
            ScriptType = scriptType;
        }

        public int LineNum { get; set; }
        public string ScriptCode { get; set; }
        public string SearchTerm { get; set; }
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string MethodName { get; set; }
        public string ScriptType { get; set; }
     }
}