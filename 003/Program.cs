//С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a>b)
{
    System.Console.WriteLine("а больше b");
}
else 
{
    System.Console.WriteLine("b больше а");
}