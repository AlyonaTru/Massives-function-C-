// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные 
//числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

    if (m > n)
    {
        Console.WriteLine("Некорректное значение, N должно быть > M.");
    }

Zadacha064(n,m);
void Zadacha064(int n, int a = 1)
{
    if (a % 2 == 0)
    {
    Console.WriteLine($"{a} \t");
    a++;
    }
    else
    {
     a++; 
    }
    if (a>=n)
    {
        return;
    }

    Zadacha064(n, a);
}