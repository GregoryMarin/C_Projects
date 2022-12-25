using System;
using System.Globalization;

string str = 5.9;
NumberFormatInfo numberFormatInfo = new numberFormatInfo()
{
    NumberDecimalSeparator = ".",
};
double a = double.Parse(str, numberFormatInfo);