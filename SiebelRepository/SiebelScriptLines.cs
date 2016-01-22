namespace SiebelRepositoryWrapper
{
    /// <summary>
    ///     Class to represent all lines of script in a repository
    /// </summary>
    public class SiebelScriptLines
    {
        /// <summary>
        ///     Simply constructor
        /// </summary>
        public SiebelScriptLines()
        {
            ApplicationBsLine = 0;
            ApplicationSsLine = 0;
            AppletBsLine = 0;
            AppletSsLine = 0;
            BcbsLine = 0;
            BcssLine = 0;
            BsbsLine = 0;
            BsssLine = 0;

            AdjustApplicationBsLine = 0;
            AdjustApplicationSsLine = 0;
            AdjustAppletBsLine = 0;
            AdjustAppletSsLine = 0;
            AdjustBcbsLine = 0;
            AdjustBcssLine = 0;
            AdjustBsbsLine = 0;
            AdjustBsssLine = 0;

            TotalLine = 0;
            AdjustTotalLine = 0;
        }

        /// <summary>
        ///     Sets the default lines based on the version of the Siebel application
        /// </summary>
        /// <param name="version"></param>
        public SiebelScriptLines(string version)
        {
            switch (version)
            {
                case "7.8 SIA":
                    // Siebel 7.8
                    AdjustApplicationBsLine = 0;
                    AdjustApplicationSsLine = 0;
                    AdjustAppletBsLine = 0;
                    AdjustAppletSsLine = 0;
                    AdjustBcbsLine = 0;
                    AdjustBcssLine = 0;
                    AdjustBsbsLine = 0;
                    AdjustBsssLine = 0;
                    break;

                case "8.1 SIA":
                    // Siebel 8.1
                    AdjustApplicationBsLine = 0;
                    AdjustApplicationSsLine = 0;
                    AdjustAppletBsLine = 348;
                    AdjustAppletSsLine = 1181;
                    AdjustBcbsLine = 32;
                    AdjustBcssLine = 532;
                    AdjustBsbsLine = 0;
                    AdjustBsssLine = 27312;
                    break;

                case "8.2 SIA":
                    // Siebel 8.2
                    AdjustApplicationBsLine = 0;
                    AdjustApplicationSsLine = 0;
                    AdjustAppletBsLine = 514;
                    AdjustAppletSsLine = 1511;
                    AdjustBcbsLine = 36;
                    AdjustBcssLine = 669;
                    AdjustBsbsLine = 0;
                    AdjustBsssLine = 40238;
                    break;


                case "15.0":
                    // Siebel 15.0
                    AdjustApplicationBsLine = 0;
                    AdjustApplicationSsLine = 0;
                    AdjustAppletBsLine = 255;
                    AdjustAppletSsLine = 1375;
                    AdjustBcbsLine = 32;
                    AdjustBcssLine = 396;
                    AdjustBsbsLine = 6;
                    AdjustBsssLine = 22583;
                    break;

                default:
                    AdjustApplicationBsLine = 0;
                    AdjustApplicationSsLine = 0;
                    AdjustAppletBsLine = 0;
                    AdjustAppletSsLine = 0;
                    AdjustBcbsLine = 0;
                    AdjustBcssLine = 0;
                    AdjustBsbsLine = 0;
                    AdjustBsssLine = 0;
                    break;
            }

            TotalLine = 0;
            AdjustTotalLine = AdjustApplicationBsLine + AdjustApplicationSsLine + AdjustAppletBsLine +
                              AdjustAppletSsLine +
                              AdjustBcbsLine + AdjustBcssLine + AdjustBsbsLine + AdjustBsssLine;
        }

        public int ApplicationBsLine { get; set; }
        public int ApplicationSsLine { get; set; }
        public int AppletBsLine { get; set; }
        public int AppletSsLine { get; set; }
        public int BcbsLine { get; set; }
        public int BcssLine { get; set; }
        public int BsbsLine { get; set; }
        public int BsssLine { get; set; }

        public int AdjustApplicationBsLine { get; set; }
        public int AdjustApplicationSsLine { get; set; }
        public int AdjustAppletBsLine { get; set; }
        public int AdjustAppletSsLine { get; set; }
        public int AdjustBcbsLine { get; set; }
        public int AdjustBcssLine { get; set; }
        public int AdjustBsbsLine { get; set; }
        public int AdjustBsssLine { get; set; }

        public int TotalLine { get; set; }
        public int AdjustTotalLine { get; set; }
    }
}