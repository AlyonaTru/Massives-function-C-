// Задайте двумерный массив. Наиишите программу, которая заменяет строки на столбцы. В случае, если 
// это невозможно, программа должна вывести сообщение пользователю.

void Zadacha055()
{
    Random random = new Random();
    int rows = random.Next(4, 8); // или сразу поставить заглушку int rows = columns (но тогда условие неточно)
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    if (rows == columns)
    {
    Console.WriteLine("Поменяли строки на столбцы:");
    ChangeRowsForColumns(numbers);
    PrintArray(numbers);
    }
    else 
    Console.WriteLine("Задача невыполнима");
       
}
Zadacha055();
   

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

void ChangeRowsForColumns(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int maxColumns = numbers.GetLength(1);
      for (int i = 0; i< rows; i++)
    {
        for (int j =i; j < maxColumns; j++)
        {
        (numbers[i,j], numbers[j,i]) = (numbers[j,i], numbers[i,j]);
        
        }
        Console.WriteLine();
}
   
}