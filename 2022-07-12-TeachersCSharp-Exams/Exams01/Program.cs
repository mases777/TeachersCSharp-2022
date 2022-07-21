Console.Write("Въведете номер за месеца: ");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1: Console.WriteLine("Месец: Януари"); break;
    case 2: Console.WriteLine("Месец: Февруари"); break;
    case 3: Console.WriteLine("Месец: Март"); break;
    case 4: Console.WriteLine("Месец: Април"); break;
    case 5: Console.WriteLine("Месец: Май"); break;
    case 6: Console.WriteLine("Месец: Юни"); break;
    case 7: Console.WriteLine("Месец: Юли"); break;
    case 8: Console.WriteLine("Месец: Август"); break;
    case 9: Console.WriteLine("Месец: Септември"); break;
    case 10: Console.WriteLine("Месец: Октомври"); break;
    case 11: Console.WriteLine("Месец: Ноември"); break;
    case 12: Console.WriteLine("Месец: Декември"); break;
    default:
        Console.WriteLine("Няма такъв месец.");
        break;
}