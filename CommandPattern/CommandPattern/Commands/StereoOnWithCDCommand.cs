using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
        public string GetName()
        {
            return this.ToString();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
