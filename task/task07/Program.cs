/*Напишите программу, которая принимает на вход трехзначное число 
и на выходе показывает последнюю цифру этого числа*/
Console.WriteLine("Введите трехначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 10;
Console.Write($"Последняя цифра числа {ostatok}");
