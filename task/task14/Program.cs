﻿/*14.	Напишите программу, 
которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
 14 -> нет 
 46 -> нет 
 161 -> да*/
 Console.WriteLine("Введите число ");
 int number = Convert.ToInt32(Console.ReadLine());
 int multipelSeven = number % 7;
 int multipeTwentyThree = number % 23;
 if (multipelSeven == 0 && multipeTwentyThree == 0)
 {
    Console.WriteLine($"{number} кратно 7 и 23");
 }
 else
 {
    Console.WriteLine($"{number} не кратно 7 и 23");
 }