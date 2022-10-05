// программа, которая перевернет одномерный массив(последний эл на первом месте и тд)
// [12345] -> [54321]


// найдите пр-е пар чисел в одномерном массиве. Парой считаем 1 и посл, 2 и предпосл элементы и тд. 
// Результат запишите в новом массиве.

void Zadacha039()
{
    int size = 10;
    int[]numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers); 

    int maxIndex = size-1;
    for (int i =0; i< size/2; i++)
    {
    //  int temp = numbers[i];
    //  numbers[i] = numbers[maxIndex -i];
    //  numbers[maxIndex -i] = temp;
    // то же самое с помощью кортежа:
     (numbers[i], numbers[maxIndex -i]) = (numbers[maxIndex -i], numbers[i]);



    }
     PrintArray(numbers);
    }

Zadacha039();

void FillArray(int[]numbers, int minValue =0, int maxValue =9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[]numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

