using System;
using System.Collections.Generic;
using TournamentLib.DataAccess;

namespace TournamentLib
{
    public class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                FileConnector sql = new FileConnector();
                Connections.Add(sql);
            }
        }

        //public static string Conn(string str)
        //{
        //    return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        //}
    }
}
