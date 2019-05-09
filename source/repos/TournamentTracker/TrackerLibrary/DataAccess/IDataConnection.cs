﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel teamModel);

        List<PersonModel> GetPerson_All();

        List<TeamModel> GetTeam_All();

        List<PrizeModel> GetPrizes_All();
       
    }
    
}
