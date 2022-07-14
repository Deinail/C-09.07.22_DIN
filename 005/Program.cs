// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int i;
int[] Ar = new int [100];
i = 0;
do
{
    Ar[i] = Convert.ToInt32(Console.ReadLine());
    i=i+1;
}
while (Console.ReadLine() != "end");

int ArMax=Ar.Max<int>();

System.Console.WriteLine(ArMax);
