#region

using System;
using SiebelBusObjectInterfaces;
using TWSiebelLib;

#endregion

namespace SiebelRepositoryWrapper
{
    internal class SiebelAppWrapper
    {
        public static short ServerCon = 1;
        public static short ClientCon = 2;
        public dynamic SiebelAppInstance;
        private Boolean _connected;

        private string _enterprise;
        private string _host;
        private string _om;
        private string _password;
        private string _userName;

        // Server constructor
        public SiebelAppWrapper()
        {
            _connected = false;
        }

        public short ConType { get; set; }

        public void InitServer(string userName, string password, string host, string enterprise, string om)
        {
            ConType = ServerCon;

            _userName = userName;
            _password = password;
            _host = host;
            _enterprise = enterprise;
            _om = om;
            SiebelAppInstance = new SiebelDataControl();
        }

        public void InitClient()
        {
            ConType = ClientCon;
            SiebelAppInstance = new SiebelWebApplication();
        }

        // Generic Connect method
        public void Connect()
        {
            {
                // Create new connection to Siebel instace

                // Manage the Server case
                if (ConType == ServerCon)
                {
                    try
                    {
                        // Construct Connect String
                        string connUrl = "host=\"siebel://" + _host + "/" + _enterprise + "/" + _om + "\"";

                        // Login
                        SiebelAppInstance.Login(connUrl, _userName, _password);

                        // Determine if log was succesfull
                        int errCode = SiebelAppInstance.GetLastErrCode();

                        // Raise a custom exception for consumption by calling code
                        _connected = errCode == 0;
                    }
                    catch (Exception)
                    {
                        _connected = false;
                    }
                }
                else
                {
                    // Client already there so simply test that we can talk to it
                    try
                    {
                        string dummy = SiebelAppInstance.LoginName();
                        _connected = true;
                    }
                    catch (Exception)
                    {
                        _connected = false;
                    }
                }
            }
        }

        public Boolean IsConnected()
        {
            return _connected;
        }

        /// <summary>
        ///     Disconnct from Siebel OM
        /// </summary>
        public void Disconnect()
        {
            if (ConType == ServerCon)
            {
                SiebelAppInstance.Logoff();
            }

            SiebelAppInstance = null;
            _connected = false;
        }
    }
}