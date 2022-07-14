 // Написать программу вычисления значения функции y = sin(a). (Класс Math).
double a = Convert.ToInt32(Console.ReadLine());
a = (a * Math.PI / 180);
double y = (Math.Sin (a));
System.Console.WriteLine(y);