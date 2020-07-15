using FactoryPattern.Models.Ingredients;

namespace FactoryPattern.Models
{
    public class NYStyleCheesePizza : PizzaClassic
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
