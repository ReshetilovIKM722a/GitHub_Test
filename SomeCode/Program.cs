using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть розмiрнiсть матрицi (рядки та стовпцi):");
        Console.Write("Рядки: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Стовпцi: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = GenerateRandomMatrix(rows, cols);
        PrintMatrix(matrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(100);
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        Console.WriteLine("Результат:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
