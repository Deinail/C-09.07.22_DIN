// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// По заданному с клавиатуры номеру дня недели вывести его название

string [] days_of_the_week = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
int i=1;
int InputValue = Convert.ToInt32(Console.ReadLine());
int desired_day = (InputValue - i);


if(desired_day<5)
{
   
    System.Console.WriteLine(days_of_the_week[desired_day]);
}
else if (desired_day<7)
    {
        System.Console.WriteLine($"{days_of_the_week[desired_day]} day off");
    }
else
{
    System.Console.WriteLine("Дней в неделе только 7");
}
