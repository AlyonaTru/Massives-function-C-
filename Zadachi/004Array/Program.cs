
void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int [] col)
{
     int count = col.Length;
     int position = 0;
     while (position < count)
     {
        Console.WriteLine(col[position]);
        position++;
     }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искомого элемента нет, то будет -1 в результате

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // определили массив из 10 элементов

FillArray(array); //метод заполнил массив
PrintArray(array); // метод распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

// int n = array.Length;
// int find = 8;
// int index = 0;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     //index = index +1;
//        index++;

// }