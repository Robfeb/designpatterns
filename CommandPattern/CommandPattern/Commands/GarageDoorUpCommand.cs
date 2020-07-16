using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        GarageDoor garage;
        public GarageDoorUpCommand(GarageDoor garage)
        {
            this.garage = garage;
        }
        public void Execute()
        {
            garage.Up();
        }
        public string GetName()
        {
            return this.ToString();
        }

        public void Undo()
        {
            garage.Down();
        }
    }
}
