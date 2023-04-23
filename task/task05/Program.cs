/*Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.*/
Console.Write("Введите целое число ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = -numb;
while (count <= numb)
{
    Console.Write($"{count}, ");
    count++;
}

