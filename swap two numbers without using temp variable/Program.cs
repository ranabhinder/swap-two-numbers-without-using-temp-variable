using System;

namespace swap_two_numbers_without_using_temp_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 9;
            Console.WriteLine("value of a is :" +a);
            Console.WriteLine("value of b is :" +b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\n .......After Swapping....\n");
            Console.WriteLine("New value of a is :" +a);
            Console.WriteLine("New value of b is :" + b);

            Console.ReadLine();






            Console.ReadKey();
        }
    }
}
