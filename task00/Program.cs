/*
Напишите программу, которая на вход принемает число и выдает его квадрат
(Число умноженное на само себя)


    4 -> 16
    -3 -> 9
    -4 -> 49
    */

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);