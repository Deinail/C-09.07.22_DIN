// Определить количество цифр в числе. Сделать подпрограмму.
int d;
System.Console.WriteLine("Введите число");
d=Convert.ToInt32(Console.ReadLine());
int CountDigits(int N)
{
    int k=0;
    while(N!=0)
    {
        k++;
        N=N/10;
    }
return k;
}

System.Console.WriteLine(CountDigits(d));