using System;
namespace CommandPattern.Models
{
    public class TV
    {
        readonly string name = "I'm a TV";

        public TV()
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

        public void SetInputChannel()
        {
            Console.WriteLine($"{name} setInputChannel!!");
        }
        public void SetVolume()
        {
            Console.WriteLine($"{name} setVolume!!");
        }
    }
}
