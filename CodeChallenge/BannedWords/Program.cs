// See https://aka.ms/new-console-template for more information
var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit and very far it went";
var arrayOfBanned = new string[] { "hit" };
var result = Solution.SolveForBanned(paragraph, arrayOfBanned);
Console.WriteLine(result);


public class Solution
{
    //MySolution
    public static string SolveForBanned(string paragraph, string[] bannedWords)
    {
        var wordsInString = paragraph.Replace(',', ' ').Replace('!', ' ').Replace('.', ' ').Replace('?', ' ').Replace(':', ' ').Split(' ');
        var dictionaryOfNotBannedWordsAndOccurence = new Dictionary<string, int>();
        var notBannedWordWithHighestOccurence = "";
        for (int index = 0; index < wordsInString.Length; index++)
        {
            var currentText = wordsInString[index].ToLower();
            if (dictionaryOfNotBannedWordsAndOccurence.ContainsKey(currentText) || currentText == "")
            {
                continue;
            }
            foreach (var item in wordsInString)
            {
                var compareWord = item.ToLower();
                if (currentText == compareWord && !bannedWords.Contains(currentText))
                {
                    if (!dictionaryOfNotBannedWordsAndOccurence.ContainsKey(currentText))
                    {
                        dictionaryOfNotBannedWordsAndOccurence.Add(currentText, 1);
                    }
                    else
                    {
                        var elementAtKey = dictionaryOfNotBannedWordsAndOccurence.Where(i => i.Key == currentText).SingleOrDefault();
                        var value = elementAtKey.Value;
                        dictionaryOfNotBannedWordsAndOccurence.Remove(currentText);
                        dictionaryOfNotBannedWordsAndOccurence.Add(currentText, value + 1);
                    }
                }
            }
        }
        var max = dictionaryOfNotBannedWordsAndOccurence.Values.Max();
         var maxOccurenceCount = 0;
        foreach (var item in dictionaryOfNotBannedWordsAndOccurence.Values)
        {
            if (item == max)
            {
                maxOccurenceCount++;
            }

        }
        if (maxOccurenceCount == 1)
        {
            notBannedWordWithHighestOccurence = dictionaryOfNotBannedWordsAndOccurence.Where(i => i.Value == max).Select(i => i.Key).SingleOrDefault();
        }
        return notBannedWordWithHighestOccurence.ToLower();
    }

    public static string LeetCodeSolution(string paragraph, string[] bannedWords)
    {
        //used anonymous type 
        // solution tagged incorrect
        char[] chars = new char[]{'!', '?', ',', '.', ';', ' ', '\''};
        return paragraph.Split(chars).Where(x => !string.IsNullOrWhiteSpace(x)).
        Select(x => x.ToLower()).Where(x => !bannedWords.Contains(x)).
        GroupBy(x => x).Select(x => new {Word = x.Key, Count = x.Count()}).
        OrderBy(x => x.Count).Last().Word;
    }
}