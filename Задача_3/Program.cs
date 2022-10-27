// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

Console.Write("Базовый массив: ");
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Измененный массив: ");
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
