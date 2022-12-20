using static System.Console;

WriteLine("Является ли число a квадратом числа b?");

Write("Введите число а: ");
int a = int.Parse(ReadLine());
Write("Введите число b: ");
int b = int.Parse(Readline());
   
if (b * b == a)
{
    WriteLine("Да");
}   
else
{
    WriteLine("Нет");
}
