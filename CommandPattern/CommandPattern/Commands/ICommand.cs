namespace CommandPattern.Commands
{
    public interface ICommand
    {
        public void Execute();
        public string GetName();
        public void Undo();
    }
}
