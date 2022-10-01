// программа, которая принимает на вход число А, выдает сумму чисел от 1 до А

void Zadacha024()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0; // переменная-накопитель для суммы

    for (int i = 1; i <= number; i++)
    {
        //Console.Write($"{i} + " );
        sum = sum + i;
    }
     Console.WriteLine(sum);
}
Zadacha024();