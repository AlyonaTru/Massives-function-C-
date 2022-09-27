// программа, которая выводит массив из 8 элементов, заполненный нулями и единицами
// в случайном порядке


void Zadacha030()
{
    Random random = new Random();
    int size = random.Next(4, 10);
    int [] numbers = new int [size];
    Console.WriteLine($"размер массива = {size}");

    for (int i= 0; i <size; i++)
    {
        numbers[i] = random.Next(0,2);
    }

for (int i = 0; i < size; i++)
{
    Console.WriteLine(numbers[i] + "\t");
}

Console.WriteLine();


}
Zadacha030();