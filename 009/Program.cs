// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

void Zadacha009()
{
    Random random = new Random(); // создание объекта типа рандом ключевое слово new
                                   // переменная Random rando нужна, чтобы к нему обращаться
    int number = random.Next(10, 100); //100 не входит, мето некст выдает [ )
    Console.WriteLine(number);
    int tens = number / 10; 
    int ones = number % 10;  //остаток от деления
    Console.WriteLine(tens);
    Console.WriteLine(ones);
   

if(tens > ones)
{
    Console.WriteLine("наибольшее число = " + tens);
    Console.WriteLine("наименьшее число = " + ones);
}

else 
{
    Console.WriteLine("наибольшее число = " + ones);
    Console.WriteLine("наименьшее число = " + tens);
}

}
Zadacha009();