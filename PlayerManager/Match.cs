using System;
namespace Pickleball_PlayerManager
{
    public class Match
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player? Gewinner { get; set; }

        public void PlayMatch()
        {
            if (Player1 is null || Player2 is null)
            {
                throw new ArgumentException("Player1 oder 2 dürfen nicht NULL sein");
            }
        }
    }
}