// // Задача 65: Задайте значения M и N . Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> 1 2,3 4 5


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Zadacha065(n,m );

void Zadacha064(int n, int a = 1)
{
Console.WriteLine(a);
a++;

if (a>= n)
{
   return;
}
Zadacha065(n, a);
}