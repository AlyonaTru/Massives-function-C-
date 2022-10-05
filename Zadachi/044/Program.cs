// не используя рекурсию выведите первые N чисел Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

void Zadacha044()
{
  Console.WriteLine("введите число"); 
  int size = Convert.ToInt32(Console.ReadLine());
  int a = 0;
  int b = 1;
  double[] numbers = new double [size];
  numbers[0] = a;
  numbers[1] = b;

  for (int i = 2; i<numbers.Length; i++)
  {
    numbers[i] = numbers[i-2] + numbers[i-1];
  }
   PrintArray(numbers);
   
void PrintArray2(int[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
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
}
Zadacha044();