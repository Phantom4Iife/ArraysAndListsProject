using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    
                    evens.Add(number);
                    
                }
                else
                {
                    
                    odds.Add(number);
                    
                }
            }

            
             Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.Write(even + " ");
            }
            Console.WriteLine(); 
            
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < odds.Count; i++)
              {
                Console.Write(odds[i] + " ");
            }
            Console.WriteLine(); 
        }
    }
}

