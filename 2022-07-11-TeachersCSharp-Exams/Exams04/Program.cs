List<int> oddNumbers = new List<int>();
List<int> evenNumbers = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.Write("Въведете цяло число: ");
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
    else
    {
        oddNumbers.Add(number);
    }
}

Console.WriteLine($"Сумата на четните числа е: {evenNumbers.Sum()}");
Console.WriteLine($"Сумата на нечетните числа е: {oddNumbers.Sum()}");