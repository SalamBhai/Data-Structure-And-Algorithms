using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextBook Example
            //"1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))"test case1
            var expression = ")))))(()((("; 
            //testcase2(personal);
            // CheckBrackets1(expression);
            CheckBrackets2(expression);
            
        }

        // This method used stack to solve valid parentheses
        public static void CheckBrackets1(string expression)
        {
            bool correctBrackets = true;
             Stack<char> openingBracketsStack = new Stack<char>();
            
            foreach(var element in expression)
            {
               
                if(element == '(')
                {
                    openingBracketsStack.Push(element);
                    Console.WriteLine(element);
                }

                else if(element == ')')
                {
                   if(openingBracketsStack.Count == 0)
                   {
                       correctBrackets = false;
                       break;
                   }
                   else
                   {
                       openingBracketsStack.Pop();
                       System.Console.WriteLine(openingBracketsStack.Count);
                   }
                }
            }
            if(openingBracketsStack.Count > 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the Brackets Valid (Does Every Opening have its corresponding close?):" + correctBrackets);

        }
        
        // This method will use LinkedList to solve the algorithm
        public static void CheckBrackets2(string expression)
        {
            LinkedList<char> openBracketsList = new LinkedList<char>();
              LinkedList<char> closeBracketsList = new LinkedList<char>();

              foreach(var element in expression)
              {
                  if(element == '(')
                  {
                      openBracketsList.AddFirst(element);
                  }

                  else if(element == ')')
                  {
                      closeBracketsList.AddFirst(element);
                  }
              }
            //   if(openBracketsList.Count == closeBracketsList.Count)
            //   {
            //       Console.WriteLine($"Parentheses are valid, having corresponding closures and openings");
                  
            //   }
           bool output =  openBracketsList.Count == closeBracketsList.Count ? true : false;
            if(output) Console.WriteLine($"Valid Parentheses");
           else
           {
                Console.WriteLine($"Invalid Parentheses");
           }
                          
        }

    }

  
}
