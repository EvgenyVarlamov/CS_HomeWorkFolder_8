/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза
*/

Console.WriteLine();
int m = Input("Введите m: ");
int n = Input("Введите n: ");
int[,] numbers = new int[m, n];

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
ArrayCreation(numbers);
PrintArray(numbers);
Console.WriteLine();
FrequencyCheck(numbers);
Console.WriteLine();

void ArrayCreation(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,]array)
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

void FrequencyCheck(int[,] arrayCheck)
{
    int checkValue = 10;
    int count = 0;
    for (int k = 0; k < checkValue; k++)
    {
        for (int i = 0; i < arrayCheck.GetLength(0); i++)
        {
            for (int j = 0; j < arrayCheck.GetLength(1); j++)
            {
                if (arrayCheck[i, j] == k)
                {
                    count++;                    
                }
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"{k} встречается {count} раз(а)"); 
            count = 0;
        }
    }
}