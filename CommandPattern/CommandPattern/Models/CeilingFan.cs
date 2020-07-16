using System;
namespace CommandPattern.Models
{
    public class CeilingFan
    {
        readonly string name = "I'm a Ceiling Fan";

        public CeilingFan()
        {
        }
        public void High()
        {
            Console.WriteLine($"{name} High!!");
        }
        public void Medium()
        {
            Console.WriteLine($"{name} Medium!!");
        }
        public void Low()
        {
            Console.WriteLine($"{name} Low!!");
        }
        public void GetSpeed()
        {
            Console.WriteLine($"{name} GetSpeed!!");
        }
        public void Off()
        {
            Console.WriteLine($"{name} Off!!");
        }
    }
}
