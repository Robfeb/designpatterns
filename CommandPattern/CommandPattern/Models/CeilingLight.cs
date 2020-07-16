using System;
namespace CommandPattern.Models
{
    public class CeilingLight
    {
        readonly string name = "I'm a Ceiling Light";

        public CeilingLight()
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
        public void Dim()
        {
            Console.WriteLine($"{name} Dim!!");
        }
       
    }
}
