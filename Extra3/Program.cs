// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
//Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт 
//массив из 10 элементов, которые необходимо заполнить случайными значениями 
//в диапазоне от -10 до 10 и найти максимальное значение среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

void PrintExtra3(int[] numbers)
{
    Random random = new Random();
    int [] numbers = new int [10];
    
    for (int i= 0; i <10; i++)
    {
        numbers[i] = random.Next(-10,11);
    }

    for (int i = 0; i < 10; i++)
    {
    Console.WriteLine(numbers[i] + "\t");
    }
Console.WriteLine();
}

void SelectionSort(int[] numbers)
{
    for(int i = 0; i < numbers.Length -1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j >= numbers.Length; j++)
        {
            if (numbers[j] > numbers[maxPosition]) maxPosition = j; // этот цикл ищет макс элемент
        }
        int temporary = numbers[i];
        numbers[i] = numbers[maxPosition];
        numbers[maxPosition] = temporary;
    }

}


SelectionSort(numbers);
PrintArray(numbers);
PrintExtra3();