// задайте массив из 12 элементов, заполните случайными числами из промежутка [-9, 9]
// Найдите сумму отриц и положит элементов массива.

void Zadacha031()
{
    int size = 12;
    int[]numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    Console.WriteLine(GetSumPositive(numbers));
    Console.WriteLine(GetSumNegative(numbers));
}

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 10);
    }
}

void PrintArray(int[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + "");
    }
} Console.WriteLine();

int GetSumPositive(int[]numbers)
{
    int sum =0;
    for (int i =0; i<numbers.Length; i++)
    {
        if (numbers[i] >0)
        sum= sum+numbers[i];
    }
    return sum; // пишем return тк тип a того требует
}

int GetSumNegative(int[]numbers)
{
    int sum2 =0;
    for (int i =0; i<numbers.Length; i++)
    {
        if (numbers[i] <0)
        sum2= sum2+numbers[i];
    }
    return sum2;
}

Zadacha031();