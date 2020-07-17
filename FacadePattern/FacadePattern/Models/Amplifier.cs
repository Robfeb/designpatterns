using System;
namespace FacadePattern.Models
{
    public class Amplifier
    {
        public Amplifier()
        {
        }
        Tuner tuner;
        DvdPlayer dvdPlayer;
        CdPlayer cdPlayer;
        public void on() { }

        public void off()
        { }
        public void setCd()
        { }
        public void setDvd(DvdPlayer dvd)

        { dvdPlayer = dvd; }
        public void setStereoSound()
        { }
        public void setSurroundSound()
        { }
        public void setTuner()
        { }
        public void setVolume(int vol)
        { }
        public void toString() { }
    }
}
