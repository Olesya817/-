/*16. 5.	Напишите программу, 
которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет*/
Console.WriteLine("Введите первое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int squareOneNumber = numberOne*numberOne;
int squareTwoNumber = numberTwo*numberTwo;
if (numberOne == squareTwoNumber)
{
    Console.WriteLine($"Число {numberOne} является квадратом числа {numberTwo}");
}
else if (numberTwo == squareOneNumber)
{
    Console.WriteLine($"Число {numberTwo} является квадратом числа {numberOne}");
}
else
{
    Console.WriteLine("Нет квадратов");
}