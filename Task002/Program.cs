/*Задача 55: Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
*/

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

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

if ( m != n)
{
    Console.WriteLine("Заменить строки на столбцы невозможно!");
}
else
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0 ; j < m; j++)
        {            
            Console.Write(array[j,i] + " ");
        }
        Console.WriteLine();
    }
}