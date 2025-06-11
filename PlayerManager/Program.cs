using System;
using System.ComponentModel;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.InputInfoPlayer();
            Player player2 = new Player();
            player2.InputInfoPlayer();
            System.Console.WriteLine("Players: ");
            player1.PrintInfo();
            player2.PrintInfo();

        }   
    } 
}