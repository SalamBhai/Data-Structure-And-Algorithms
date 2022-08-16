using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that reads from the console a sequence of positive 
             integer numbers. The sequence ends when empty line is entered. 
            Calculate and print the sum and the average of the sequence. Keep 
             the sequence in List<int>.
            */
            Console.WriteLine(ReadInputsAndGetCalculation());
        }

        public static int ReadInputsAndGetCalculation()
        {
            bool take = true;
            var numbers = new List<int>();
             Console.WriteLine("Supply a number");
            while(take)
            {
               var number = int.TryParse(Console.ReadLine(), out int result);
               
               if(number && result > 0)
               {
                    numbers.Add(result);
               }
               else if(!number)
               {
                   break;
               }
            }
           return MakeCalculation(numbers);
        }
        public static int MakeCalculation(List<int>numbers)
        {

           var sum = 0;
           
           
           foreach (var item in numbers)
           {
               sum += item;
           }
           Console.WriteLine(sum);

           var average = sum/numbers.Count;
           return average;
        }

    }
}
