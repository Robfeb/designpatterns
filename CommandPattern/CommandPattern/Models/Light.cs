using System;
namespace CommandPattern.Models
{
    public class Light
    {
        readonly string name = "I'm a Light";
        public Light(string room)
        {
            name += " " + room;
        }
        public void On() {
            Console.WriteLine($"{name} On!!");
        }
        public void Off() {
            Console.WriteLine($"{name} Off!!");
        }
    }
}
