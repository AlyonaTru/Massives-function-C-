// Программа, которая принимает на вход число N и выдает произведение чисел от 1 до N

void Zadacha028()
{
    Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
//for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
// int i  - целочисленная переменная-счетчик


for (int i = 1; i <= number; i++)
{
    result = result*i;
}

Console.WriteLine($"Произведение чисел = {result}");


}
Zadacha028();