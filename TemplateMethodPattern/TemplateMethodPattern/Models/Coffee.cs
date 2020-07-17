using System;
namespace TemplateMethodPattern.Models
{
    public class Coffee : WaterPreparedBeverage
    {
        public Coffee()
        {
            Beverage="Coffee";
        }
        //public void PrepareRecipe()
        //{
        //    BoilWater();
        //    BrewCoffeeGrinds();
        //    PourInCup();
        //    AddSugarAndMilk();
        //}
        //public void BoilWater()
        //{
        //    Console.WriteLine("Boiling water");
        //}
        //public void BrewCoffeeGrinds()
        //{
        //    Console.WriteLine("Dripping Coffee through filter");
        //}
        //public void PourInCup()
        //{
        //    Console.WriteLine("Pouring into cup");
        //}
        //public void AddSugarAndMilk()
        //{
        //    Console.WriteLine("Adding Sugar and Milk");
        //}
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want to add Sugar and Milk? (Y/N)");
            string answer = Console.ReadLine();
            if (answer.ToLowerInvariant().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
