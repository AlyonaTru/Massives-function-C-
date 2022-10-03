// найдите пр-е пар чисел в одномерном массиве. Парой считаем 1 и посл, 2 и предпосл элементы и тд. 
// Результат запишите в новом массиве.

void Zadacha037()
{
    int size = 11;
    int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); 
    
int maxIndex = size-1;
for(int i =0; i< size/2; i++)
{
    Console.WriteLine($"{numbers[i]}*{numbers[maxIndex - i]} = {numbers[i]*numbers[maxIndex - i]} ");
}
if (size % 2 ==1)
{
    Console.WriteLine($" средний элемент массива = {numbers[size/2]}"); // вывод среднего числа массива при нечетном значении размера
}

}
Zadacha037();

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 100);
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

