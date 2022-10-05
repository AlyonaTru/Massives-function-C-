// программа, которая принимает на вход 3 числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины

void Zadacha040()
{
    Console.WriteLine("Введите число А");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число В");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число C");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a<=0 || b<=0 ||c<=0)
    {
        Console.WriteLine("такого треугольника нет");
    }
    
    else if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("такой треугольник существует");
    }
 
    }

Zadacha040();



