// Сравнение столбцов с угловыми элементами

void Extra1()                               
{
    double column_sum = 0;
    int corner_flag = 0;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nСравнение столбцов с угловыми элементами\n");
    Console.ForegroundColor = ConsoleColor.White;

    double corner_sum = matrix[0, 0] + matrix[0, columns - 1] + matrix[rows - 1, 0] + matrix[rows - 1, columns - 1];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            column_sum += matrix[j, i];
            if (corner_sum > column_sum) { corner_flag++; }
        }
    }
    Console.Write(corner_flag != 0 ? "  Сумма угловых элементов превышает сумму элементов одного из столбцов\n\n"
        : "  Сумма угловых элементов не превышает сумму элементов любого столбца\n\n");
}
void Extra1();