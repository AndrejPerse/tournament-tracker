using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePlayer(PlayerModel playerModel);
        void CreatePrize(PrizeModel prizeModel);
        void CreateTournament(TournamentModel tournamentModel);
        void UpdateMatch(MatchModel matchModel);
        void CompleteTournament(TournamentModel tournamentModel);
        List<PlayerModel> GetPlayer_All();
        List<TournamentModel> GetTournament_All();
    }
}
