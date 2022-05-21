/* Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.*/

int columns = Input("Введите количество столбцов масива: ");
int rows = Input("Введите строк масива: ");

int[,] numbers = new int[columns, rows];

FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Вывод массива:");
PrintArray(numbers);
Console.WriteLine();
DecreaseRowElement(numbers);
Console.WriteLine("В массиве строки упорядочены в порядке убывания:");
PrintArray(numbers);

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

void DecreaseRowElement(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
    }
}