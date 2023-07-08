// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//          1 4 7 2
//          5 9 2 3
//          8 4 2 4
//          1, 7 -> такого числа в массиве нет
//          0, 0 -> 1



// int rows = ReadInt("Enter the number of rows for the array: ");
// int columns = ReadInt("Enter the number of columns for the array: ");
//int[,] newArray = GenerateArray2D(rows, columns);
//PrintArray2D(newArray);




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(-10, 10);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int GetElement(int[,] array, int row, int column)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (row >= 0 && row < rows && column >= 0 && column < columns)
    {
        return array[row, column];
    }
    return -1; // Return -1 to indicate an invalid position
}



int[,] newArray = GenerateArray2D(5, 5);
PrintArray2D(newArray);
int rowPos = ReadInt("Enter the row position: ");
int colPos = ReadInt("Enter the column position: ");

int element = GetElement(newArray, rowPos, colPos);
if (element != -1)
{
    Console.WriteLine($"The value at position ({rowPos}, {colPos}) is: {element}");
}
else
{
    Console.WriteLine("Invalid position. The element is not present in the array.");
}
