using System;
namespace Pickleball_PlayerManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player()
            {
                Name = "Olena",
                Age = 38,
                Rating = 3.5

            };

            player.PrintInfo();

        }   
    } 
}