﻿// Напишите программу которая 
// 1. на вход принимает число 
// 2. и выдаёт его квадрат (число
// умноженное на себя само)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// string str = Console.Readline(); /// 24234. fhffhht
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
// int number1 = int.Parse(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
