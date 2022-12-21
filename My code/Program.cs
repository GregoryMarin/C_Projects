void FillArray(int[] context)
{
    int length = context.Length;
    int index = 0;
    while (index < length)
    {
        context[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] write)
{
    int counter = 0;
    int ammount = write.Length;
    while (counter < ammount)
    {
        Console.Write($" {write[counter]}");
        counter++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
