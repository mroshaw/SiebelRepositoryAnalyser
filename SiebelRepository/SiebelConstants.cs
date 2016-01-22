namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Static Class providing access to Siebel Integer Constants
    ///     See http://docs.oracle.com/cd/E14004_01/books/OIRef/Using_Siebel_VB_and_Siebel_eScript4.html
    /// </summary>
    public static class SiebelConstants
    {
        public static short ContinueOperation = 1;
        public static short CancelOperation = 2;
        public static short ForwardBackward = 256;
        public static short ForwardOnly = 257;
        public static short NewBefore = 0;
        public static short NewBeforeCopy = 2;
        public static short NewAfterCopy = 3;
        public static short SalesRepView = 0;
        public static short ManagerView = 1;
        public static short PersonalView = 2;
        public static short AllView = 3;
        public static short OrganizationView = 5;
        public static short GroupView = 7;
        public static short CatalogView = 8;
        public static short SubOrganizationView = 9;
    }
}