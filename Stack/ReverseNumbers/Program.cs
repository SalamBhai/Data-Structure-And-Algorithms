using System;
using System.Collections.Generic;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
              /*
           Write a program, which reads from the console N integers and prints 
              them in reversed order. Use the Stack<int> class.
           */
           TakeNumberAndReverse();
        }

        public static void TakeNumberAndReverse()
        {
            Console.WriteLine("Enter Amounts Of Number");
            int index = 0;
            var N = int.Parse(Console.ReadLine());
             
             var numbersStack = new Stack<int>();
             Console.WriteLine("Your Number");
            while(index <= N)
            {
               int value = int.Parse(Console.ReadLine());
               numbersStack.Push(value);
               index++;
            }
              Console.Write("Result is =");
              Console.WriteLine();
              
            foreach (var number in numbersStack)
            {
                Console.Write(" " + number);
            }
        }
    }
}
