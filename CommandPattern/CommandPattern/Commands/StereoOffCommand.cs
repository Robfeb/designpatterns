using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class StereoOffCommand : ICommand
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }
        public string GetName()
        {
            return this.ToString();
        }
    }
}
