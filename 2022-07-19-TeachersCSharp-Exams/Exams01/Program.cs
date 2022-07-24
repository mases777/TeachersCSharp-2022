Menu();

static void Menu()
{
    int n = 0;
    while (n != 4)
    {
        Console.Clear();
        Console.WriteLine("Изберете някоя от следните задачи:");
        Console.WriteLine("1. Обръщане на последователността на цифрите на цяло число");
        Console.WriteLine("2. Пресмятане на средно аритметично на поредица от числа");
        Console.WriteLine("3. Решаване на линейно уравнение А * x + В = 0");
        Console.WriteLine("4. Край на програмата");
        Console.Write("Направете избор (1, 2, 3 или 4): ");
        n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1: DigitExam(); break;
            case 2: ArrayExam(); break;
            case 3: LinearEquationExam(); break;
        }
    }
}

static void LinearEquationExam()
{
    double a, b;
    while (true)
    {
        Console.Write("Въведете коефициента А: ");
        a = double.Parse(Console.ReadLine());
        if (a != 0) break;
    }
    Console.Write("Въведете коефициента В: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine($"Х = {(-b / a):f2}");
    Console.ReadKey();
}

static void ArrayExam()
{
    List<int> list = new List<int>();
    while (true)
    {
        Console.Write("Въведете поредица от числа, разделени с интервал: ");
        list = Console.ReadLine().Split().Select(int.Parse).ToList();
        if (list.Count > 0) break;
    }
    Console.WriteLine($"Средно аритметично на редицата е: {list.Average():f2}");
    Console.ReadKey();
}

static void DigitExam()
{
    int num;
    while (true)
    {
        Console.Write("Въведете цяло неотрицателно число: ");
        num = int.Parse(Console.ReadLine());
        if (num >= 0) break;
    }
    if (num != 0)
    {
        string result = "";
        while (num > 0)
        {
            result += num % 10;
            num /= 10;
        }
        num = int.Parse(result);
    }
    Console.WriteLine($"Числото с обърната последователност е: {num}");
    Console.ReadKey();
}