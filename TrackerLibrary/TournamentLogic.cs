using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<PlayerModel> randomizedPlayers = RandomizePlayerList(model.EnteredPlayers);
            int rounds = NumberOfRounds(randomizedPlayers.Count);
            int byes = NumberOfByes(rounds, randomizedPlayers.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedPlayers));

            CreateFutureRounds(model, rounds);
        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            List<MatchModel> toScore = new List<MatchModel>();

            foreach (List<MatchModel> round in model.Rounds)
            {
                foreach (MatchModel roundMatch in round)
                {
                    if ((roundMatch.Winner == null && roundMatch.Entries.Any(x => x.Score != 0)) || (roundMatch.Entries.Count == 1 && roundMatch.Winner == null))
                    {
                        toScore.Add(roundMatch);
                    }
                }
            }

            MarkWinnersInMatches(toScore);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatch(x));

            AdvanceWinners(toScore, model);
        }

        private static int CheckCurrentRound(this TournamentModel model)
        {
            int currentRound = 1;

            foreach (List<MatchModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    currentRound++;
                }
                //else
                //{
                //    return currentRound;
                //}
            }

            return currentRound;
            // Tournament is over
            //CompleteTournament(model);
        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);

            PlayerModel champion = model.Rounds.Last().First().Winner;
            PlayerModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.PlayerCompeting != champion).First().PlayerCompeting;

            if (model.Prizes.Count > 0)
            {
                float totalIncome = model.EnteredPlayers.Count * model.EntryFee;
            }
        }

        private static void AdvanceWinners(List<MatchModel> matchList, TournamentModel tournament)
        {
            foreach (MatchModel match in matchList)
            {
                foreach (List<MatchModel> round in tournament.Rounds)
                {
                    foreach (MatchModel roundMatch in round)
                    {
                        foreach (MatchEntryModel entry in roundMatch.Entries)
                        {
                            if (entry.ParentMatch != null)
                            {
                                if (entry.ParentMatch.Id == match.Id)
                                {
                                    entry.PlayerCompeting = match.Winner;
                                    GlobalConfig.Connection.UpdateMatch(roundMatch);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnersInMatches(List<MatchModel> matchList)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchModel match in matchList)
            {
                // check for BYE's
                if (match.Entries.Count == 1)
                {
                    match.Winner = match.Entries[0].PlayerCompeting;
                    continue;
                }

                // lesser score wins
                if (greaterWins == "0")
                {
                    if (match.Entries[0].Score < match.Entries[1].Score)
                    {
                        match.Winner = match.Entries[0].PlayerCompeting;
                    }
                    else if (match.Entries[0].Score > match.Entries[1].Score)
                    {
                        match.Winner = match.Entries[1].PlayerCompeting;
                    }
                    else
                    {
                        throw new Exception("Izenačen rezultat ni mogoč.");
                    }
                }
                else
                {
                    if (match.Entries[0].Score > match.Entries[1].Score)
                    {
                        match.Winner = match.Entries[0].PlayerCompeting;
                    }
                    else if (match.Entries[0].Score < match.Entries[1].Score)
                    {
                        match.Winner = match.Entries[1].PlayerCompeting;
                    }
                    else
                    {
                        throw new Exception("Izenačen rezultat ni mogoč.");
                    }
                }
            }
        }

        private static void CreateFutureRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchModel> previousRound = model.Rounds[0];
            List<MatchModel> currentRound = new List<MatchModel>();
            MatchModel currentMatch = new MatchModel();

            while (round <= rounds)
            {
                foreach (MatchModel match in previousRound)
                {
                    currentMatch.Entries.Add(new MatchEntryModel { ParentMatch = match });

                    if (currentMatch.Entries.Count > 1)
                    {
                        currentMatch.MatchRound = round;
                        currentRound.Add(currentMatch);
                        currentMatch = new MatchModel();
                    }
                }

                model.Rounds.Add(currentRound);
                previousRound = currentRound;
                currentRound = new List<MatchModel>();
                round++;
            }
        }

        private static List<MatchModel> CreateFirstRound(int byes, List<PlayerModel> players)
        {
            List<MatchModel> matches = new List<MatchModel>();
            MatchModel currentMatch = new MatchModel();

            foreach (PlayerModel player in players)
            {
                currentMatch.Entries.Add(new MatchEntryModel { PlayerCompeting = player });

                if (byes > 0 || currentMatch.Entries.Count > 1)
                {
                    currentMatch.MatchRound = 1;
                    matches.Add(currentMatch);
                    currentMatch = new MatchModel();

                    if (byes > 0)
                    {
                        byes--;
                    }
                }
            }

            return matches;
        }

        private static int NumberOfByes(int rounds, int playerCount)
        {
            int byes = 0;
            int maxTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                maxTeams *= 2;
            }

            byes = maxTeams - playerCount;

            return byes;
        }

        private static int NumberOfRounds(int playerCount)
        {
            int rounds = 1;
            int value = 2;

            while (value < playerCount)
            {
                rounds++;
                value *= 2;
            }

            return rounds;
        }

        private static List<PlayerModel> RandomizePlayerList(List<PlayerModel> players)
        {
            return players.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
