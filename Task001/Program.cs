﻿// Вывод случайного числа из отрезка [10, 99], вывод наибольшей цифры числа.

int number = new Random().Next(10, 100);
Console.WriteLine(number);
int digit1 = number / 10;
int digit2 = number % 10;
if(digit1 > digit2) 
    Console.WriteLine(digit1);
else 
    Console.WriteLine(digit2);
