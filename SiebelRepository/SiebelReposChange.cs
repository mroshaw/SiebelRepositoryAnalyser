namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Represents a tree item in the 'Change Records' screen
    /// </summary>
    public class SiebelReposChange
    {
        public string CreatedBy;
        public string CreatedDate;
        public string ModBy;
        public string ModDate;
        public string Name;
        public string ObjectType;

        /// <summary>
        ///     Simple constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        public SiebelReposChange(int id, int parentId, string objectType, string name)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            ObjectType = objectType;
            ModBy = "";
            ModDate = "";
            CreatedBy = "";
            CreatedDate = "";
        }

        /// <summary>
        ///     Full constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="objectType"></param>
        /// <param name="name"></param>
        /// <param name="modBy"></param>
        /// <param name="modDate"></param>
        /// <param name="createBy"></param>
        /// <param name="createDate"></param>
        public SiebelReposChange(int id, int parentId, string objectType, string name, string modBy, string modDate,
            string createBy, string createDate)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            ObjectType = objectType;
            ModDate = modDate;
            ModBy = modBy;
            CreatedBy = createBy;
            CreatedDate = createDate;
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
    }
}