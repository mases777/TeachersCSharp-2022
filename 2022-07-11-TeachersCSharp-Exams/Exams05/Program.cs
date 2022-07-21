List<int> numbers = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.Write("Въведете цяло число: ");
    numbers.Add(int.Parse(Console.ReadLine()));
}
var averageNumber = numbers.Average();

int lowNumbers = numbers.Where(x => x < averageNumber).Count();
int highNumbers = numbers.Where(x => x > averageNumber).Count();

Console.WriteLine($"Броят на числата, които са по-малки от средната стойност са: {lowNumbers}");
Console.WriteLine($"Броят на числата, които са по-големи от средната стойност са: {highNumbers}");