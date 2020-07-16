using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        GarageDoor garage;
        public GarageDoorDownCommand(GarageDoor garage)
        {
            this.garage = garage;
        }
        public void Execute()
        {
            garage.Down();
        }
        public string GetName()
        {
            return this.ToString();
        }

        public void Undo()
        {
            garage.Up();
        }
    }
}
