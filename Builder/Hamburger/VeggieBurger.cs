namespace Builder.Hamburger
{
    public class VeggieBurger : IBuilder
    {
        private Hamburger _hamburger;

        public void AddIngredients()
        {
            _hamburger.Ingredients = new[] {"Bread", "Salad", "Tomato"};
        }

        public void AddShape()
        {
            _hamburger.Shape = "Cuboid";
        }

        public void AddSize()
        {
            _hamburger.Size = 6; //inches
        }

        public void Reset()
        {
            _hamburger = new Hamburger();
        }

        public Hamburger Build()
        {
            return _hamburger;
        }
    }
}