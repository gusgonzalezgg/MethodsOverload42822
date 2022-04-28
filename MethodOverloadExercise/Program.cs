using System;

namespace MethodOverloadExercise
{
    internal class Program
    {
        //static void Add(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        //static void Add(decimal a, decimal b)

        //{
        //    Console.WriteLine(a + b);
        //}

        static void Add(int Ah, int Beh, bool Dollars)
        {

            int Amount = Ah + Beh;

            if (Dollars && Ah + Beh > 1)
            {
                Console.WriteLine( Amount  +  " Dollars");
            }
            else if (Dollars && Ah + Beh == 1)
                    {
                Console.WriteLine(Amount + " Dollar");
                    
                    }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Add(1, 0, true);

        }
    }
}
