
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void Zadacha013() 
{
    Console.WriteLine("Введите число : ");
    string number = Console.ReadLine();
    char[] ch = number.ToCharArray();
    int length = number.Length;
    
    if (ch[0] == '-') 
    {
            Console.WriteLine(ch[3]);
    }
    
    else if (length < 3)
        {
           Console.WriteLine("Третьей цифры нет");
        }
    
    
    else 
        {
           Console.WriteLine( ch[2]);
                  }
}
Zadacha013();