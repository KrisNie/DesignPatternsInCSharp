using System;

namespace ConsoleApp1
{
    class BaseClass
    {
        static bool SomeMethod1()
        {
            Console.WriteLine("Method 1");
            return false;
        }

        static bool SomeMethod2()
        {
            Console.WriteLine("Method 2");
            return true;
        }
        static void Main(string[] args)
        {
            if (SomeMethod1() && SomeMethod2())
            {
                Console.WriteLine("the if block has was executed");
            }
        }
    }
}