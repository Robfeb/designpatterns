﻿using System;
using System.Collections.Generic;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Pizza: IPizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

       
        public Pizza()
        {
            name = "default pizza";
            dough = "classic";
            sauce = "no";
        }
        public void Prepare()
        {
            Console.WriteLine($"Preparing the {name} !...");
            Console.WriteLine($"Width the {dough} dough!...");
            Console.WriteLine($"and {sauce} sauce!...");
            foreach (var topping in toppings)
            {
                Console.WriteLine($"adding {topping}!...");
            }
        }
        public void Bake() {
            Console.WriteLine($"Baking the {name}! 25 minutes at 250ºC ");
        }
        public virtual void Cut() {
            Console.WriteLine($"Cutting the {name}! 16 portions");
        }
        public void Box() {
            Console.WriteLine($"Boxing the {name}!");
        }

    }
}
