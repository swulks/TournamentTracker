using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    class TournamentModel
    {
        /// <summary>
        /// Tournament name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry type of the tournament
        /// </summary>
        public decimal EntryType { get; set; }
        /// <summary>
        /// Teams that have entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Prizes that can be awarded
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Numbers store
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();


    }
}
