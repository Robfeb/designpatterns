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
            CdPlayer cd = new CdPlayer();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            Movie movie = new Movie("The Goonies");
            //simple version
            //popper.on();
            //popper.pop();
            //lights.dim(10);
            //screen.down();
            //projector.on();
            //projector.setInput(dvd);
            //projector.wideScreenMode();
            //amp.on();
            //amp.setDvd(dvd);
            //amp.setSurroundSound();
            //amp.setVolume(5);
            //dvd.on();
            //dvd.Load(movie);
            //dvd.play();

            //Using Facade
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);
            homeTheater.watchMovie(movie);
            homeTheater.endMovie();
        }
    }
}
