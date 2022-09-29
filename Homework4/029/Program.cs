// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]           6, 1, 33 -> [6, 1, 33]

void Zadacha029()
{
    Random random = new Random();
    int size = random.Next(1, 10);
    int[] numbers = new int [size];
    Console.WriteLine($"размер массива = {size}");

    for (int i= 0; i <size; i++)
    {
        numbers[i] = random.Next(0,15);
    }

    for (int i = 0; i < size; i++)
    {
    Console.Write($"[ {numbers[i]} ]");
    }

Console.WriteLine();

}
Zadacha029();