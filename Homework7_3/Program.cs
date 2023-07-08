// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//                          1 4 7 2
//                          5 9 2 3
//                          8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int ReadInt(string message)   // WE Initiave a user interface, that will prompt a user to enter thenumber of rows and columns
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
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

double[] FindAvg(int[,] numbers)
{
    double[] columnAvg = new double[numbers.GetLength(1)]; // creating a new array to store the AVG of each column, the length equals the number of columns
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }
        columnAvg[j] = sum / numbers.GetLength(0);
    }
    return columnAvg;
}

int rows = ReadInt("Enter a number of rows for an array: ");
int columns = ReadInt("Enter a number of columns for an array: ");
int[,] newArray = GenerateArray2D(rows, columns);
PrintArray2D(newArray);
double [] columnAvg = FindAvg(newArray);
for (int j = 0; j < columns; j++)
{
    Console.WriteLine($"Average of column {j + 1}: {columnAvg[j]}");
}