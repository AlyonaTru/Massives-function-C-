// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void Zadacha058()
{
Console.Write("Ведите кол-во строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите кол-во колонок первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите кол-во строк второй матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите кол-во колонок второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());

if (b != c)
    Console.Write("Невозможно найти произведение двух матриц.");
else
{
    int[,] numbers1 = new int[a, b];
    int[,] numbers2 = new int[c, d];
    FillArray(numbers1);
    FillArray(numbers2);
    Console.WriteLine($"Первая матрица:");
    PrintArray(numbers1);
    Console.WriteLine($"Вторая матрица:");
    PrintArray(numbers2);
    int[,] result = new int[b,c];
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintArray(MultiplyArrays(numbers1, numbers2));
    
}

}
Zadacha058();

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

int[,] MultiplyArrays(int[,] numbers1, int[,] numbers2)
{
    int[,] result = new int[numbers2.GetLength(1), numbers1.GetLength(0)];

    for (int i = 0; i < numbers2.GetLength(1); i++)
    {
        for (int j = 0; j < numbers1.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < numbers1.GetLength(1); k++)
            {
                sum = sum + numbers1[i, k] * numbers2[k, j];
                result[i, j] = sum;
            }
        }
    }
    return result;
}
 