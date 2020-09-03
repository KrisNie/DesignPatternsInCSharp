using System;
using System.Runtime.CompilerServices;
using Builder.Hamburger;
using Builder.Vehicle;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.CookHamburger();
            Program.VehicleShop();
        }

        private static void CookHamburger()
        {
            var builder = new ClassicHamburger();
            var cook = new Cook(builder);
            var classicHamburger = cook.Build();

            cook.ChangeBuilder(new VeggieBurger());
            var veggieBurger = cook.Build();

            Console.WriteLine($"My Hamburger: {classicHamburger}");
            Console.WriteLine($"My Wife's Hamburger: {veggieBurger}");
        }

        private static void VehicleShop()
        {
            AbstractVehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            shop.Builder = new ScooterBuilder();
            shop.Construct();
            shop.Builder.Vehicle.Show();

            shop.Builder = new CarBuilder();
            shop.Construct();
            shop.Builder.Vehicle.Show();

            // use Overload method
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}