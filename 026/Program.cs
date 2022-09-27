// программа, которая принимает число и выдает количество цифр в числе

void Zadacha026()
{
    // 1 решение через строку

Console.WriteLine("Введите число: "); 
// string number = Console.ReadLine();
// Console.WriteLine(number.Length);
int number = Convert.ToInt32(Console.ReadLine());
int current = number;
int count = 0;
while (current > 0)
{
current = current/10;
count = count + 1;

}
Console.WriteLine($"Количество цифр в числе {number} = {count}");

}
Zadacha026();