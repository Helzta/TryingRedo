using System;
using System.Collections.Generic;

namespace Stort
{
    public class League
    {
        public static List<League> leagueData = new List<League>();
        public List<Team> divTeam = new List<Team>();
        public string divName;
        public int tier;
        public static void CreateLeagues()
        {
            League Japan1 = new League();
            League Japan2 = new League();
            League Japan3 = new League();

            Japan1.divName = "V.League 1";
            Japan1.tier = 1;
            Japan2.divName = "V.League 2";
            Japan2.tier = 2;
            Japan3.divName = "V.League 3";
            Japan3.tier = 2;
            
            leagueData.Add(Japan1);
            leagueData.Add(Japan2);
            leagueData.Add(Japan3);
            Team.CreateTeams();
        }
    }
}
