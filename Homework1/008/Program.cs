// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
number2 = Math.Abs(number2);
int number = 1;
if (number2 == 1) 
{
    Console.WriteLine("ошибка ввода");
}


while (number <= number2)
{
 
 if(number2 % 2 == 0)
 {
    Console.Write(number2 + " " );
    }
    number2 = number2 - 1;

}
Console.WriteLine();

