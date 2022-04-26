using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Bsp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] starPlayersOfZvezda = { "Aleksandar Katai", "Milan Borjan", "El Fardu Ben" };
            Team crvenaZvezda = new Team("FK Crvena Zvezda", starPlayersOfZvezda, 1945);
            string[] starPlayersOfMadrid = { "Karim Benzema", "Thibaut Cortoius", "Luka Modric" };
            Team realMadrid = new Team("Real Madrid", starPlayersOfMadrid, 1902);
            string[] starPlayersOfBayern = { "Robert Lewandowski", "Thomas Müller", "Manuel Neuer" };
            Team bayernMuenchen = new Team("FC Bayern München", starPlayersOfBayern, 1900);
            string[] starPlayersOfLinz = { "Anteo Fetahu", "Aleksandar Kostic", "Michael Brandner" };
            Team blauWeissLinz = new Team("FC Blau-Weiss Linz", starPlayersOfLinz, 1997);
            Team[] allTeams = { crvenaZvezda, realMadrid, bayernMuenchen, blauWeissLinz };
            Print(allTeams);
        }
        static void Print(Team[] teams)
        {
            foreach (var item in teams)
            {
                string[] starPlayersOfTeam = item.GetStarPlayers();
                Console.WriteLine("Das Team {0} mit den Star Spielern...", item.GetTeamName());
                for (int i = 0; i < item.StarPlayers.Length; i++)
                {
                    Console.WriteLine(starPlayersOfTeam[i]);
                }
                Console.WriteLine("wurde gegründet im Jahre {0}", item.GetFoundingDate());
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
