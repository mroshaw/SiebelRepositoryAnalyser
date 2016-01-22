using System.Collections.Generic;

namespace SiebelRepositoryWrapper
{
    internal class RepositorylBusComp
    {
        public RepositorylBusComp(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<SiebelProblem> GetBusCompProblems(ConfigSettings settings)
        {
            var problemList = new List<SiebelProblem>();
            return problemList;
        }
    }
}