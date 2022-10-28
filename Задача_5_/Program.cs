// В матрице чисел найти сумму элементов главной диагонали

void FiilArray(int[,] matrix)
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

int SumElementMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)            
        sum = sum + matrix[i, i];        
    return sum;
}

Console.WriteLine("Введите количество строк (столбцов) квадратной матрицы: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, m];
Console.Write("Базовый массив: ");
Console.WriteLine();
FiilArray(matrix);
PrintArray(matrix);
Console.WriteLine($"Сумма элементов главной диагонали равна: {SumElementMainDiagonal(matrix)}");
