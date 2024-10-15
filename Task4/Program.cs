// Задайте двумерный массив целых чисел. Напишите программу, которая
// находит максимальный элемент в каждой строке массива и выводит его.
// Пример входных данных:
// 1 3 5 7
// 2 4 6 8
// 9 10 11 12



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

void MaxSumMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[1, 0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }

        }
        Console.WriteLine($"Максимальный элемент в строке {i}: {max} ");
    }
}


int[,] array = createMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array);

MaxSumMatrix(array);
Console.WriteLine();
