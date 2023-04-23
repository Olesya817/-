/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
Console.WriteLine("Введите первое число ");
int usereNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (usereNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine($"число {usereNumber1} является квадратом числа {userNumber2}");
}
if (userNumber2 == usereNumber1 * usereNumber1)
{
    Console.WriteLine($"число {userNumber2} является квадратом числа {usereNumber1}");
}
else
{
    Console.WriteLine($"нет квадратов");
}