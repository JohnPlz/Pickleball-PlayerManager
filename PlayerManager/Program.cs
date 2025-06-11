using System;
using System.ComponentModel;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {   Console.Write("Enter the number of players: ");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Player[] players_array = new Player[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players_array[i] = new Player();
                players_array[i].InputInfoPlayer(i+1);
            }
            System.Console.WriteLine("*************************");
                for (int i = 0; i < numberOfPlayers; i++)
                {
                players_array[i].PrintInfo(i+1);
            }
        }   
    } 
}