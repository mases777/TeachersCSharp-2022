Console.WriteLine("Въведете масив от числа разделени със запетая и интервал");
char[] separator = new char[] { ' ', ',' };
var array = Console.ReadLine()
    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
var dict = new Dictionary<int, int>();
foreach (var item in array)
{
    if (!dict.ContainsKey(item))
    {
        dict.Add(item, 1);
    }
    else
    {
        dict[item]++;
    }
}
Console.WriteLine($"Най-често срещания елемент е: {dict.OrderByDescending(x => x.Value).Select(x => x.Key).FirstOrDefault()}");