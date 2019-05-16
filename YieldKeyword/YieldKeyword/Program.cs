using System;
using System.Collections.Generic;

namespace YieldKeyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myCollection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var max = 5;
            Console.WriteLine($"Filtering only numbers greater than {max}");
            foreach (var item in FilterCollection.FilterNumbersGreaterThan(myCollection, max))
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}