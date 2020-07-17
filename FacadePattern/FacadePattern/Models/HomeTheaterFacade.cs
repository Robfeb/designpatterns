using System;
namespace FacadePattern.Models
{
    public class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;
        Movie movie;
        public HomeTheaterFacade(Amplifier amp,
                                 Tuner tuner,
                                DvdPlayer dvd,
                                CdPlayer cd,
                                Projector projector,
                                Screen screen,
                                TheaterLights lights,
                                PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }
        public void watchMovie(Movie _movie)
        {
            movie = _movie;
            Console.WriteLine($"We're about to watch '{movie.Title}'!! Take your seat!!");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.Load(movie);
            dvd.play();
        }
        public void endMovie()
        {
            Console.WriteLine($"'{movie.Title}' just has finished!! I hope you enjoyed the movie!!");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
        }
        public void listenToCd() { }
        public void endCd() { }
        public void listenToRadio() { }
        public void endRadio() { }
    }
}
