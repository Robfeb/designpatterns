using System;
namespace CommandPattern.Models
{
    public class Hottub
    {
        readonly string name = "I'm a Hottub";
        public Hottub()
        {
        }
        public void Circulate()
        {
            Console.WriteLine($"{name} High!!");
        }
        public void JetsOn()
        {
            Console.WriteLine($"{name} Medium!!");
        }
        public void JetsOff()
        {
            Console.WriteLine($"{name} Low!!");
        }
        public void SetTemperature()
        {
            Console.WriteLine($"{name} Low!!");
        }
    }
}
