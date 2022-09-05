// See https://aka.ms/new-console-template for more information
int[] arr = {2, 4, 1, 0};
Console.WriteLine(Solution.GetMaximalAbsoluteDifference(arr));
public class Solution
{
    public static int GetMaximalAbsoluteDifference(int[] Array)
    {
        int maxAbsoluteDifference = 0;
        for(int i = 0; i <= Array.Length - 1; i++)
        {
           if(i == Array.Length-1 )
           {
              break;
           }
           else
           {
              int difference = Math.Abs(Array[i] - Array[i + 1]);
              if(difference > maxAbsoluteDifference)
              {
                maxAbsoluteDifference = difference;
              }
           }
        }
        return maxAbsoluteDifference;
    }
}