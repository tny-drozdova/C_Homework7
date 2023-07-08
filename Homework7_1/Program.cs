// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами (double).
// Example: m = 3, n = 4.
//          0,5 7 -2 -0,2
//          1 -3,3 8 -9,9
//          8 7,8 -7,1 9


double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[,] GenerateArray2D(int rows, int columns, double min, double max)
{
    double[,] numbers = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return numbers;
}

void PrintArray2D(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]:f2}\t");  // :f2 to reduce amount of digits after the comma to two
        }
        Console.WriteLine();
    }
}

int rows = (int)ReadDouble("Enter the number of rows: ");
int columns = (int)ReadDouble("Enter the number of columns: ");
double[,] array = GenerateArray2D(rows, columns, -10.0, 10.0);
PrintArray2D(array);
