using CommandPattern.Commands;

namespace CommandPattern.Models
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public string GetName()
        {
            return "Empty";
        }
    }
}
