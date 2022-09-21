// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Zadacha010()
{
   Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int number1 = number / 100; // первое число
    int number2 = number / 10 % 10; //искомое второе число
    int number3 = number % 10; // третье число

    Console.WriteLine(" " + number2);
    
   
}
Zadacha010();