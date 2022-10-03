// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void Zadacha036()
{
    int size = 5;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    SumUnevenIndex(numbers);
}
Zadacha036();

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-100, 101);
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

void SumUnevenIndex(int[]numbers)
{ 
    int sum =0;
    for (int i =0; i< numbers.Length; i++)
      {
            if (numbers[i]%2 ==0)
        {
            sum = sum+ numbers[i];
        }
        }
    Console.WriteLine($"сумма четных элементов =  {sum} .");   
       
}
