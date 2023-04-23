/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру*/
/* int dayWeek = new Random().Next(1, 8); Генерирует случайное число вдиапозоне от 1 до 7 включительно*/
Console.WriteLine("Введите цифру от 1 до 7");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (dayWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (dayWeek == 3)
{
    Console.WriteLine("Среда");
}
if (dayWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (dayWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (dayWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (dayWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else if (dayWeek > 7)
{
    Console.WriteLine("Введите другое число");
}