// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void Zadacha021()
{
    Console.WriteLine("Введите координаты точки А:  ");
    Console.WriteLine("x = :  ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y = :  ");
    int ay = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B:  ");
    Console.WriteLine("x = :  ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y = :  ");
    int by = Convert.ToInt32(Console.ReadLine());

    int k = bx - ax;
    int m = by - ay;

    double length = Math.Sqrt(k * k + m * m);
    length = Math.Round(length, 2);
    Console.WriteLine($"Длина {length}");

}
Zadacha021();