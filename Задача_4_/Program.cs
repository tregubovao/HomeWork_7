// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

int ProverkaNaNalichie(int[,] matrix, int value)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)            
                count++;                        
        }
    }
    return count;
}

void GenerateArrayElement(int[] array, int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)
            {
                array[0] = i;
                array[1] = j;
            }
        }
    }            
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

Console.Write("Введите искомый элемент: ");
int value = int.Parse(Console.ReadLine() ?? "0");

int [] array = new int[2];
if (ProverkaNaNalichie(matrix, value) == 0)
    Console.Write("Данного элемента в матрице НЕТ");
else
{
    GenerateArrayElement(array, matrix, value);
    Console.Write($"Индексы позиции элемента : ({array[0]}, {array[1]}) ");    
}     
      