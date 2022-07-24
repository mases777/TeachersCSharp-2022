List<int> list = new List<int>();
while (true)
{
    Console.Write("Въведете поредица от числа, разделени с интервал: ");
    list = Console.ReadLine().Split().Select(int.Parse).ToList();
    if (list.Count > 0) break;
}
Console.WriteLine($"Първото число, който е по-голям от двата свои съседи едновременно е на позиция: {BigElement(list)}");

static int BigElement(List<int> list)
{    
    int bigIndex = 0;
    for (int i = 1; i < list.Count - 1; i++)
    {
        if (list[i] > list[i - 1] && list[i] > list[i + 1])
        {            
            bigIndex = i; break;
        }
    }
    if (bigIndex == 0) return -1;
    return bigIndex;
}