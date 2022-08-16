using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(Solution.ReverseNumber(1234));

public class Solution
{
    public static bool ReverseNumber(int number)
    {
        var stringofNumber = number.ToString();
        bool same = false;
        var numberReversed = "";
        var secondReverse = "";
        for (int i = stringofNumber.Length - 1; i >= 0; i--)
        {
            numberReversed += stringofNumber[i].ToString();

        }
        int numReversed = int.Parse(numberReversed);
        var reverseString = numReversed.ToString();
        for (int i = reverseString.Length - 1; i >= 0; i--)
        {
            secondReverse += numberReversed[i].ToString();
        }
        if (stringofNumber.Length != reverseString.Length)
        {
            return same;
        }
        for (var i = 0; i < stringofNumber.Length; i++)
        {
            if (secondReverse[i] == stringofNumber[i])
            {
                same = true;
            }
            else
            {
                same = false;
            }

        }
        return same;
    }

//    public static bool Reverse2(int number)
//    {
//         var numberstring = number.ToString();
//         var same = false;
//          var numberList = numberstring.ToList();
//          numberList.Reverse();
//           var reversedNumber = numberList.ToString();
//          int numReversed = int.Parse(reversedNumber);
//          Console.WriteLine(numReversed);
//          var reverseToNumber = numReversed.ToString().ToList();
//          reverseToNumber.Reverse();
//          if(numberstring.Length != reverseToNumber.Count)
//          {
//             return same;
//          }
//          for (var i = 0; i < numberstring.Length; i++)
//          {
//             if(numberstring[i] != reverseToNumber[i])
//             {
//                 same = true;
//             }
//             else
//             {
//                 same = false;
//             }
//          }
//          return same;
//    }
  
//   public static bool Reverse3(int Number)
//   {
//       var stack = new Stack<char>();
//       var number = Number.ToString();
//       foreach (var item in number)
//       {
//           stack.Push(item);
//       }
//       stack.Reverse();
//       var reversed = "";
//       foreach (var item in stack)
//       {
//          reversed+= item.ToString();
//       }
//       if(reversed.Length != number.Length)
//       {
//         return false;
//       }
//   }

}