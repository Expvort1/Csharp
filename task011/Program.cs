/*
Напишите задачу, которая будет выдавать случайное 3-ех значное число и удалять у него центральную цифру
*/

int number = new Random(). Next(100, 1000);
System.Console.WriteLine(number);

int dig1 = number / 100;
int dig2 = number % 10;
System.Console.WriteLine(dig1*10 + dig2);