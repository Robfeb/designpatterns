using System;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class CeilingFanLowCommand : ICommand
    {
        CeilingFan ceilingfan;
        SpeedFan lastSpeedFan;
        public CeilingFanLowCommand(CeilingFan ceiling)
        {
            this.ceilingfan = ceiling;
        }
        public void Execute()
        {
            lastSpeedFan = ceilingfan.GetSpeed();
            ceilingfan.Low();
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
