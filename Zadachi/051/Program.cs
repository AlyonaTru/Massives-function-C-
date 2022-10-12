////  задайте двумерный массив, найдите сумму элементов, находящихся на главной диагонали
// с инд 0.0 1,1 2,2 и тд

void Zadacha051()
{
    Random random = new Random ();
    int rows = random.Next(4, 8);
    int columns = rows;
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    int sum =0;
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            if (i == j)
            {
             sum = sum + numbers[i,j];
            }
        } 
    }
    Console.WriteLine();
    Console.Write(sum);
   
  
}
Zadacha051();

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