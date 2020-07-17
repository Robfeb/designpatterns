using System;
namespace TemplateMethodPattern.Models
{
    public abstract class WaterPreparedBeverage
    {
        public string Beverage { get; set; }
        public void PrepareRecipe()
        {
            ShowBeverageMessage();
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
                AddCondiments();
        }

        private void ShowBeverageMessage()
        {
            Console.WriteLine("++++++++++++++++");
            Console.WriteLine($"Preparing {Beverage}"); 
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public abstract void Brew();
        public abstract void AddCondiments();
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public virtual bool CustomerWantsCondiments()
        {
            return false;
        }
    }
}
