// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

void FiilArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);            
        }        
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix [i,j]} ");
        Console.WriteLine();
    }
}

double SredneeArifmStolbca(int[,] matrix, int m, int n)
{
double sum = 0;
double SrArifm = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + matrix [i,n];        
        SrArifm = sum / m;
    }
return SrArifm;    
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

Console.Write("Базовый массив: ");
Console.WriteLine();
FiilArray(matrix, m, n);
PrintArray(matrix);

for (n = 0; n < matrix.GetLength(1); n++)
{
    Console.WriteLine($"Среднее арифметическое столбца № {n+1} равно: {SredneeArifmStolbca(matrix, m, n)} ");
}

