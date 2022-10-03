// задайте массив. Напишите программу, кот определяет, присутствует ли заданное число в массиве


void Zadacha033()
{
    int size = 12;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); // вызов двух методов
    IdentifyNumber(numbers);
}
Zadacha033();

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

void IdentifyNumber(int[]numbers)
{ Console.WriteLine("Введите число: ");
  int a = Convert.ToInt32(Console.ReadLine());
  bool ident = false;
    for (int i =0; i< numbers.Length; i++)
      {
            if (a == numbers[i])
         {
             ident = true;
         }
           
      }
      if(ident == true)
       Console.WriteLine($"Число {a} находится в массиве.");   
       else
       Console.WriteLine($"Число {a} не находится в массиве.");   
}
