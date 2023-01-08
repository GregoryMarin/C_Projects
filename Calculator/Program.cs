
// Console.Clear();
// double firstNumber, secondNumber;
// string action;

// Console.WriteLine("Введите первое число: ");
// firstNumber = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// secondNumber = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите действие ('+', '-', '*', '/')");
// action = Console.ReadLine();
//     switch (action)
//     {
//         case "+":
//             Console.WriteLine(firstNumber + secondNumber);
//             break;
//         case "-":
//             Console.WriteLine(firstNumber - secondNumber);
//             break;
//         case "*":
//             Console.WriteLine(firstNumber * secondNumber);
//             break;
//         case "/":
//             if (firstNumber == 0 || secondNumber == 0) Console.WriteLine("На ноль делить нельзя!");
//             else Console.WriteLine(firstNumber / secondNumber);
//             break;
//         default:
//             Console.WriteLine("Неверные данные");
//             break;
//     }

System.Console.WriteLine("Введите 2 числа от 0 до 1000: ");
double firstNumber = Convert.ToInt32(Console.ReadLine());
double secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите действие которуе нужно совершить('*', '/', '+', '-'): ");
string action = Console.ReadLine();


void TableOfAction(double n1, string act)
{   
    if (firstNumber >= 0 && firstNumber <= 1000)
    {        
        if (action == "*")
        {
            var result = firstNumber * secondNumber;
            double res = Math.Round(result, 3, MidpointRounding.ToZero);
            System.Console.WriteLine($"{firstNumber} {action} {secondNumber} = {res}");
        }
        if (action == "/")
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                System.Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
                var result = firstNumber / secondNumber;
                double res = Math.Round(result, 3, MidpointRounding.ToZero);
                System.Console.WriteLine($"{firstNumber} {action} {secondNumber} = {res}");
            }
        }
        if (action == "+")
        {
            var result = firstNumber + secondNumber;
            double res = Math.Round(result, 3, MidpointRounding.ToZero);
            System.Console.WriteLine($"{firstNumber} {action} {secondNumber} = {res}");
        }
        if (action == "-")
        {
            var result = firstNumber - secondNumber;
            double res = Math.Round(result, 3, MidpointRounding.ToZero);
            System.Console.WriteLine($"{firstNumber} {action} {secondNumber} = {res}");
        }
        if (action != "*" && action != "/" && action != "+" && action != "-")
        {
            System.Console.WriteLine("Неверный символ(");
        }
    }
    else
    {
        System.Console.WriteLine("Число больше 1000!");
    }
}
TableOfAction(firstNumber, action);