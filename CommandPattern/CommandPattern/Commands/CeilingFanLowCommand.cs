using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class CeilingFanMediumCommand : ICommand
    {
        CeilingFan ceilingfan;
        SpeedFan lastSpeedFan;
        public CeilingFanMediumCommand(CeilingFan ceiling)
        {
            this.ceilingfan = ceiling;
        }
        public void Execute()
        {
            lastSpeedFan = ceilingfan.GetSpeed();
            ceilingfan.Medium();
        }
        public string GetName()
        {
            return this.ToString();
        }

        public void Undo()
        {
            switch (lastSpeedFan)
            {
                case SpeedFan.High:
                    ceilingfan.High();
                    break;
                case SpeedFan.Medium:
                    ceilingfan.Medium();
                    break;
                case SpeedFan.Low:
                    ceilingfan.Low();
                    break;
                case SpeedFan.Off:
                    ceilingfan.Off();
                    break;
                default:
                    break;
            }
        }
    }
}
