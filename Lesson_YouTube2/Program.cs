// Введите три числа и выведите на экран значение суммы и произведения этих чисел

double firstNumber, secondNumber, thirdNumber;

System.Console.WriteLine("Введите первое число: ");
firstNumber = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
secondNumber = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
thirdNumber = double.Parse(Console.ReadLine());

void Number(double n1, double n2, double n3)
{
    double summ = n1 + n2 + n3;
    double multiplication = n1 * n2 * n3;
    System.Console.WriteLine($"сумма чисел = {summ} произведение чисел = {multiplication} ");
}

Number(firstNumber, secondNumber, thirdNumber);