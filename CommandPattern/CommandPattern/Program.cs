using System;
using CommandPattern.Commands;
using CommandPattern.Models;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Remote Control (Command pattern)!");
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
