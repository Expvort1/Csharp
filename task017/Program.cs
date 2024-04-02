/*
Задайте масив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа 
должна выдавать ответ: Да/Нет.
*/

int[] array ={1, 3, 4, 19, 3};
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int v = 0;

foreach (int e in array)
{
    if (e == x) {v = x;}
}

if (v == x)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}