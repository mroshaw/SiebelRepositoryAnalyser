namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Class representing an instance of a problem in the Repository
    /// </summary>
    public class SiebelProblem
    {
        public string Category;
        public string Details;
        public string Function;
        public int Line;
        public string Object;
        public string ScriptType;
        public string Type;

        /// <summary>
        ///     Full constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="details"></param>
        /// <param name="obj"></param>
        /// <param name="scriptType"></param>
        /// <param name="function"></param>
        /// <param name="line"></param>
        public SiebelProblem(string type, string category, string details, string obj, string scriptType,
            string function, int line)
        {
            Type = type;
            Category = category;
            Details = details;
            Object = obj;
            ScriptType = scriptType;
            Function = function;
            Line = line;
        }
    }
}