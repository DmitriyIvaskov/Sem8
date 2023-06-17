// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен ПЕРВЫЙ наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int rowsCount = 3;
int columnsCount = 3;

int[,] matrix = new int[rowsCount, columnsCount];

int min = int.MaxValue;
int rowIndexOfMinValue = 0;
int columnIndexOfMinValue = 0;

for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        matrix[i, j] = new Random().Next(1, 11); // Числа от 1 вкл-то до 10 вкл-но
        Console.Write(matrix[i, j] + "\t");
        if (min > matrix[i, j])
        {
            min = matrix[i, j]; // 2147483647 > 10? min = 10
            rowIndexOfMinValue = i;
            columnIndexOfMinValue = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"min: {min}, координаты: ( {rowIndexOfMinValue},{columnIndexOfMinValue} )");


for (int i = 0; i < rowsCount; i++)
{
    if (rowIndexOfMinValue != i) // исключил строчку с мин. элементом
    {
        for (int j = 0; j < columnsCount; j++)
        {
            if (columnIndexOfMinValue != j) // исключил столбец с мин. элементом
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}