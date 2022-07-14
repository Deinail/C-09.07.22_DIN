// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int n = Convert.ToInt32(Console.ReadLine());
int LastDigit = (int)(n % 10);
System.Console.WriteLine(LastDigit);