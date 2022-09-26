// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

void Zadacha021b()
{
    Console.WriteLine("Введите координаты точки А:  ");
    Console.WriteLine("x = :  ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y = :  ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z = :  ");
    int az = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B:  ");
    Console.WriteLine("x = :  ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y = :  ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z = :  ");
    int bz = Convert.ToInt32(Console.ReadLine());

    int k = bx - ax;
    int m = by - ay;
    int n = bz - az;

    double length = Math.Sqrt(k * k + m * m + n * n);
    length = Math.Round(length, 2);
    Console.WriteLine($"Длина {length}");

}
Zadacha021b();