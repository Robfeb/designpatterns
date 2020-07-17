using System;
namespace TemplateMethodPattern.Models
{
    public class Tea : WaterPreparedBeverage
    {
        public Tea()
        {
            Beverage = "Tea";
        }
        //public void PrepareRecipe()
        //{
        //    BoilWater();
        //    SteepTeaBag();
        //    PourInCup();
        //    AddLemon();
        //}
        //public void BoilWater()
        //{
        //    Console.WriteLine("Boiling water");
        //}
        //public void SteepTeaBag()
        //{
        //    Console.WriteLine("Steeping the tea");
        //}
        //public void PourInCup()
        //{
        //    Console.WriteLine("Pouring into cup");
        //}
        //public void AddLemon()
        //{
        //    Console.WriteLine("Adding lemon");
        //}
        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
