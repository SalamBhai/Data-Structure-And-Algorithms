using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Let’s take the sequence of numbers, 
            the elements of which are derived in the following way: the first element is N; 
            the second element is derived by adding 1 to N; the third element – by 
            multiplying the first element by 2 and thus we successively multiply each 
            element by 2 and insert it at the end of the sequence, after which we add 1 to 
                it and insert it at the end of the sequence.
            */
            int n = 3;
            int p = 4;
            FindIndexOfP(n,p);
        }

        public static void FindIndexOfP(int firstElement, int value)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(firstElement);
            int index = 0;
            Console.Write("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(" " + current);
                if (current == value)
                {
                   Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }
        }


    }
}