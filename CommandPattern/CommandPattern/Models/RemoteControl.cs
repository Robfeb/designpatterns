using System;
using System.Collections.Generic;
using CommandPattern.Commands;

namespace CommandPattern.Models
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            if (onCommands[slot] != null)
                onCommands[slot].Execute();
            undoCommand = onCommands[slot];

        }
        public void OffButtonWasPushed(int slot)
        {
            if (onCommands[slot] != null)
                offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            Console.WriteLine("\n------ Undo Press Button -------\n");
            undoCommand.Undo();
        }

        public void GetStatus()
        {
            Console.WriteLine("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                Console.WriteLine("[slot " + i + "] " + onCommands[i].GetName() +" - " + offCommands[i].GetName());
            }

        }
    }
}
