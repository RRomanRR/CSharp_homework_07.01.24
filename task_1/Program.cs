﻿// напишите программу, которая на вход принимает трёхзначное число и удаляет вторую цифру числа а=256 => 26

Console.WriteLine("Введите цифры трёхзначного числа");

int a = int.Parse(Console.ReadLine()!);


Console.WriteLine(a / 100 * 10 + a % 10);
