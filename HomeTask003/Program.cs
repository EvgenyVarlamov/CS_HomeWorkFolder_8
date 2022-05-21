/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

int columns = Input("Введите количество столбцов масива: ");
int rows = Input("Введите строк масива: ");

int[,] numbers = new int[columns, rows];

FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Вывод массива:");
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine(StringWithMinimalSum(numbers));


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

string StringWithMinimalSum(int[,] array)
{
    int sum = 0;
    int stringNumber = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(1); i++)    // Вычисление суммы элементов первой строки
    {
        minSum += array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)    // Вычисление суммы элементов следующих строк и сравнение с первой
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];  
        }
        if (minSum > sum)
        {
            minSum = sum;
            stringNumber = i;
        }
        sum = 0;
    }
    return $"{stringNumber}-я строка с минимальной суммой {minSum}";
}