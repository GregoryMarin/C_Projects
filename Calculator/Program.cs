Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Characters(int n1, int n2)
{
    System.Console.WriteLine("Введите значение: ");
    var a = Console.ReadLine();
    switch (a)
    {
        case "*":
            int result = n1 * n2;
            System.Console.WriteLine($"Результат умножения чисел = {result}");
            break;
        case "/":
            int result1 = n1 / n2;
            System.Console.WriteLine($"Результат деления чисел = {result1}");
            break;
        case "-":
            int result2 = n1 - n2;
            System.Console.WriteLine($"Результат вычитания чисел = {result2}");
            break;
        case "+":
            int result3 = n1 + n2;
            System.Console.WriteLine($"Результат сложения чисел = {result3}");
            break;
        default:
            {
                System.Console.WriteLine("неверное значение");
                break;
            }
    }
}


if (number > 0 && number2 > 0) 
{
    Characters(number, number2);
}
else System.Console.WriteLine("неверное значение");