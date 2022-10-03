// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void Zadacha038()
{
    int size = 5;
    double[] numbers = new double[size];
    
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    DiffMinMax(numbers);
}
Zadacha038();

void FillArray(double[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.NextDouble();
        numbers[i] = Math.Round(numbers[i], 3);
        
    }
}

void PrintArray(double[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void DiffMinMax(double[]numbers)
{ 
    double diff=0;
    double min = numbers.Min();
    double max = numbers.Max();
    for (int i =0; i< numbers.Length; i++)
      {
         diff = numbers.Max() - numbers.Min();
        }
    
    Console.WriteLine($"разница =  {diff}.");   
       
}
