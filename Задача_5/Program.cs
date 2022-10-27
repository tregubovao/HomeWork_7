// В матрице чисел найти сумму элементов главной диагонали

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

int SumElementMainDiagonal(int[,] matrix, int m, int n)
{
int sum = 0;
    if(m<=n)
        for (int i = 0; i < m; i++)
            {
                int j = i;
                sum = sum + matrix [i,j];        
            }
    else
        for (int i = 0; i < n; i++)
            {
                int j = i;
                sum = sum + matrix [i,j];        
            }               
return sum;    
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

Console.WriteLine($"Сумма элементов главной диагонали равна: {SumElementMainDiagonal(matrix, m, n)}");

