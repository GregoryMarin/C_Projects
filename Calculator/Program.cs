
Console.Clear();
double firstNumber, secondNumber;
string action;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите действие ('+', '-', '*', '/')");
action = Console.ReadLine();
    switch (action)
    {
        case "+":
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case "-":
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case "*":
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case "/":
            if (firstNumber == 0 || secondNumber == 0) Console.WriteLine("На ноль делить нельзя!");
            else Console.WriteLine(firstNumber / secondNumber);
            break;
        default:
            Console.WriteLine("Неверные данные");
            break;
    }