/*Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа. */
int randomFromRangeThreeNumber = new Random().Next(100, 1000);
Console.WriteLine(randomFromRangeThreeNumber);
int averageOne = randomFromRangeThreeNumber / 100;
int averageThree = randomFromRangeThreeNumber % 10;
Console.Write($"{averageOne}{averageThree}");
