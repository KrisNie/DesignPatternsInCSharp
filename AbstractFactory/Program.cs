using System;
using AbstractFactory.Pizza;
using AbstractFactory.PizzaFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yankees fan orders:");
            var yankees = new CheesePizza(new NyIngredientsFactory());
            yankees.Prepare();
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var cubs = new  ClamPizza(new ChicagoIngredientsFactory());
            cubs.Prepare();
        }
    }
}