using System;
namespace CommandPattern.Models
{
    public class GarageDoor
    {
        readonly string name = "I'm a Garage Door";

        public GarageDoor()
        {
        }
        public void Up()
        {
            Console.WriteLine($"{name} Up!!");
        }
        public void Down()
        {
            Console.WriteLine($"{name} Down!!");
        }
        public void Stop()
        {
            Console.WriteLine($"{name} Stop!!");
        }
        public void High()
        {
            Console.WriteLine($"{name} High!!");
        }
        public void LightOn()
        {
            Console.WriteLine($"{name} LightOn!!");
        }
        public void LightOff()
        {
            Console.WriteLine($"{name} LowLightOff");
        }
        
    }
}
