Console.Write("Въведете Хс на окръжността: ");
double xc = double.Parse(Console.ReadLine());
Console.Write("Въведете Yс на окръжността: ");
double yc = double.Parse(Console.ReadLine());
Console.Write("Въведете радиуса на окръжността: ");
double radius = double.Parse(Console.ReadLine());
Console.Write("Въведете Хt на дадената точка: ");
double xt = double.Parse(Console.ReadLine());
Console.Write("Въведете Yt на дадената точка: ");
double yt = double.Parse(Console.ReadLine());

double cathA = Math.Abs(xc - xt);
double cathB = Math.Abs(yc - yt);
double hypotenuse = Math.Sqrt(cathA * cathA + cathB * cathB);

if (radius > hypotenuse)
{
    Console.WriteLine("Точката е вътреша за окръжността.");
}
else if (radius < hypotenuse)
{
    Console.WriteLine("Точката е външна за окръжността.");
}
else
{
    Console.WriteLine("Точката лежи на окръжността.");
}