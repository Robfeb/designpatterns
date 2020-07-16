using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        CeilingFan ceilingfan;
        public CeilingFanOnCommand(CeilingFan ceiling)
        {
            this.ceilingfan = ceiling;
        }
        public void Execute()
        {
            ceilingfan.High();
        }
        public string GetName()
        {
            return this.ToString();
        }
    }
}
