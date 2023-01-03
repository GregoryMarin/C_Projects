double firstNumber, secondNumber;
string action;
Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите действие ('+', '-', '*', '/')");
action = Console.ReadLine();

void Calculator(double n1, double n2)
{

    switch (action)
    {
        case "+":
            Console.WriteLine(n1 + n2);
            break;
        case "-":
            Console.WriteLine(n1 - n2);
            break;
        case "*":
            Console.WriteLine(n1 * n2);
            break;
        case "/":
            if (n1 == 0 || n2 == 0) Console.WriteLine("Число не делится на ноль");
            else Console.WriteLine(n1 / n2);
            break;
        default:
            Console.WriteLine("Неверные данные");
            break;
    }
}

Calculator(firstNumber, secondNumber);