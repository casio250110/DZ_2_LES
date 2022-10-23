// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = new Random().Next(100, 999);
Console.WriteLine(number);
int result = (number % 100) / 10;
Console.WriteLine($"Вторая цифра числа {number} = {result}");