﻿// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a*a==b)
{
    System.Console.WriteLine("b является квадратом а");
}
else 
{
    if (b*b==a)
    {
        System.Console.WriteLine("а является квадратом b");
    }
    else System.Console.WriteLine("Числа не являются числами друг друга");
}