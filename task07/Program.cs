﻿/*Напишите программу, которая принемает на вход 3-ех значное число и на выходе показывает последюю цифру этого числа
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99  && number < 1000)
{
    Console.Write(number%10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
