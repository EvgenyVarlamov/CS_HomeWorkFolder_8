/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

int columnsFirst = Input("Введите количество строк первой матрицы: ");
int rowsFirst = Input("Введите столбцов первой матрицы: ");
int columnsSecond = Input("Введите количество строк второй матрицы: ");
int rowsSecond = Input("Введите столбцов второй матрицы: ");

while (true) // Проверка
{
    if (rowsFirst != columnsSecond)
    {
        Console.WriteLine("Количество столбцов первой матрицы должно соответствовать количеству строк второй матрицы!!!");
        Console.WriteLine("Введите еще раз!!!");
        columnsFirst = Input("Введите количество строк первой матрицы: ");
        rowsFirst = Input("Введите столбцов первой матрицы: ");
        columnsSecond = Input("Введите количество строк второй матрицы: ");
        rowsSecond = Input("Введите столбцов второй матрицы: ");
    }
    else
    {
        break;
    }
}

int[, ] numbersFirst = new int[columnsFirst, rowsFirst];
int[, ] numbersSecond = new int[columnsSecond, rowsSecond];
int[, ] numbersMultiplication = new int[numbersFirst.GetLength(0), numbersSecond.GetLength(1)];

FillArray(numbersFirst);
Console.WriteLine("Первая матрица:");
PrintArray(numbersFirst);
Console.WriteLine();
FillArray(numbersSecond);
Console.WriteLine("Вторая матрица:");
PrintArray(numbersSecond);
Console.WriteLine();
MatrixMultiplication(numbersFirst, numbersSecond, numbersMultiplication);
Console.WriteLine("Произведение матриц:");
PrintArray(numbersMultiplication);


int Input(string size)
{
    Console.Write(size);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] arrayFirst, int[,] arraySecond, int[,] arrayMultiplication)
{
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arrayMultiplication[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
}