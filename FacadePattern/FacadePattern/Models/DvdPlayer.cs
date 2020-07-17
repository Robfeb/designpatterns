using System;
namespace FacadePattern.Models
{
    public class DvdPlayer
    {
        public DvdPlayer()
        {
        }
        Amplifier amplifier;
        Movie movieLoad;
        public void on() { }
        public void off() { }
        public void eject() { }
        public void pause() { }
        public void Load(Movie movie)
        {
            movieLoad = movie;
        }
        public void play() { }
        public void setSurroundAudio(Amplifier amp) {
            amplifier = amp;
        }
        public void setTwoChannelAudio() { }
        public void stop() { }
    }
}
