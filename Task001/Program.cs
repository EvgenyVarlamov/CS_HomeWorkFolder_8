/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
 */

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        array[i,j] = new Random().Next(0, 10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[] tempArray = new int[n];

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        if ( i == 0)
        {
            tempArray[j] = array[0, j];
            array[0, j] = array[m - 1 , j];
            array[m - 1, j] = tempArray[j];
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();