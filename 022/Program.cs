// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
// чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void Zadacha022()
{

Console.WriteLine("Введите число: ");
int a  = Convert.ToInt32(Console.ReadLine());
int i =1;
double Sqw;

while (i <= a)
{
    Sqw = Math.Pow(i, 2);
    Console.WriteLine($"|{i}|{Sqw}|");
    i++;
}

}
Zadacha022();