using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (pizzaType.Equals("NY"))
            {
                pizza = new NYPizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (pizzaType.Equals("hawaian"))
            {
                pizza = new NYStyleHawaianPizza();
            }
           
            return pizza;
        }
    }
}
