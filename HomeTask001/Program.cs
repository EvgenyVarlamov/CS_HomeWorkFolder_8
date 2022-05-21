/* Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

int length = Input("Введите количество столбцов и строк квдратного масива: ");

int[,] numbers = new int[length, length];
int[,] numbersReduced = new int[length - 1, length - 1];

FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Вывод массива:");
PrintArray(numbers);
Console.WriteLine();
numbersReduced = RemoveColumnAndRow(numbers);
Console.WriteLine();
Console.WriteLine("Вывод нового массива:");
PrintArray(numbersReduced);
Console.WriteLine();

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
            array[i,j] = new Random().Next(1, 10);
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

int[,] RemoveColumnAndRow(int[,] array)
{
    int column = 0;
    int row = 0;
    int min = array[0,0];
    int[,] arrayRedused = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;

    for (int i = 0; i < array.GetLength(0); i++) // Цикл нахождения строки и стобца с минимальным значением
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > (array[i, j]))
            {
                min = array[i, j];
                column = i;
                row = j;                
            }            
        }        
    }

    Console.WriteLine($"Наименьший элемент массива - {min}[{column},{row}]");

    for (int i = 0; i < array.GetLength(0); i++) // Цикл заполнения и переворачивания строк со столбцами нового массива
    {
        if (i == column)
        {
            continue;
        }    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(j == row)
                {
                    continue;  
                }
                arrayRedused[k, l] = array[i, j];  
                k++;     
            }
        l++;
        k = 0;
    }
    return arrayRedused;
}