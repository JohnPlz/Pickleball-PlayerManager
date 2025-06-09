using System;
namespace Pickleball_PlayerManager
{
    public class Player
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }

        public void PrintInfo()
        {
            System.Console.WriteLine(Name);
            //System.Console.WriteLine($"Name: {Name}, Age: {Age}, Rating: {Rating}");
        }
    }
}
