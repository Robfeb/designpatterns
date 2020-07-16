using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }
        public string GetName()
        {
            return this.ToString();
        }
    }
}
