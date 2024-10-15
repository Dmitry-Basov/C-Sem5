// : Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6




int[,] createMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums]; //3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void TransponseMatrix(int[,] matrix)
{
    int[,] transposed = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            transposed[j, i] = matrix[i, j];
        }
    }

    Console.WriteLine($"Транспонированный массив: ");

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{transposed[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = createMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

TransponseMatrix(array2d);
Console.WriteLine();


