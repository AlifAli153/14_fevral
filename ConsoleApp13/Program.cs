using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework!");
           
            int[] arr = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine(Array.LastIndexOf(arr, 12));
            int num = Array.Find(arr, x => x == 6);
            Console.WriteLine(num);
            int[] num2 = Array.FindAll(arr, x => x == 8);
            Console.WriteLine(num2);
            {
                Console.WriteLine(num2);
            }


            bool result = Array.Exists(arr, x => x == 2);
            if (result) ;

            else
            {
                Console.WriteLine("Bele bir eded yoxdur");
            }


        }
    }
}
