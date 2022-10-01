// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Zadacha011()
{
    Random random = new Random(); 
                                   
    int number = random.Next(100, 1000); 
    Console.WriteLine(number);
    int number1 = number / 100; // первое число
    int number2 = number / 10 % 10; //искомое второе число
    int number3 = number % 10; // третье число

    Console.WriteLine(" " + number1 + number3);
    
   
}
Zadacha011();