/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Console.WriteLine("Input number N ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getSum(UserNumber));

int getSum (int N)
{
    if (N == 0)
    {
        return 0;
    }
    int digit = N%10;
    return digit+getSum(N/10);
}