// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет  12821 -> да  23432 -> да

void Zadacha019()
{ 
    Console.WriteLine("Введите пятизначное число: ");
    string number = Console.ReadLine();
    char[] ch = number.ToCharArray();
    int length = number.Length;

if ((length < 5)|| (length > 5))
    {
        Console.WriteLine("Ошибка ввода.");
    }

    if ((number[4] == number[0]) && (number[3] == number[1]))
    {
        Console.WriteLine("Это число - палиндром.");
    }
    else
    {
    Console.WriteLine("Это число - не палиндром.");
    }

}
Zadacha019();
