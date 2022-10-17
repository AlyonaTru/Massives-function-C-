// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД)
// этих чисел с помощью рекурсии.   M = 28; N = 7 -> 7

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Divider(m, n)); 

int Divider(int m, int n)
{ 
    if (m ==n) return m;
    if (m < n) return Divider(m, n-m);
    else return Divider(m -n, n);
    
 } 
Divider(m, n);