using System;
using TemplateMethodPattern.Models;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Template method pattern");
            Coffee coffee = new Coffee();
            Tea tea = new Tea();
            coffee.PrepareRecipe();
            tea.PrepareRecipe();
        }
    }
}
