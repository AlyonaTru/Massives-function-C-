// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if(b == a * a)
{
    Console.WriteLine("Результат: да ");
}

else 
{
    Console.WriteLine("Результ: нет ");
}
