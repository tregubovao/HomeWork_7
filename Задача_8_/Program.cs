// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int SummaChiselStroki(int[,] matrix, int i, int n)
{
int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + matrix [i,j];       
    }
return sum;    
}

void GenerateArrayElement(int[] array, int n, int m, int[,] matrix)
{
    for (int i = 0; i < m; i++)
    array[i] = SummaChiselStroki(matrix, i, n);
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

Console.Write("Ваш массив: ");
Console.WriteLine();
FiilArray(matrix, m, n);
PrintArray(matrix);

int[] array = new int[m];
GenerateArrayElement(array, n, m, matrix);
int min = array[0];
int index = 0;
for(int i = 1; i < m; i++)
    if(array[i] < min)
    {
        min = array[i];
        index = i;
    }  
Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1}");  
