// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

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

double SredneeArifmStolbca(int[,] matrix,int j)
{
double sum = 0;
double SrArifm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix [i,j];        
        SrArifm = sum / matrix.GetLength(0);
    }
return SrArifm;    
}

void GenerateArrayElement(double[] array, int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    array[j] = SredneeArifmStolbca(matrix, j);
}

void PrintArr(double[] array)
{
    foreach(double element in array)
    Console.WriteLine($"{element} ");
Console.WriteLine();    
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

Console.Write("Ваш массив: ");
Console.WriteLine();
FiilArray(matrix);
PrintArray(matrix);
Console.WriteLine();

double[] array = new double[n];
GenerateArrayElement(array, n, m, matrix);

Console.WriteLine("Среднее арифметическое столбцов: ");    
PrintArr(array);
