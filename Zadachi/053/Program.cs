// задайте двумерный массив. Напишите программу, которая поменяет первую и последнюю строки массива местами

void Zadacha053()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Перевернули массив");
    ChangeElements(numbers);
    PrintArray(numbers);

    
}
Zadacha053();
   

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

void ChangeElements(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int maxIndex = rows-1;
    int maxColumns = numbers.GetLength(1);
  
    for (int j =0; j < maxColumns; j++)
    {
        (numbers[0,j], numbers[maxIndex,j]) = (numbers[maxIndex,j], numbers[0,j]);
        
    }
    Console.WriteLine();
}