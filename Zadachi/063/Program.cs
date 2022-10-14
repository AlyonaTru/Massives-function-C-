// Решите задачу через рекурсию: задайте число N. Пусть программа выведет все натуральные числа от 1 до N.

Console.WriteLine(" Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Zadacha063(n); // первичный вызов рекурсии
void Zadacha063(int n, int a =0)
{
    a++;
    Console.Write($" {a} \t");
    if (a >=n)
    {
        return;
    }
Zadacha063(n, a);

}
// void Zadacha063() // это решение циклом
// {
//  Console.WriteLine(" Введите натуральное число: ");
//  int n = Convert.ToInt32(Console.ReadLine());
 
//  for (int i = 1; i<= n; i++) 
//  {
//     Console.Write($"{i} \t");
//  }


// }
// Zadacha063();