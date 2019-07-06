using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//@PlaceNumber int,
//@PlaceName nvarchar(50),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int = 0 output

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize info</param>
        /// <returns></returns>

        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", teamModel.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                teamModel.Id = p.Get<int>("@id");

                foreach (PersonModel tm in teamModel.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", teamModel.Id);
                    p.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return teamModel;

            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }
  
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);   
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p,commandType:CommandType.StoredProcedure).ToList();

                }
            }
            return output;
        }

        public List<PrizeModel> GetPrizes_All()
        {
            List<PrizeModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PrizeModel>("dbo.spPrizes_GetAll").ToList();

            }

            return output;
        }

        public void CreateTournament(TournamentModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                
                //Saving Tournament
                SaveTournament(connection, model);

                //Saving Tournament Prizes
                SaveTournamentPrizes(connection, model);

                //Saving Tournament Teams
                SaveTournamentTeams(connection, model);
                
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentTeams(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntryes_Insert ", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
