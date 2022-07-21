Console.Write("Въведете страна на квардат: ");
double a = double.Parse(Console.ReadLine());
double perimeter = 4 * a;
double area = a * a * Math.PI;
Console.WriteLine($"Лицето на квадрата е: {area:f2}");
Console.WriteLine($"Периметърът на квадрата е: {perimeter:f2}");