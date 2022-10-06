// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void Zadacha041()
{
    Console.WriteLine("Введите несколько полжительных и отрицательных чисел через пробел:");
    int[]numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    PrintArray(numbers); 
    Console.WriteLine(GetPositiveNumbers(numbers));
}
Zadacha041();

void PrintArray(int[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

int GetPositiveNumbers(int[]numbers)
{
    int count =0;
    for (int i =0; i<numbers.Length; i++)
    {
        if (numbers[i] >0)
        count = count+ 1;
    }    
    return count; 
}