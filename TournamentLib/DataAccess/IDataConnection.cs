using System;
using TournamentLib.Models;

namespace TournamentLib.DataAccess
{
    public interface IDataConnection
    {
        Prize CreatePrize(Prize model);
    }
}
