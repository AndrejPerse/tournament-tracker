using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchEntryModel
    {
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the player.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Represents one player in the match.
        /// </summary>
        public PlayerModel PlayerCompeting { get; set; }

        /// <summary>
        /// Represents number of sets player scored.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// The unique identifier for the parent match.
        /// </summary>
        public int ParentMatchId { get; set; }

        /// <summary>
        /// Represents the match that player came from
        /// as a winner.
        /// </summary>
        public MatchModel ParentMatch { get; set; }
    }
}
