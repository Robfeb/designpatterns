namespace FactoryPattern.Models
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust ";
            sauce = "Marinara ";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
