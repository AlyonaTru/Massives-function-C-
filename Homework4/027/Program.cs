// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
//82 -> 10
// 9012 -> 12

void Zadacha027()
{
Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 0; number > 0; i++)
{
int digit = number%10;
number = number /10;
result = result + digit;

}



Console.WriteLine($"Сумма цифр в числе = {result}");
}
Zadacha027();