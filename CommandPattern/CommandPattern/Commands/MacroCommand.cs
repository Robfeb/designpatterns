using System;
using System.Collections.Generic;

namespace CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        List<ICommand> _commands;
        public MacroCommand(List<ICommand> commands)
            {
            _commands = commands;
            }
        public void Execute()
            {
            foreach (var command in _commands)
            {
                command.Execute();
            }
            }
        public string GetName()
        {
            return this.ToString();
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }

}
