/*
Напишите программу, которая принемает число на вход и проверяет, кратно ли оно 7 и 23 одновнеменно
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 ==0)
{
    System.Console.WriteLine("Кратное");
}
else
{
    System.Console.WriteLine("Некратно");
}