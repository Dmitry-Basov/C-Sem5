// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4

// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

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
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

void ElemEvenIndexesToSquare(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for(int j = 0; j < matrix.GetLength(1); j+=2)
        {
            // if(i % 2 == 0 && j % 2 == 0)
            // {
                matrix[i, j] *= matrix[i, j];
            // }
        }
    }
}

int[,] array2d = createMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();
ElemEvenIndexesToSquare(array2d);
PrintMatrix(array2d);

