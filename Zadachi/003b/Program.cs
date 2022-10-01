// задачка, где на входе принимается число,а  на выходе даются все целые числа от -n до n
Console.Write("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2 = num * -1;

while (num2 <= num)
{
Console.Write(num2 + ", ");
num2 = num2 + 1;

}
// Console.Write("\b");
Console.WriteLine();
