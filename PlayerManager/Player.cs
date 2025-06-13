using System;
namespace Pickleball_PlayerManager
{
    public class Player
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
         public Player(string name, int age, double rating)
        {
            Name = name;
            Rating = rating;
            Age = age;
        }
 
      
         public string InputInfoPlayer()
        {
            return $"Name {Name}, Age: {Age}, Rating: {Rating}";
        }

        public string PrintInfo()

        {
                return $"Name {Name}, Age: {Age}, Rating: {Rating}"; 
        }
    }
}
