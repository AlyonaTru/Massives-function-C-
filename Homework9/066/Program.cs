// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N с помощью рекурсии. M = 1; N = 15 -> 120   M = 4; N = 8 -> 30

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2)
{
Console.WriteLine("Некорректное значение, число 1 должно быть меньше, или равно числа 2");
}

Console.WriteLine(SumNum(num1, num2));

int SumNum(int num1, int num2)
{
    int result = 0;
    for (int i = num1; i <= num2; i++)
            {
                result += i;
            }
            return result;      
       
    SumNum(num1, num2);
}
