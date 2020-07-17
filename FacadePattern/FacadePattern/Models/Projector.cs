using System;
namespace FacadePattern.Models
{
    public class Projector
    {
        public Projector()
        {
        }
        DvdPlayer dvdPlayer;
        public void setInput(DvdPlayer dvd) {
            dvdPlayer = dvd;
        }
        public void on() { }
        public void off() { }
        public void tvMode() { }
        public void wideScreenMode() { }
        public void toString() { }
    }
}
