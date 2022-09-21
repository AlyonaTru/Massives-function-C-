// 16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

void Zadacha016()
{
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if((a == b * b) || (b == a * a))
{
    Console.WriteLine("Результат: да, одно число является квадратом другого ");
}

else 
{
    Console.WriteLine("Результ: нет, одно число не является квадратом другого");
}
}
Zadacha016();