using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class LightOnCommand: ICommand
    {
        Light light;
        public LightOnCommand(Light light)
            {
                this.light = light;
            }
        public void Execute()
            {
                light.On();
            }
        public string GetName()
        {
            return this.ToString();
        }
    }

}
