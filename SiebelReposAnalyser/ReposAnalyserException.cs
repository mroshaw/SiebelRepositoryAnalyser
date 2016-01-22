#region

using System;
using System.Runtime.Serialization;

#endregion

namespace SiebelReposAnalyser
{
    /// <summary>
    ///     Custom exception class
    /// </summary>
    internal class ReposAnalyserException : Exception
    {
        public ReposAnalyserException()
        {
        }

        public ReposAnalyserException(string message)
            : base(message)
        {
        }

        public ReposAnalyserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ReposAnalyserException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}