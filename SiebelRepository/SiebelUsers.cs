namespace SiebelRepositoryWrapper
{
    public class SiebelUsers
    {
        public SiebelUsers(string id, string login)
        {
            Id = id;
            Login = login;
        }

        public string Id { get; set; }
        public string Login { get; set; }
    }
}