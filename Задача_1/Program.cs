// Показать двумерный массив размером m×n заполненный вещественными числами

void FiilArray(double[,] matrix, int m, int n)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * 100;            
        }        
    }
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix [i,j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m, n];

Console.Write("Ваш массив: ");
Console.WriteLine();
FiilArray(matrix, m, n);
PrintArray(matrix);