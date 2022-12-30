﻿// Напишите конвертер валют 

System.Console.WriteLine("By: 1 US_Dollar = 65 Ruble");
System.Console.WriteLine("Sell: 70 Ruble = 1 US_Dollar");
System.Console.WriteLine("What currency you wont to exchange? (Write Dollar = 1 or Ruble = 2)");
int currency = Convert.ToInt32(Console.ReadLine());

void Currency(int value1)
{
    if (value1 == 1)
    {
        System.Console.WriteLine("You want to sell Dollar in currency 1 : 65");
        System.Console.WriteLine("How much you wish to exchange?");
        double dollar = Convert.ToDouble(Console.ReadLine());
        double result = dollar * 65.00;
        double result2 = Math.Round(result, 2, MidpointRounding.ToZero);
        System.Console.WriteLine($"It will be {result2} Rubles");
    }
    if (value1 == 2)
    {
        System.Console.WriteLine("You want to sell ruble in currency 0.70 : 1");
        System.Console.WriteLine("How much you wish to exchange?");
        double ruble = Convert.ToDouble(Console.ReadLine());
        double result = ruble / 70.00;
        double result2 = Math.Round(result, 2, MidpointRounding.ToZero);
        System.Console.WriteLine($"It will be {result2} US_Dollars");
    }
}
Currency(currency);