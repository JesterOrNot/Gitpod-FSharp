using System;
using System.Linq;
namespace app
{
    class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From C#");
            int[] numberSet = new int[] { 25, 2, 3, 5, 7, 3, 22, 13 };
            var evenNums = from num in numberSet
                           where (num % 2) == 0
                           select num;
            foreach (var num in evenNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}