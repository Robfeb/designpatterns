using System;
namespace CommandPattern.Models
{
    public class Stereo
    {
        readonly string name = "I'm a Stereo";

        public Stereo(string room)
        {
            name += " " + room;
        }
        public void On()
        {
            Console.WriteLine($"{name} On!!");
        }
        public void Off()
        {
            Console.WriteLine($"{name} off!!");
        }
        public void SetCd()
        {
            Console.WriteLine($"{name} setCd!!");
        }
        public void SetDvd()
        {
            Console.WriteLine($"{name} setDvd!!");
        }
        public void SetRadio()
        {
            Console.WriteLine($"{name} setRadio!!");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"{name} setVolume {volume}!!");
        }
    }
}
