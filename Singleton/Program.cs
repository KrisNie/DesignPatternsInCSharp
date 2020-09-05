using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var chocoEggs = ChocolateBoiler.GetInstance();
                chocoEggs.Fill();
                chocoEggs.Boil();
                chocoEggs.Drain();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}