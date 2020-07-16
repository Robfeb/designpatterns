using System;
namespace CommandPattern.Models
{
    public class FaucetControl
    {
        readonly string name = "I'm a Faucet Control";

        public FaucetControl()
        {
        }

        public void OpenValve()
        {
            Console.WriteLine($"{name} Open Valve!!");
        }
        public void CloseValve()
        {
            Console.WriteLine($"{name} Close Valve!!");
        }
       
    }
}
