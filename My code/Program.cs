

int[] array = {};



int index = 0;
System.Console.WriteLine("Введите число, которое будет колличеством кормлений ребенка в сутки: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите часы, в которые вы обычно кормите ребенка:");
while (index < amount)
{
    
    int numbers = Convert.ToInt32(Console.ReadLine());
    Console.Write(numbers);
    index++;
}
