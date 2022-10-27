// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

Console.Write("Базовый массив: ");
Console.WriteLine();
FiilArray(matrix, m, n);
PrintArray(matrix);

Console.Write("Введите искомый элемент: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] == x)
        {
            Console.Write($" Индексы позиции элемента {matrix[i, j]}: ({i}, {j})");
            count++;
            Console.WriteLine();
        }
    }
}
if (count == 0)
    Console.Write("Данного элемента в матрице НЕТ");
