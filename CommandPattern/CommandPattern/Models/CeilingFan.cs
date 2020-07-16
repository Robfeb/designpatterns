using System;
namespace CommandPattern.Models
{
    public class CeilingFan
    {
        SpeedFan currentSpeed;
        readonly string name = "I'm a Ceiling Fan";

        public CeilingFan(string room)
        {
            currentSpeed = SpeedFan.Off;
            name += " " + room;
        }
        public void High()
        {
            currentSpeed = SpeedFan.High;
            Console.WriteLine($"{name} High!!");
        }
        public void Medium()
        {
            currentSpeed = SpeedFan.Medium;
            Console.WriteLine($"{name} Medium!!");
        }
        public void Low()
        {
            currentSpeed = SpeedFan.Low;
            Console.WriteLine($"{name} Low!!");
        }
        public SpeedFan GetSpeed()
        {
            Console.WriteLine($"{name} GetSpeed!!");
            return currentSpeed;
        }
        public void Off()
        {
            currentSpeed = SpeedFan.Off;
            Console.WriteLine($"{name} Off!!");
        }
    }
}
