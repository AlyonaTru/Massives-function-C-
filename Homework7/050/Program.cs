// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1,7 -> такого числа в массиве нет


void Zadacha050()
{
    Console.WriteLine("Введите номер строки:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[10, 10];
    FillArray(numbers);

    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет.");
    }
    else
    {
        Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {numbers[n - 1, m - 1]}");
    }
    PrintArray(numbers);

     
}
Zadacha050();

void FillArray(int[,] numbers)
{
    Random random = new Random ();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
     for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         numbers[i,j] = random.Next(-10, 11);
        }
        }
}

void PrintArray(int[,] numbers)
 {
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            Console.Write(numbers[i,j] + " \t");
        }
        Console.WriteLine();
    }
 }