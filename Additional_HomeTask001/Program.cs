/* Дополнительная задача 61: Вывести первые N строк 
треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

int size = Input("Введите размер треугольника Паскаля: ");

int[,] numbers = new int[size, size];

FillPascalTriangle(numbers);
Console.WriteLine();
Console.WriteLine("Вывод треугольника Паскаля:");
PrintPascalTriangle(numbers);
Console.WriteLine();

int Input(string data)
{
    Console.Write(data);
    return Convert.ToInt32(Console.ReadLine());
}

void FillPascalTriangle(int[,] array)
{
    array[0, 0] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        for (int j = 1 ; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
        }
    }
}

void PrintPascalTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - i; k++)
            {
                Console.Write(" "); 
            }
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}