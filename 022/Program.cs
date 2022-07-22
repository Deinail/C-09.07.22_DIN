// Программа проверяет пятизначное число на палиндромом.
var CheckNubmer="15351";
if (CheckNubmer.Reverse().SequenceEqual(CheckNubmer)) Console.WriteLine("Палиндром!");
else System.Console.WriteLine("Не палиндром");