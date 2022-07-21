Console.Write("Въведете радиус на окръжност: ");
double r = double.Parse(Console.ReadLine());
double perimeter = 2 * r * Math.PI;
double area = r * r * Math.PI;
Console.WriteLine($"Лицето на окръжността е: {area:f2}");
Console.WriteLine($"Периметърът на окръжността е: {perimeter:f2}");