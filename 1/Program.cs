// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать 
// ее относительно горизонтали.


int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0) / 2; i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
        matrix[matrix.GetLength(0) - i - 1, j] = temp;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
}