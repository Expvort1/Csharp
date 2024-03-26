/*
Напишите программу, которая выводлит случайное число из отрезко [10,99] и показывает наибольшую цифру числа.
78 -> 3
12 -> 2
85 -> 8
*/

int number = new Random(). Next(10, 100);
System.Console.WriteLine(number);

int first = number / 10;
int second = number % 10;
int max = first;

if (second > first)
{
    max = second;
}
System.Console.WriteLine(max);
