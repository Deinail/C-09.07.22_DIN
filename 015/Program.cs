// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

int str = Convert.ToInt32(Console.ReadLine());
if (str>99)
{
    string ar = Convert.ToString(str);
    Console.WriteLine (ar[2]);
}
else
{
    Console.WriteLine("Третьего числа нету");
}
