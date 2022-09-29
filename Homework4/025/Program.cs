//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B.
// 3, 5 -> 243 (3⁵)       2, 4 -> 16
void Zadacha025()
{
     
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(a, b));
  
Console.WriteLine(result);  

}
Zadacha025();

// или другое решение если не брать класс Math
// Console.Write("Введите число A: ");
// double a = Double.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите число B: ");
// int b = Int32.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(Power(a, b));

// double Power(double x, int y)
// {
//     double pow = x;
//     for(int i = 1; i < y; i++)
//     {
//         pow *= x;
//     }
//     return pow;
// }