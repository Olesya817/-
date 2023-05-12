/*Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/
Console.WriteLine("Введите число ");
int userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
int userNumberTwo = Convert.ToInt32(Console.ReadLine());

printRange(userNumberOne-1, userNumberTwo);

void printRange(int NumberOne, int NumberTwo)
{
    if (NumberOne == NumberTwo)
    {
        return;
    }
    printRange(NumberOne, userNumberTwo-1);
    Console.Write($"{userNumberTwo}, ");
}
