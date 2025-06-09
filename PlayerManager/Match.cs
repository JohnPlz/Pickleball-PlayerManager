using System;
namespace Pickleball_PlayerManager
{


    public class Match
    {
        public Match()
        {
            int player1Score = new Random().Next(0, 11);
            int player2Score = new Random().Next(0, 11);
            System.Console.WriteLine("--------");
            System.Console.WriteLine("Score:");
            System.Console.WriteLine("player1: " + player1Score);
            System.Console.WriteLine("player2: " + player2Score);
            

           
            
                if (player1Score > player2Score)
            {
                System.Console.WriteLine("!!!! Player 1  gewinnt!!!! ");
            }

            else if (player1Score < player2Score)
            {
                System.Console.WriteLine("Player 2  gewinnt");
            }
            else
            {

                System.Console.WriteLine("player1Score = player2Score");
            }
            
}        
        }
}
