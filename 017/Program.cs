//17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Zadacha017()
{
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);

Console.WriteLine($"A({x}, {y})");

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в 1 четверти");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит в 2 четверти");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в 3 четверти");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в 4 четверти");
}

 else
 {
    Console.WriteLine("Точка лежит на одной из осей");
 } 

}
Zadacha017();