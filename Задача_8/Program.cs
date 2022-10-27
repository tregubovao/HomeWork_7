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

int SummaChiselStroki(int[,] matrix, int m, int n)
{
int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + matrix [m,j];       
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

int minsumma = SummaChiselStroki(matrix, 0, n);
for (m = 0; m < matrix.GetLength(0); m++) // цикл для поиска минимальной суммы во всех строках
    if(SummaChiselStroki(matrix, m, n) < minsumma)
            minsumma = SummaChiselStroki(matrix, m, n);
            
for (m = 0; m < matrix.GetLength(0); m++) // запускаю этот цикл для вывода ВСЕХ № строк с минимальной суммой (можно обойтись и вывести только № первой строки с мин значением)
    if (SummaChiselStroki(matrix, m, n) == minsumma)
        Console.WriteLine($"№ строки с наименьшей суммой элементов: {m + 1} ");
 
