using System.Collections.Generic;
using AbstractFactory.Ingredients;

namespace AbstractFactory.PizzaFactory
{
    public class NyIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Mozarella();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FrozenClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new ThinCrust();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new CherryTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            IVeggies[] arr = {new Onion(), new Pepper(), new Olive()};
            return arr;
        }
    }
}