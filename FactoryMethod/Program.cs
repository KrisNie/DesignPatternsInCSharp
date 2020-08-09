using System;
using FactoryMethod.Document;
using FactoryMethod.Page;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            AbstractDocument[] documents = new AbstractDocument[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (AbstractDocument document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (AbstractPage page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name + " to show " + page.PageName);
                }
            }
        }
    }
}