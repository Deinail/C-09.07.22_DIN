﻿// Задать массив из 8 целых элементов и вывести их на экран

int[] t;
t=new int[8];
t[0]=10;
for (int i=0;i<t.Length;i++)
    t[i]=i*10;
for (int i=0;i<t.Length;i++)
    System.Console.WriteLine($"a[{i}]={t[i]} ");
