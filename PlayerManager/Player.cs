using System;
namespace Pickleball_PlayerManager
{
    public class Player
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
        public void InputInfoPlayer(int number)
        {
            System.Console.WriteLine($"\nEnter the players {number}: ");
            Console.Write("name: ");
            Name = Console.ReadLine();
            Console.Write("age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rating: ");
            Rating = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintInfo(int number)
        {

            System.Console.WriteLine($" Player {number}:");
            System.Console.WriteLine($" Name {Name}, Age: {Age}, Rating: {Rating}");
        }


    }
}
