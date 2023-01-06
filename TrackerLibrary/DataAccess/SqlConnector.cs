using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "TournamentsDatabase";

        /// <summary>
        /// Saves a new player to the database
        /// </summary>
        /// <param name="playerModel"></param>
        /// <returns></returns>
        public void CreatePlayer(PlayerModel playerModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", playerModel.FirstName);
                parameters.Add("@LastName", playerModel.LastName);
                parameters.Add("@EmailAddress", playerModel.EmailAddress);
                parameters.Add("@PhoneNumber", playerModel.PhoneNumber);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPlayer_Insert", parameters, commandType: CommandType.StoredProcedure);

                playerModel.Id = parameters.Get<int>("@id");
            }
        }

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="prizeModel">The prize information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public void CreatePrize(PrizeModel prizeModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PrizePlace", prizeModel.PrizePlace);
                parameters.Add("@PrizeName", prizeModel.PrizeName);
                parameters.Add("@PrizeMoney", prizeModel.PrizeMoney);
                parameters.Add("@PrizeMaterial", prizeModel.PrizeMaterial);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrize_Insert", parameters, commandType: CommandType.StoredProcedure);

                prizeModel.Id = parameters.Get<int>("@id");
            }
        }

        public void CreateTournament(TournamentModel tournamentModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                SaveTournament(connection, tournamentModel);

                SaveTournamentEntries(connection, tournamentModel);

                SaveTournamentPrizes(connection, tournamentModel);

                SaveTournamentRounds(connection, tournamentModel);

                TournamentLogic.UpdateTournamentResults(tournamentModel);
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel tournamentModel)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@TournamentName", tournamentModel.TournamentName);
            parameters.Add("@EntryFee", tournamentModel.EntryFee);
            parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournament_Insert", parameters, commandType: CommandType.StoredProcedure);

            tournamentModel.Id = parameters.Get<int>("@id");
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel tournamentModel)
        {
            var parameters = new DynamicParameters();

            foreach (PlayerModel player in tournamentModel.EnteredPlayers)
            {
                parameters = new DynamicParameters();
                parameters.Add("@TournamentId", tournamentModel.Id);
                parameters.Add("@PlayerId", player.Id);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntry_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel tournamentModel)
        {
            var parameters = new DynamicParameters();

            foreach (PrizeModel prize in tournamentModel.Prizes)
            {
                parameters = new DynamicParameters();
                parameters.Add("@TournamentId", tournamentModel.Id);
                parameters.Add("@PrizeId", prize.Id);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrize_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel tournamentModel)
        {
            foreach (List<MatchModel> round in tournamentModel.Rounds)
            {
                foreach (MatchModel match in round)
                {
                    var parameters = new DynamicParameters();

                    parameters.Add("@TournamentId", tournamentModel.Id);
                    parameters.Add("@MatchRound", match.MatchRound);
                    parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatch_Insert", parameters, commandType: CommandType.StoredProcedure);

                    match.Id = parameters.Get<int>("@id");

                    foreach (MatchEntryModel entry in match.Entries)
                    {
                        parameters = new DynamicParameters();

                        parameters.Add("@MatchId", match.Id);

                        if (entry.ParentMatch == null)
                        {
                            parameters.Add("@ParentMatchId", null);
                        }
                        else
                        {
                            parameters.Add("@ParentMatchId", entry.ParentMatch.Id);
                        }

                        if (entry.PlayerCompeting == null)
                        {
                            parameters.Add("@PlayerId", null);
                        }
                        else
                        {
                            parameters.Add("@PlayerId", entry.PlayerCompeting.Id);
                        }

                        parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchEntry_Insert", parameters, commandType: CommandType.StoredProcedure);

                        entry.Id = parameters.Get<int>("@id");
                    }
                }
            }
        }

        public List<PlayerModel> GetPlayer_All()
        {
            List<PlayerModel> playerList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                playerList = connection.Query<PlayerModel>("dbo.spPlayer_GetAll").ToList();
            }

            return playerList;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> tournamentList;

            var parameters = new DynamicParameters();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                tournamentList = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();

                foreach (TournamentModel tournament in tournamentList)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@TournamentId", tournament.Id);

                    // Populate prizes
                    tournament.Prizes = connection.Query<PrizeModel>("dbo.spPrize_GetByTournament", parameters, commandType: CommandType.StoredProcedure).ToList();

                    // Populate players
                    tournament.EnteredPlayers = connection.Query<PlayerModel>("dbo.spPlayer_GetByTournament", parameters, commandType: CommandType.StoredProcedure).ToList();

                    // Populate rounds
                    List<MatchModel> matches = connection.Query<MatchModel>("dbo.spMatch_GetByTournament", parameters, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchModel match in matches)
                    {
                        parameters = new DynamicParameters();
                        parameters.Add("@MatchId", match.Id);

                        match.Entries = connection.Query<MatchEntryModel>("dbo.spMatchEntry_GetByMatch", parameters, commandType: CommandType.StoredProcedure).ToList();

                        List<PlayerModel> allPlayers = GetPlayer_All();

                        if (match.WinnerId > 0)
                        {
                            match.Winner = allPlayers.Where(x => x.Id == match.WinnerId).First();
                        }

                        foreach (var entry in match.Entries)
                        {
                            if (entry.PlayerId > 0)
                            {
                                entry.PlayerCompeting = allPlayers.Where(x => x.Id == entry.PlayerId).First();
                            }

                            if (entry.ParentMatchId > 0)
                            {
                                entry.ParentMatch = matches.Where(x => x.Id == entry.ParentMatchId).First();
                            }
                        }
                    }

                    List<MatchModel> currentRow = new List<MatchModel>();
                    int currentRound = 1;

                    foreach (MatchModel match in matches)
                    {
                        if (match.MatchRound > currentRound)
                        {
                            tournament.Rounds.Add(currentRow);
                            currentRow = new List<MatchModel>();
                            currentRound++;
                        }

                        currentRow.Add(match);
                    }

                    tournament.Rounds.Add(currentRow);
                }
            }

            return tournamentList;
        }

        public void UpdateMatch(MatchModel matchModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                if (matchModel.Winner != null)
                {
                    parameters.Add("@Id", matchModel.Id);
                    parameters.Add("@WinnerId", matchModel.Winner.Id);

                    connection.Execute("dbo.spMatch_Update", parameters, commandType: CommandType.StoredProcedure);
                }

                foreach (MatchEntryModel entry in matchModel.Entries)
                {
                    if (entry.PlayerCompeting != null)
                    {
                        parameters = new DynamicParameters();
                        parameters.Add("@Id", entry.Id);
                        parameters.Add("@PlayerId", entry.PlayerCompeting.Id);
                        parameters.Add("@Score", entry.Score);

                        connection.Execute("dbo.spMatchEntry_Update", parameters, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        // TODO - Complete Tournament funcionality
        public void CompleteTournament(TournamentModel tournamentModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", tournamentModel.Id);

                connection.Execute("dbo.spTournament_Complete", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
