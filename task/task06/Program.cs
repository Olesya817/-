/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Введите число ");
int evenNumber = Convert.ToInt32(Console.ReadLine());
if (evenNumber % 2 > 0)
{
    Console.WriteLine($"{evenNumber} нечетное число");
}
else 
Console.WriteLine($"{evenNumber} четное число");