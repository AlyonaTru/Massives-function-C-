// программа, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101 3->11 2->10

void Zadacha042()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    double numAs2 = 0;
    double i = 0;
    while(number > 0)
    {
        numAs2 = (number%2) * Math.Pow(10, i) + numAs2;
        number = number/2;
        i++;
    }
    Console.WriteLine($"В двоичном коде это {numAs2} ");
}
Zadacha042();