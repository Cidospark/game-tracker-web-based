using System;
using TournamentLib.Models;

namespace TournamentLib.DataAccess
{
    /// <summary>
    /// <connectionStrings>
    ///     <add name="Tournaments" connectionString="Server=.\sql2016;Database=Tournaments;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
    /// </connectionStrings>
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        // TODO - Wire up with Dapper
        public SqlConnector()
        {
        }

        public Prize CreatePrize(Prize model)
        {
            model.Id = 1;
            return model;
        }
    }
}