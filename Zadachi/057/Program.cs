// составить частотный словарь элемента двум массива. ЧС содержит инф о том, сколько раз 
//встречается элемент входных данных

void Zadacha057()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    int[] counts = new int[10];

    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            counts[numbers[i,j]]++;
        } 
    }
   
   for (int i =0; i< 10; i++)
    {
        Console.WriteLine($"Количество {i} в массиве равно {counts[i]}");
    }
   
}
Zadacha057();

void FillArray(int[,] numbers)
{
    Random random = new Random ();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
     for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         numbers[i,j] = random.Next(0, 10);
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


