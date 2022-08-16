using System;
using System.Collections.Generic;
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            TakeAndPrintUsingListDotSort();
            // TakeAndPrintUsingIdea();
        }

        public static void TakeAndPrintUsingListDotSort()
        {
            var listOfNumbers = new List<int>();

            int indexer = 0;
            bool collect = true;
            Console.WriteLine("Give A Number");
            while(collect)
            {
               var value = int.TryParse(Console.ReadLine(), out int output);
               if(output > 0 && value == true)
               {
                  indexer++;
                  listOfNumbers.Add(output);
               }
               if(!value)
               {
                   break;
               }
            }
            Console.WriteLine("|_________________________________________|");
            listOfNumbers.Sort();
            foreach (var item in listOfNumbers)
            {
                Console.WriteLine(" " + item);
            }
    
        }

        // public static void TakeAndPrintUsingIdea()
        // {
        //      var stackOfNumbers = new Stack<int>();
        //      int indexer = 0;
        //      int current = 0;
        //     bool collect = true;
        //     Console.WriteLine($"");
            
        //     Console.WriteLine("Give A Number");
        //      while(collect)
        //     {
        //         //    var value = int.TryParse(Console.ReadLine(), out int output);
        //        //    if(output > 0 && value == true)
        //        //    {
        //       //       stackOfNumbers.Push(output);
        //       //       indexer++;
        //        //    }
        //        int Number = int.Parse(Console.ReadLine());
        //         current = stackOfNumbers.Peek();
        //         if(current < Number)
        //         {
        //             stackOfNumbers.Push(Number);
        //         }
        //         //    if(!value)
        //         //    {
        //       //        break;
        //       //    }
           // }
           
        //}
    }
    public struct MyStruct : ISad
    {
        public string Name{get;set;}

        public string GetName(string name)
        {
            return this.Name;
        }
    }
    public  struct AnotherStruct
    {

    }
    public interface ISad
    {
        public string GetName(string name);
    }
}
