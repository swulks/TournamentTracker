using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id {get; set; }
        /// <summary>
        /// Members of the team 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Team Name
        /// </summary>
        public string TeamName { get; set; }

        
    }
}
