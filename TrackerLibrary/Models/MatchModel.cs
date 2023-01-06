using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Represents list of two player competing.
        /// </summary>
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();

        /// <summary>
        /// The Id from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Represents the winning player.
        /// </summary>
        public PlayerModel Winner { get; set; }

        /// <summary>
        /// Represents the round this match was played in.
        /// </summary>
        public int MatchRound { get; set; }

        public string DisplayName
        {
            get
            {
                string matchName = "";

                foreach (MatchEntryModel entry in Entries)
                {
                    if (entry.PlayerCompeting != null)
                    {
                        if (Entries.Count == 1)
                        {
                            return $"{entry.PlayerCompeting.FullName} vs BYE";
                        }
                        else if (matchName.Length == 0)
                        {
                            matchName = entry.PlayerCompeting.FullName;
                        }
                        else
                        {
                            matchName += $" vs { entry.PlayerCompeting.FullName}";
                        }
                    }
                    else
                    {
                        return "Match TBD";
                    }
                }

                return matchName;
            }
        }
    }
}
