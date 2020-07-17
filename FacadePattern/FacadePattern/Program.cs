using System;
using FacadePattern.Models;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Facade Pattern!");
            PopcornPopper popper = new PopcornPopper();
            TheaterLights lights = new TheaterLights();
            Screen screen = new Screen();
            Projector projector = new Projector();
            Amplifier amp = new Amplifier();
            DvdPlayer dvd = new DvdPlayer();
            Movie movie = new Movie();
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.setInput(dvd);
            projector.wideScreenMode();
            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.Load(movie);
            dvd.play();
        }
    }
}
