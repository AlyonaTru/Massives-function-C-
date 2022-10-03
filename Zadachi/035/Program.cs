// Задайте одномерный массив, состоящий из случ чисел. Найдите кол-во элементов массива, которые лежат в отрезке
// [10, 99]

void Zadacha035()
{
    int size = 5;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); 
    FindArray(numbers);
}
Zadacha035();

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 100);
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

void FindArray(int[]numbers)
{
    int count = 0;
  for (int i =0; i<numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество принадлежащих заданному промежутку чисел = {count}");
}
