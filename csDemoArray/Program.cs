using System;

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
            Console.WriteLine("Index of Array: " + index);

            //Clear of an Array
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Cleared Array items: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy of an Array
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Another Array: ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Array Sorting
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Array Reversing
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse: ");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}