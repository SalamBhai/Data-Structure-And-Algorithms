// See https://aka.ms/new-console-template for more information
var result = Solution.IsPalindrome("Mr owl ate my metal worm");
Console.WriteLine(result);

public class Solution
{
    public static bool IsPalindrome(string text)
    {
        var spaceOutText = text.Replace(" ","");
        var textArray = spaceOutText.ToLower().ToCharArray();
        bool isPalindrome = false;          
        int stopPosition = 0;
        if(textArray.Length % 2 == 0)
        {
           stopPosition = textArray.Length/2;
        }
        else if(textArray.Length % 2 >= 1)
        {
            stopPosition = (textArray.Length  -1) /2;
        }
        for(int index = 0; index <= stopPosition; index++)
        {
            var frontText = textArray[index].ToString();
             var lastText = textArray[textArray.Length - index -1].ToString();
             if(frontText == lastText)
             {
                 isPalindrome = true;
             }
             else
             {
                isPalindrome = false;
             }
        }
        return isPalindrome;
    }
}