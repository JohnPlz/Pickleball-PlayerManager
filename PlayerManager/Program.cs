using System;
using System.ComponentModel;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.Write("Enter the number of players: ");
            // int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Player[] players_array = [
                new Player("Olena", 28, 3.5),
                new Player("Ioannis", 23, 3),
                new Player("Sofi", 21, 1),
            ];

            for (int i = 0; i < players_array.Length; i++)
            {
                System.Console.WriteLine("Player {0}", i + 1);
                System.Console.WriteLine(players_array[i].PrintInfo());
            }
        }
    }
}