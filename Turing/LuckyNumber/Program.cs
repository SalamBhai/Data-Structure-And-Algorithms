// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
int[] arr = {2,2,3,3};
Console.WriteLine(LuckyNumber(arr));
// Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.

// Return the largest lucky integer in the array. If there is no lucky integer return -1.

 

// Example 1:

// Input: arr = [2,2,3,4]
// Output: 2
// Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
// Example 2:

// Input: arr = [1,2,2,3,3,3]
// Output: 3
// Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
// Example 3:

// Input: arr = [2,2,2,3,3]
// Output: -1
// Explanation: There are no lucky numbers in the array.
 

// Constraints:

// 1 <= arr.length <= 500
// 1 <= arr[i] <= 500

static int LuckyNumber(int[] arr)
{
    Hashtable table = new Hashtable();
    foreach(var num in arr)
    {
        if(table.ContainsKey(num))
        {
            table[num] = (int) table[num] + 1;
        }

        else
        {
           table.Add(num, 1);
        }
    }
    int count = -1;
    int luckyNumber = -1;
    foreach (DictionaryEntry item in table)
    {
        if((int) item.Key == (int) item.Value)
        {
           count = (int) item.Value;
           if(luckyNumber < count)
           {
             luckyNumber = count;
           }
        }
    }

    return luckyNumber;
}