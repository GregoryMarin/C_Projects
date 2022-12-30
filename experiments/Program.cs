using System;
using System.Globalization;



double firstValue, secondValue;
System.Console.WriteLine("Введите число 1: ");

firstValue = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");

secondValue = double.Parse(Console.ReadLine());

System.Console.WriteLine(firstValue, secondValue);