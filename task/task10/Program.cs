/*10. Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number / 10;
int numberTwo = ostatok % 10;
Console.WriteLine($"{numberTwo} это вторая цифра трехзначного числа {number}");
