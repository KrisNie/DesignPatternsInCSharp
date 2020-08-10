using System.Collections.Generic;
using AbstractFactory.Ingredients;

namespace AbstractFactory.PizzaFactory
{
    internal class ChicagoIngredientsFactory : IIngredientsFactory
    {
        IDough IIngredientsFactory.CreateDough()
        {
            return new DeepDish();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            var oni = new Onion();
            var ccm = new Cucumber();
            var ppr = new Pepper();
            IVeggies[] arr = {oni, ccm, ppr};
            return arr;
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new PlumTomato();
        }

        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Parmesan();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FreshClam();
        }
    }
}