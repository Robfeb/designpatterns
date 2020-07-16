using System;
namespace CommandPattern.Models
{
    public class OutdoorLight
    {
        readonly string name = "I'm a OutdoorLight";

        public OutdoorLight()
        {
        }
        public void On()
        {
            Console.WriteLine($"{name} On!!");
        }
        public void Off()
        {
            Console.WriteLine($"{name} Off!!");
        }
    }
}
