// See https://aka.ms/new-console-template for more information
Console.WriteLine(RemoveVowels("Adeisabeautifulboy")); // expecting: dsbtflby

static string RemoveVowels(string givenWord)
{
    givenWord = givenWord.ToLower();
    var vowels = "aeiou";
    var leftConsonant = givenWord;
    givenWord.ToList().ForEach(v =>
    {
        if (vowels.Contains(v)) leftConsonant = leftConsonant.Replace(v.ToString(), "");
    });
    return leftConsonant;
}