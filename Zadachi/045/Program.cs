// программа, которая будет создавать копию заданного массива с помощью поэлементарного копирования

void Zadacha045()
{
    int size = 10;
    int[]numbers = new int[size];
    int[] other = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    
    for(int i = 0; i< size; i++)
    {
        other[i] = numbers[i];
    }
   Console.WriteLine();
   PrintArray(other);

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 10);
    }
}

void PrintArray(int[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
}Zadacha045();