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