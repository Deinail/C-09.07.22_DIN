// Дано число. Проверить кратно ли оно 7 и 23
bool b,c;
int x= Convert.ToInt32(Console.ReadLine());
b=x%7==0;
c=x%23==0;
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(x%7==0 && x%23==0);