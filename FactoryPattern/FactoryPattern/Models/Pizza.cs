using System;
namespace FactoryPattern.Models
{
    public class Pizza
    {
        public string description = "default pizza";

        public void Prepare()
        {
            Console.WriteLine($"Preparing the {description} !...");
        }
        public void Bake() {
            Console.WriteLine($"Baking the {description}! 25 minutes at 250ºC ");
        }
        public void Cut() {
            Console.WriteLine($"Cutting the {description}! 16 portions");
        }
        public void Box() {
            Console.WriteLine($"Boxing the {description}!");
        }

    }
}
