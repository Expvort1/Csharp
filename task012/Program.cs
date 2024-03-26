/*
Напишите программу, которая на вход будет принемать 2 числа и выводить, является ли число крастное воторому. 
Если второе число некратно первому, то программа выводит остаток от деления.
*/

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 ==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("Некратно " +number1 % number2);
}