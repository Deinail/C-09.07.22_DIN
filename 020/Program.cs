// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x,y;
System.Console.WriteLine("Введите координат х");
x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координат у");
y=Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("Это первая четверть");
}
if (x<0 && y>0)
{
    System.Console.WriteLine("Это вторая четверть");
}

if (x<0 && y<0)
{
    System.Console.WriteLine("Это третья четверть");
}
if (x>0 && y<0)
{
    System.Console.WriteLine("Это четвертая четверть");
}