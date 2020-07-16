using System;
using CommandPattern.Commands;
using CommandPattern.Models;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Remote Control (Command pattern)!");
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Light light = new Light();
            //LightOnCommand lightOn = new LightOnCommand(light);
            //GarageDoor garageDoor = new GarageDoor();
            //GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);
            //remote.SetCommand(lightOn);
            //remote.ButtonWasPressed();
            //remote.SetCommand(garageOpen);
            //remote.ButtonWasPressed();

            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(5, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(6, ceilingFanLow, ceilingFanOff);

            remoteControl.GetStatus();

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);

            remoteControl.UndoButtonWasPushed();

        }
    }
}
