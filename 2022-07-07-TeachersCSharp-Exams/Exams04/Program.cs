Console.Write("Въведете дължина на страна на равнобедрен триъгълник: ");
int n = int.Parse(Console.ReadLine());

Console.Write(new String(' ', n));
Console.WriteLine("*");
for (int i = 0; i < n - 1; i++)
{
    Console.Write(new String(' ', n - i - 1));
    Console.Write("*");
    Console.Write(new String(' ', 2 * i + 1));
    Console.WriteLine("*");
}
Console.WriteLine(new String('*', 2 * n + 1));