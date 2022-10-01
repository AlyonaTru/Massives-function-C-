Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("понедельник");
}

else if (a == 2)
{
    Console.WriteLine("вторник");
}

else if (a == 3)
{
    Console.WriteLine("среда");
}

else if (a == 4)
{
    Console.WriteLine("четверг");
}

else if (a == 5)
{
    Console.WriteLine("пятница");
}

else if (a == 6)
{
    Console.WriteLine("суббота");
}

else if (a == 7)
{
    Console.WriteLine("воскресенье");
}

else 
{
    Console.WriteLine("ошибка ввода");
}
