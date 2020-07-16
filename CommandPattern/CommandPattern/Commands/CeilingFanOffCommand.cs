using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        CeilingFan ceilingfan;
        public CeilingFanOffCommand(CeilingFan ceiling)
        {
            this.ceilingfan = ceiling;
        }
        public void Execute()
        {
            ceilingfan.Off();
        }

        public string GetName()
        {
            return this.ToString();
        }
    }
}
