/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.*/

int length = Input("Введите длину масива: ");
int width = Input("Введите ширину масива: ");
int height = Input("Введите высоту масива: ");

int[,,] numbers = new int[height, width, length];

FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Вывод массива:");
PrintArray(numbers);

int Input(string size)
{
    Console.Write(size);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            } 
        }
    }
}

void PrintArray(int[,,] array)
{
      for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}