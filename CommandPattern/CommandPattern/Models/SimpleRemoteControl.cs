﻿using System;
using CommandPattern.Commands;

namespace CommandPattern.Models
{
    public class SimpleRemoteControl
    {
        ICommand slot;
        public SimpleRemoteControl() { }
        public void SetCommand(ICommand command)
        {
            slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
