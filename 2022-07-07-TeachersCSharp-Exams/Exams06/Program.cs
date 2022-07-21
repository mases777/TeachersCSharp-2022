int firstNumber = 5;
int secondNumber = 10;

Console.WriteLine($"First number is: {firstNumber}");
Console.WriteLine($"Second number is: {secondNumber}");

firstNumber = firstNumber + secondNumber;
secondNumber = firstNumber - secondNumber;
firstNumber = firstNumber - secondNumber;

Console.WriteLine($"First number is: {firstNumber}");
Console.WriteLine($"Second number is: {secondNumber}");

Console.WriteLine("####################################");

int firstNumber2 = 5;
int secondNumber2 = 10;

Console.WriteLine($"First number is: {firstNumber2}");
Console.WriteLine($"Second number is: {secondNumber2}");

int thirtNumber = secondNumber2;
secondNumber2 = firstNumber2;
firstNumber2 = thirtNumber;

Console.WriteLine($"First number is: {firstNumber2}");
Console.WriteLine($"Second number is: {secondNumber2}");