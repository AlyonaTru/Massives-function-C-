// программа, кот принимает на вход число и возвращает сумму его цифр

int SumNum(int num, int sum = 0)
{
    if (num == 0)
    {
        return sum;
    }

    sum = sum + num%10;
    num = num/10;
    return SumNum(num, sum);

}

void Zadacha067()
{
  Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine(SumNum(num));
}
Zadacha067();