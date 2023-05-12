/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
Console.Write("Введите число: ");
int userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число  ");
int userNumberTwo = Convert.ToInt32(Console.ReadLine());

SumFromMToN(userNumberOne, userNumberTwo);

void SumFromMToN(int userNumberOne, int userNumberTwo)
{
    Console.Write(SumMN(userNumberOne - 1, userNumberTwo));
}

int SumMN(int userNumberOne, int userNumberTwo)
{
    int res = userNumberOne;
    if (userNumberOne == userNumberTwo)
        return 0;
    else
    {
        userNumberOne++;
        res = userNumberOne + SumMN(userNumberOne, userNumberTwo);
        return res;
    }
}