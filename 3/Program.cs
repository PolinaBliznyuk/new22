﻿// Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ведите число");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count =1;
while (count<= num)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}