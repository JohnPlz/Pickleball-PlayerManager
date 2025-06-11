using System;
namespace Pickleball_PlayerManager
{
    public class Player
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
        public void InputInfoPlayer()
        {
            Console.Write("Enter the player´s name: ");
            Name = Console.ReadLine();
            Console.Write("Enter the player´s age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the player´s Rating: ");
            double Rating = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintInfo()
        {
         System.Console.WriteLine($"Name: {Name}, Age: {Age}, Rating: {Rating}");
        }

    
    }
}
