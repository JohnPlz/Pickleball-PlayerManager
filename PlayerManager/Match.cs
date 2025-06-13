/*PlayMatch()
Der Spieler mit höherem Rating gewinnt.
Wenn beide Spieler ein gleiches Rating haben, wird per Zufall gewonnen.
PrintResult()
Gibt an, wer gegen wen gespielt hat und wer gewonnen hat.
*/

using System;
namespace Pickleball_PlayerManager
{


    public class Match
    {
        public Player Player1 { get; set; } = null!;
        public Player Player2 { get; set; } =null!;
        //public Player[] Players { get; set; }
        public Player? Gewinner { get; set; }
       //  public Player(string name, int age, double rating)
       // {
        //    Name = name;
        //    Rating = rating;
         //   Age = age;
      //  }

         
        public void PlayMatch()
        {
            if (Player1.Rating > Player2.Rating)
            {
                Gewinner = Player1;
            }
            else if (Player2.Rating > Player1.Rating)
            {
                Gewinner = Player2;
            }
            else
            {
                Random random = new Random();
                int zufallsZal = random.Next(2);
                Gewinner = (zufallsZal == 0) ? Player1 : Player2;

            }
        }
        
        public void PrintResult()
        {if (Gewinner != null)
            { Console.WriteLine("Gewinner: " + Gewinner.PrintInfo());
                Console.WriteLine("Player1: " + Player1.PrintInfo());
                Console.WriteLine("Player2: " + Player2.PrintInfo());
            }
            else
            {
                Console.WriteLine("Der Gewinnersteht noch nicht fest");
            }
        
        }
    }
}
