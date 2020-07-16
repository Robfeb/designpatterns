using System;
namespace CommandPattern.Models
{
    public class GardenLight
    {
        readonly string name = "I'm a GardenLight";
        public GardenLight()
        {
        }
        public void setDuskTime()
        {
            Console.WriteLine($"{name} setDuskTime!!");
        }
        public void setDawnTime()
        {
            Console.WriteLine($"{name} setDawnTime!!");
        }
        public void manualOn()
        {
            Console.WriteLine($"{name} manualOn!!");
        }
        public void manualOff()
        {
            Console.WriteLine($"{name} manualOff!!");
        }
    }
}
