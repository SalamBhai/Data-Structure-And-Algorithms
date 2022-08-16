using System;
using System.Collections.Generic;

namespace QueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
           
               
               //Adding To The ADT Queue<string>() using its Enqueue method
               //Adds New Element To The Start Of The Queue
               //The Data Structure Is Known as the FIFO(First In First Out) structure( and Last-In-Last-Out)
              Queue<string> Names = new Queue<string>();
              Names.Enqueue("Sheriffdeen");
              Names.Enqueue("Saula");
              Names.Enqueue("Abdussalam");
               Names.Enqueue("Olamilekan");
              Console.WriteLine(Names.Count); // Count of elements in structure

              // Looping Items from another  into the names queue
               Queue<string> queue = new Queue<string>();
             queue.Enqueue("Message One");
             queue.Enqueue("Message Two");
             queue.Enqueue("Message Three");
              queue.Enqueue("Message Four");

                //  foreach(var queueItem in queue)
                //  {
                //      Names.Enqueue(queueItem);
                //      Console.WriteLine($"{Names.Count}, {queueItem}");
                //  }
                 while (Names.Count >= 0)
                 {
                     var outItem = Names.Dequeue();
                     // the first element in come out first(in ascending order)
                     Console.WriteLine(outItem);  
                 }
                //Copying the whole element of a queue into another queue
                //The first argument in the method accepts an array of the initial array
                // 
                // queue.CopyTo(Names.ToArray(), Names.Count);
                // Console.WriteLine(Names.Count);
                
        }
    }
}
