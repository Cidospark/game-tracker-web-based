using System;
using TournamentLib.Models;

namespace TournamentLib.DataAccess
{
    public class FileConnector : IDataConnection
    {
        public FileConnector()
        {
        }

        public Prize CreatePrize(Prize model)
        {
            model.Id = 1;
            return model;
        }
    }
}
