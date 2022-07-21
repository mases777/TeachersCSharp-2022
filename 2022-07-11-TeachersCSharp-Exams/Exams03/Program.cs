Console.WriteLine("Задача за пресмятане на степен.");
Console.Write("Въведете число за основа: ");
double baseNumber = double.Parse(Console.ReadLine());
Console.Write("Въведете число за степенен показател: ");
double powerNumber = double.Parse(Console.ReadLine());

Console.WriteLine(Math.Pow(baseNumber, powerNumber));
