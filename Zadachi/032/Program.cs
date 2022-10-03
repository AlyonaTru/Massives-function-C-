// напишите программу замены элементов массива: положит элем замените на 
//соответствующие отрицательные и наоборот [-4 -8 8 2] -> [4 8 -8 -2]

void Zadacha032()
{
    int size = 12;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    ChangeValueArray(numbers);
}
Zadacha032();

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
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void ChangeValueArray(int[]numbers)
{
    Console.WriteLine("Вывод перевернутого массива: ");
    for (int i =0; i< numbers.Length; i++)
      {
         if (numbers[i] <0)
         {
            numbers[i] = Math.Abs(numbers[i]);   // или просто = numbers[i]*-1;
         }
           else
         {
            numbers[i] = -numbers[i];
         }
         Console.Write(numbers[i] + " ");
      }
      
}