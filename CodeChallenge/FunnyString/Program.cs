

var funnyString = Solution.DetermineFunnyString("babba");
Console.WriteLine(funnyString);


public class Solution
{
    public  static string DetermineFunnyString(string text)
    {
       
       string funny = "Funny String";
       var asciiOfText = new List<int>();
       var absoluteDiffernceOfFirstRverse = new List<int>();
       var absoluteDiffernceOfSecondRverse = new List<int>();
       string reversedString = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedString += text[i].ToString();
        }
        asciiOfText.AddRange(reversedString.Select(x => Convert.ToInt32(x)).ToList());
        var reversedAsciiOfText = asciiOfText.Reverse<int>().ToList();
        for(int i =0; i < asciiOfText.Count-1; i++)
        {
            absoluteDiffernceOfFirstRverse.Add(Math.Abs(asciiOfText[i] - asciiOfText[i+1]));
            absoluteDiffernceOfSecondRverse.Add(Math.Abs(reversedAsciiOfText[i] - reversedAsciiOfText[i+1]));
        }

        for(int i = 0; i < absoluteDiffernceOfFirstRverse.Count -1; i++)
        {
            if(absoluteDiffernceOfFirstRverse[i] != absoluteDiffernceOfSecondRverse[i])
            {
              return funny ="Not Funny";
            }
            else
            {
               funny = "Funny String";
            }
        }
        return funny;
    }
}