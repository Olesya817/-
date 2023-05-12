/*Напишите программу, которая будет принимать на вход два числа и 
выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно*/
Console.WriteLine("Введите первое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int multiple = numberOne % numberTwo;
if (multiple == 0)
{
    Console.WriteLine($"Число {numberTwo} кратно числу {numberOne}");
}
else
{
    Console.WriteLine($"Остаток от деления {multiple}");
}