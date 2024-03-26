/*
Напишите программу, которая проверят кратное ли число друг другу.
*/

System.Console.WriteLine("Введите два числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(number, 2) == number2 || Math.Pow (number2, 2) == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
