// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

void Zadacha014()
{
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 7 == 0)&&(a % 23 == 0))
{
        Console.WriteLine("Результат: да, кратно 7 и 23 одновременно ");
}

else 
{
    Console.WriteLine($"Результ: нет, некратно 7 и 23 одновременно");
}
}
Zadacha014();
