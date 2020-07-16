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

        public void Undo()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
    }
}
