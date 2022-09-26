// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Zadacha023()
{

Console.WriteLine("Введите число: ");
int a  = Convert.ToInt32(Console.ReadLine());
int i =1;
double Sqw;

while (i <= a)
{
    Sqw = Math.Pow(i, 3);
    Console.WriteLine($"|{i}|{Sqw}|");
    i++;
}
}
Zadacha023();