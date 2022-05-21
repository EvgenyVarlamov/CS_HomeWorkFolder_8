/* Задача 62: Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

string spira = "1,2,3,4,12,13,14,5,11,16,15,6,10,9,8,7";
int columns = 4;
int rows = 4;
int[,] numbers = new int[columns, rows];
int[] temporary = new int[columns*rows];

temporary = SetNumbers(spira,',');
FillArray(temporary, numbers);
Console.WriteLine();
Console.WriteLine("Способ 1");
Console.WriteLine("Вывод массива:");
PrintArray(numbers);
FillArrayBySnake(numbers, columns, rows);
Console.WriteLine();
Console.WriteLine("Способ 2");
Console.WriteLine("Вывод массива:");
PrintArray(numbers);
Console.WriteLine();

int[] SetNumbers(string text, char symbol)
{
    int count = 0;

    if(text[text.Length - 1] != symbol)
    {
        text = text + $"{symbol}";
    }

    for(int i = 0; i < text.Length; i++) 
    {
        if(text[i] == symbol)
        {
            count++;
        }
    }

    string updateText = String.Empty;
    int[] array = new int[count];
    count = 0;

    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] != symbol)
        {
            updateText = updateText + text[i];
        }
        else
        {
            array[count] = Convert.ToInt32(updateText);
            updateText = String.Empty;            
            count++;
        } 
    }
    return array;
}

void FillArray(int[] arrayInput, int[,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++)
    {
        for (int j = 0 ; j < arrayOutput.GetLength(1); j++)
        {
            arrayOutput[i,j] = arrayInput[4*i+j];
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

void FillArrayBySnake(int[,] arrayInput, int col, int row)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= col*row)
    {
        arrayInput[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < row - 1)
        {
            j++;
        }
        else if (i < j && i + j >= row - 1)
        {
            i++;
        }
        else if (i >= j && i + j > col - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}