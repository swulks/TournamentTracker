using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
//*Load the text file
//Convert the text to List<>
//Find the  max ID
//Add the new record with the new ID
//Add the new prizes to list<string>
//Save the list <string> to the text file
namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcesser
    {
        public static string FullFilePath(this string fileName)
        {
            //C:\data\TournamentTracker\PrizeModels
            return $"{ ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        //Prize//
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");

            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //Person//
        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModel(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personId = cols[2].Split('|');

                foreach (string id in personId)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());

                }
                output.Add(t);
            }
            
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines, 
            string TeamFileName, 
            string PeopleFileName,
            string PrizeFileName)
        {
            //id, tournamentName, EntryFee, 
            //(id | id | id - Teams), 
            //(id | id | id - Prizes), 
            //(id^id^id | id^id^id^ | id^id^id^ - Rounds)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = TeamFileName.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFileName);
            List<PrizeModel> prizes = PrizeFileName.FullFilePath().LoadFile().ConvertToPrizeModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamId = cols[3].Split('|');

                foreach (string id in teamId)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeId = cols[4].Split('|');

                foreach (string id in prizeId)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());                    
                }
                //TODO Create matchup 

                output.Add(tm);
            }
            return output;
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id}, {p.FirstName}, {p.LastName}, {p.EmailAddress}, {p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id}, {t.TeamName}, {ConvertPeopleListToString(t.TeamMembers)}");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTournamentsFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($@"{tm.Id},
                             {tm.TournamentName},
                             {tm.EntryFee},
                             {ConvertTeamListToString(tm.EnteredTeams)},
                             {ConvertPrizeListToString(tm.Prizes)},
                             {ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return output;
            }
            foreach (MatchupModel p in matchups)
            {
                output += $"{p.Id}^";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return output;
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return output;
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return output;
            }
            foreach (TeamModel p in teams)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if ( people.Count == 0)
            {
                return output;
            }
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
