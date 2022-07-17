using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csDemoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length of array
            Console.WriteLine("Length of Array : " + numbers.Length);

            //Index of array
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of Array : " + index);

        }
    }
}