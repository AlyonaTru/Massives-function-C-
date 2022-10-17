/*Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());


int AckermannFunc (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunc(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
return AckermannFunc(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunc(m, n)}");