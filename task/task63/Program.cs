/*Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
printRange(userNumber);
void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    printRange(N-1);
    Console.Write($"{N}, ");
}