using System;

namespace Interface_Bsp
{
    public class Team : IBesipielInterface
    {
        private string teamName;
        private string[] starPlayers;
        private int foundingDate;
        //Konstruktor
        public Team(string name, string[] players, int date)
        {
            TeamName = name;
            StarPlayers = players;
            FoundingDate = date;
        }
        //Methoden
        public string GetTeamName()
        {
            return TeamName;
        }
        public string[] GetStarPlayers()
        {
            return StarPlayers;
        }
        public int GetFoundingDate()
        {
            return FoundingDate;
        }

        //Properties
        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }
        public string[] StarPlayers
        {
            get
            {
                return starPlayers;
            }
            set
            {
                starPlayers = value;
            }
        }
        public int FoundingDate
        {
            get
            {
                return foundingDate;
            }
            set
            {
                foundingDate = value;
            }
        }
    }
}
