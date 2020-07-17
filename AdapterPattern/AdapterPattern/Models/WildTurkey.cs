using System;
namespace AdapterPattern.Models
{
    public class WildTurkey: ITurkey
    {
        public WildTurkey()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Wild Turkey, I'm Flying (Short distance)");
        }

        public void Gobble()
        {
            Console.WriteLine("I'm a Wild Turkey, I'm Gobbling");

        }
    }
}
