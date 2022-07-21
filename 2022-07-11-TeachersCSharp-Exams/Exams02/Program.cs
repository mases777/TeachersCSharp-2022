using System.Collections.Generic;

char[] separator = new char[] { ' ', '.' };
Console.WriteLine("Въведете изречение, което съдържа няколко думи, разделени с интервал и завършващо с . (точка)");
List<string> sentence = Console.ReadLine()
    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Console.WriteLine($"Броят на думите в изречението е: {sentence.Count}");

var words = new Dictionary<string, int>();
foreach (var item in sentence)
{
    if (!words.ContainsKey(item))
    {
        words.Add(item, item.Length);
    }
}
int maxWordLength = words.Select(x => x.Value).Max();
string maxWord = words.Where(x => x.Value == maxWordLength).Select(x => x.Key).First();

Console.WriteLine($"Най-дългата дума е: {maxWord}");