using System;
using System.ComponentModel;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Player player1 = new Player("Anna", 50, 6);
            Player player2 = new Player("Tom", 40, 4.5);

            
            Match match = new Match();
            match.Player1 = player1;
            match.Player2 = player2;
            match.PlayMatch();
            match.PrintResult();
        }   
    } 
}