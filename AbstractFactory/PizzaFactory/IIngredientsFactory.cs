using System.Collections.Generic;
using AbstractFactory.Ingredients;

namespace AbstractFactory.PizzaFactory
{
    public interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}