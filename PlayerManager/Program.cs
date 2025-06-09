using System;
using System.ComponentModel;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*var player = new Player()
            {
                Name = "Olena",
                Age = 38,
                Rating = 3.5

            };
            */
            List<Player> players = new List<Player>();

            Player player1 = new Player();
            player1.Name = "Olena";
            player1.Age = 38;
            player1.Rating = 3.5;

            Player player2 = new Player();
            player2.Name = "Anastasia";
            player2.Age = 27;
            player2.Rating = 3.5;

            Player player3 = new Player();
            player3.Name = "Alex";
            player3.Age = 28;
            player3.Rating = 3.0;

            Player player4 = new Player();
            player4.Name = "Tom";
            player4.Age = 40;
            player4.Rating = 3.0;


            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);


            foreach (Player player in players)
            {
                player.PrintInfo();
            }

            Match match = new Match();

        }   
    } 
}