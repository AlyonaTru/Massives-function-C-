// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов,
// которые необходимо заполнить случайными значениями и определить существует ли 
//пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на 
//уникальное значение.  [1,2,3,3] -> [1,2,3,4]

void ZadachaExtra2()
{
    int size = 5;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    DoubleNumbersSwap(numbers);
}
ZadachaExtra2();

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 11);
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

void  DoubleNumbersSwap(int[]numbers)
{ 
    int size = 5;
    bool find = false;
    Random rand = new Random ();
    int maxIndex = size-1;
   
            for (int i = 0; i < maxIndex; i++)
            {
            if (numbers[i] == numbers[i+1])
            {
            numbers[i] = rand.Next(80, 100);
            find = true;
            
        }
            }

        
        if(find == true)
        PrintArray(numbers);  
        
        else
        Console.WriteLine("замена не требуется");     
        
    }
     


