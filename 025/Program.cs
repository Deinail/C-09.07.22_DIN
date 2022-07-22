// Вывести на экран кубы чисел от 1 до N

// Вывести на экран таблицу квадратов чисел от 1 до N

Console.Clear();
System.Console.WriteLine();

System.Console.Write($"Введите число:   ");
int N = Convert.ToInt32(Console.ReadLine());

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = number * number * number;
        number++;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);
