using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public float EntryFee { get; set; }
        public List<PlayerModel> EnteredPlayers { get; set; } = new List<PlayerModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchModel>> Rounds { get; set; } = new List<List<MatchModel>>();

        public TournamentModel()
        {

        }

        public TournamentModel(string tournamentName, float entryFee, List<PlayerModel> enteredPlayers, List<PrizeModel> prizes)
        {
            TournamentName = tournamentName;
            EntryFee = entryFee;
            EnteredPlayers = enteredPlayers;
            Prizes = prizes;
        }
    }
}
