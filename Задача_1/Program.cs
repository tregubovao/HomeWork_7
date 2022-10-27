// Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble() * 100;
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

