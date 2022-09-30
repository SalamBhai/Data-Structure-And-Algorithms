// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.DetermineStringHasPalindrome2("Yo Banana Boy"));


public class Solution 
{
    public static string DetermineStringHasPalindrome(string letter)
    {
       var stringOfPalindromeLetters = "";
       var checkPalindromeText = "";
       var subLetter = "";
       int k= 1;
       for(int i = 0; i < letter.Length; i++ )
       {
           for(int j = 1; j < letter.Length - i; j++)
           {
              
              if(stringOfPalindromeLetters.Length == 0) subLetter = letter.Substring(i,j);
              bool check = IsPalindrome(subLetter);
               if(check)
               {
                  stringOfPalindromeLetters+= subLetter + ",";
                  subLetter = letter.Substring(j,k);
                  k++;
               }
               else if(!check && stringOfPalindromeLetters.Length != 0)
               {
                  int h = j;
                  subLetter = letter.Substring(h,k);
                   k++;
               }
           }
       }
       
       return checkPalindromeText = $"The Palindromes are {stringOfPalindromeLetters}";
    }
    
    public static bool DetermineStringHasPalindrome2(string letter)
    {
        var palindromeLetters = "";
        letter = letter.ToLower();
        for (var i = 0; i < letter.Length; i++)
        {
            for (int j = 1; j <= letter.Length - i; j++)
            {
                var subString = letter.Substring(i,j);
                if(IsPalindromeCheck(subString))
                {
                   palindromeLetters+= subString + ",";
                }
            }
        }
        if(IsPalindromeCheck(letter)) palindromeLetters += letter + ",";
        if(palindromeLetters.Length == 0)
        {
            return false;
        }
        else
        {
            Console.WriteLine(palindromeLetters);
            return true;
        }
    }

    public static bool IsPalindromeCheck(string text)
    {
        text = text.Replace(" ","");
        var reverseText = string.Join("", text.ToLower().Replace(" ","").Reverse());
        if(reverseText == text.ToLower() && text.Length > 1)
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
    public static bool IsPalindrome3(string text)
    {
         var palindromeCheckText = "";
         var reverseText = text.Reverse();
          reverseText.Select(text =>  palindromeCheckText += text);
          Console.WriteLine(palindromeCheckText);
         if(palindromeCheckText == text && palindromeCheckText.Length > 1) return true;
         else
         {
            return false;
         }
    }

    private static bool IsPalindrome(string text)
    {
        if(text.Length <= 1)
        {
            return false;
        }
         var spaceOutText = text.Replace(" ","");
        var textArray = spaceOutText.ToLower();
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