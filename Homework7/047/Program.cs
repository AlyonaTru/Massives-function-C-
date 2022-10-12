// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void Zadacha047()
{
    Random random = new Random ();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] numbers = new double[rows,columns];
    FillArray(numbers);
  
        
// печать массива 
         for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            Console.Write(numbers[i,j] + " \t");
        }
        Console.WriteLine();
        }
    }

Zadacha047();

void FillArray(double[,] numbers)
{
    Random random = new Random ();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
     for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         numbers[i,j] = Convert.ToDouble(random.Next(-10, 11)/10.0); 
        }
        }
}