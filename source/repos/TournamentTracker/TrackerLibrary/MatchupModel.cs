using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represent entries 
        /// </summary>
        public List<MatchupEntryModel> Enries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Stores the winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Stores the match round
        /// </summary>
        public int MatchupRound { get; set; }
    }
}