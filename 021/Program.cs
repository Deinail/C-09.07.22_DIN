// Задать номер четверти, показать диапазоны для возможных координат

int quarter_number=Convert.ToInt32(Console.ReadLine());
if (quarter_number==1)
{
    System.Console.WriteLine("от у=1..., и х=1...");
}
else if (quarter_number==2)
{
    System.Console.WriteLine("от у=1..., и х=-1...");
}
else if (quarter_number==3)
{
    System.Console.WriteLine("от у=-1..., и х=-1...");
}
else if (quarter_number==4)
{
    System.Console.WriteLine("от у=-1..., и х=1...");
}
else
{
    System.Console.WriteLine("Всего 4 координатных плоскости");
}