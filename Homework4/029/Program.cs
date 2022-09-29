// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]           6, 1, 33 -> [6, 1, 33]

void Zadacha029()
{
    Random random = new Random();
    int size = random.Next(1, 100);
    int [] numbers = new int [size];
    Console.WriteLine($"размер массива = {size}");
   
  

   
// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine(numbers[i] + "\t");
// }

// Console.WriteLine();


}
Zadacha029();