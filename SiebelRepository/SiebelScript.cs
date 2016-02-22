#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

#endregion

namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Class to represent a single eScript 'script'
    /// </summary>
    internal class SiebelScript
    {
        public string MethodName;
        public string ObjectName;
        public string ObjectType;
        public string ScriptCode;
        public string ScriptType;

        /// <summary>
        ///     Simple constructor
        /// </summary>
        /// <param name="scriptCode"></param>
        public SiebelScript(string scriptCode)
        {
            ScriptCode = scriptCode;
        }

        /// <summary>
        ///     Full constructor
        /// </summary>
        /// <param name="scriptCode"></param>
        /// <param name="objectName"></param>
        /// <param name="methodName"></param>
        /// <param name="objectType"></param>
        /// <param name="scriptType"></param>
        public SiebelScript(string scriptCode, string objectName, string methodName, string objectType, string scriptType)
        {
            ScriptCode = scriptCode;
            ObjectName = objectName;
            MethodName = methodName;
            ObjectType = objectType;
            ScriptType = scriptType;
        }

        /// <summary>
        ///     Returns the number of lines of code in the script
        /// </summary>
        /// <returns></returns>
        public int NumberOfLines()
        {
            // var re = new Regex(@"\r?\n^\s+", RegexOptions.Multiline);
            // var re = new Regex(@"^.*\S.*\r?$", RegexOptions.Multiline);
            Regex re = new Regex(@"^(?![ \s]*\r?\n|import|package|[ \s]*}\r?\n|[ \s]*//|[ \s]*/\*|[ \s]*\*).*\r?\n",
                RegexOptions.Multiline);
            int count = re.Matches(ScriptCode).Count + 1;

            return count;
        }

        /// <summary>
        ///     Return a list of problems in the script
        /// </summary>
        /// <param name="problemList"></param>
        /// <param name="settings"></param>
        public void GetScriptProblems(List<SiebelProblem> problemList, ScriptSettings settings)
        {
            Boolean checkFinally = settings.CheckRetInFinally;
            Boolean checkDestroy = settings.CheckDestruction;
            Boolean checkForBack = settings.CheckForwardBackward;
            Boolean checkComments = settings.CheckNoComments;

            if (checkFinally)
            {
                GetRetInFinally(problemList);
            }
            if (checkDestroy || checkForBack)
            {
                ParseScriptLines(problemList, checkDestroy, checkForBack);
            }
            if (checkComments)
            {
                CheckForComments(problemList);
            }
        }

        private void CheckForComments(List<SiebelProblem> problemList)
        {
            // Process 'Comments' checks
            int commentLocation = ScriptCode.IndexOf("//", StringComparison.Ordinal);
            if (commentLocation == -1)
            {
                commentLocation = ScriptCode.IndexOf("/*", StringComparison.Ordinal);
            }

            if (commentLocation == -1)
            {
                problemList.Add(new SiebelProblem(ObjectType, "Low", "No comments in method definition", ObjectName,
                    ScriptType, MethodName, 0));
            }
        }

        /// <summary>
        ///     Parse the code and populate a list of problems
        ///     related to use of 'return' in the finally block
        /// </summary>
        /// <param name="problemList"></param>
        private void GetRetInFinally(List<SiebelProblem> problemList)
        {
            // Process 'Finally' checks
            int finallyLocation = ScriptCode.IndexOf("finally", StringComparison.Ordinal);

            if (finallyLocation <= 0) return;
            string tempCode = ScriptCode.Substring(finallyLocation);
            tempCode = GetBlock(tempCode);
            if (tempCode.IndexOf("return", StringComparison.Ordinal) > 0)
            {
                problemList.Add(new SiebelProblem(ObjectType, "Medium",
                    "Returning from finally block not recommended", ObjectName, ScriptType, MethodName, 0));
            }
        }

        /// <summary>
        ///     Returns the code in between the first opening bracket { and it's matching closing bracket }
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private static string GetBlock(string code)
        {
            if (code == null)
                return "";
            // Keep count of open bracks
            int openBrackets = 0;
            // Start at first bracket
            int pos = code.IndexOf("{", StringComparison.Ordinal);
            int len = code.Length;

            if (pos == 0 || len == 0)
                return "";

            do
            {
                // Parse code and count closing brackets until we find the matching one
                string curChar = code.Substring(pos, 1);
                if (curChar == "{") openBrackets++;
                if (curChar == "}") openBrackets--;
                pos++;
            } while (openBrackets != 0 || pos == len);

            // Return the block
            return code.Substring(1, pos);
        }

        public void Search(string searchTerm, List<SearchResults> results, Boolean ignoreCase)
        {
            var compare = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;

            int lineCount = 0;
            string[] lines = Regex.Split(ScriptCode, "\n");
            foreach (string line in lines)
            {
                lineCount++;
                if (line.IndexOf(searchTerm, compare) != -1)
                {
                    results.Add(new SearchResults(lineCount, ScriptCode, searchTerm, ObjectType, ObjectName, MethodName, ScriptType));
                }
            }
        }

        private void ParseScriptLines(List<SiebelProblem> problemList, bool checkDestroy, bool checkForBack)
        {
            // Maintain a list of objects that have been initialised
            List<String> objectsInit = new List<String>();

            string[] lines = Regex.Split(ScriptCode, "\n");
            char[] charSeparators = {' ', '(', ')', '.', ',', '\t', ';'};
            char[] destSeparators = { '=', ';' };

            int createOperatorIndx = -1;

            int lineCount = 0;
            Regex regComment = new Regex("^[/][/]");
            Regex regInMultiComment = new Regex("^[/][*]");
            Regex regOutMultiComment = new Regex(@"[*][/]$");
            bool inComment = false;
            // var re = new Regex(@"^(?![ \s]*\r?\n|import|package|[ \s]*}\r?\n|[ \s]*//|[ \s]*/\*|[ \s]*\*).*\r?\n");
            foreach (string line in lines)
            {
                lineCount++;
                String trimmedLine = line.Trim();
                string[] words = trimmedLine.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (regInMultiComment.IsMatch(trimmedLine))
                {
                    inComment = true;
                    continue;
                }

                if (regOutMultiComment.IsMatch(trimmedLine))
                {
                    inComment = false;
                    continue;
                }

                // If we're not in a comment block or comment line
                if (inComment || regComment.IsMatch(line)) continue;
                // Pick up use of 'ForwardBackward'
                if (checkForBack)
                {
                    if (words.Contains("ForwardBackward"))
                    {
                        problemList.Add(new SiebelProblem(ObjectType, "Low", "Consider using ForwardOnly",
                            ObjectName, ScriptType, MethodName, lineCount));
                    }
                }

                if (!checkDestroy) continue;
                // If we initialise an Object Type
                if (words.Contains("GetBusObject"))
                {
                    createOperatorIndx = Array.IndexOf(words, "GetBusObject");
                }
                        
                if (words.Contains("GetBusComp"))
                {
                    createOperatorIndx = Array.IndexOf(words, "GetBusComp");
                }
                        
                if (words.Contains("GetService"))
                {
                    createOperatorIndx = Array.IndexOf(words, "GetService");
                }
                        
                if (words.Contains("NewPropertySet"))
                {
                    createOperatorIndx = Array.IndexOf(words, "NewPropertySet");
                }
                        

                string objName;
                if (createOperatorIndx > 0)
                {
                    // Find the object name and add to our list
                    int equalsIndx = Array.IndexOf(words, "=");
                    if (equalsIndx > 0 && equalsIndx < createOperatorIndx && words[0] != "//")
                    {
                        objName = words[equalsIndx - 1].Trim();
                        objectsInit.Add(objName);
                    }
                    createOperatorIndx = -1;
                }

                // If we destroy an object, remove from the list
                if (words.Contains("null"))
                {
                    int destroyIndx = Array.IndexOf(words, "null");
                    if (destroyIndx <= 1 || words[0] == "//") continue;
                    // Find the object name and remove from our list
                    // Regex.Replace(words, @"\s+", "");
                    if (words[destroyIndx - 1] == "=")
                    {
                        objName = words[destroyIndx - 2].Trim();
                        objectsInit.Remove(objName);
                        continue;
                    }
                }
                // Check in case no spaces
                string[] words2 = trimmedLine.Split(destSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (words2.Length > 1 && words2[1].Trim() == "null")
                {
                    objName = words2[0].Trim();
                    if (objectsInit.Contains(objName))
                    {
                        objectsInit.Remove(objName);
                    }
                }
            }
            // Determine results
            if (objectsInit.Count <= 0) return;
            string cs = string.Join<string>(",", objectsInit);
            problemList.Add(new SiebelProblem(ObjectType, "High",
                "Initialised objects are not destroyed (" + cs + ")", ObjectName, ScriptType, MethodName, 0));
        }
    }
}