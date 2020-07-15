using System;
using System.Collections.Generic;
using FactoryPattern.Interfaces;
using FactoryPattern.Models.Ingredients;

namespace FactoryPattern.Models
{
    public class PizzaClassic : IPizza
    {
            public string name;
            public List<string> toppings = new List<string>();
            public IDough dough;
            public ISauce sauce;
            public List<IVeggies> veggies;
            public ICheese cheese;
            public IPepperoni pepperoni;
            public IClams clam;

            public PizzaClassic()
            {
                name = "default pizza";
                dough = new ThinCrustDough();
                sauce = new NoSauce();
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
            public void Bake()
            {
                Console.WriteLine($"Baking the {name}! 25 minutes at 250ºC ");
            }
            public virtual void Cut()
            {
                Console.WriteLine($"Cutting the {name}! 16 portions");
            }
            public void Box()
            {
                Console.WriteLine($"Boxing the {name}!");
            }

        }
    }

