
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


int[] array = new int [10]; // определили массив из 10 элементов

FillArray(array); //метод заполнил массив
PrintArray(array); // метод распечатал массив

int n = array.Length;
int find = 8;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
       index++;

}