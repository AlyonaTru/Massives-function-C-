//программа, кот на вход принимает 2 числа А и В и возводит А в степень В с помощью рекурсии
// а = 3 в = 5 = 243

int a = 5;
int b = 4;

Pow(a,b);

void Pow(int a, int b, int result = 1)
{
    if (b == 0)
    {
        Console.WriteLine($"{result}");
        return;
    }
    result = result*a;
    b--;
    Pow(a,b,result);
}