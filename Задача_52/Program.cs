// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк двумерного массива:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int j = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[i, j];

void FillArrayRandomNumbers(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++) // Строка 
    {
        for (int n = 0; n < matrix.GetLength(1); n++) // Столбцы
        {
            matrix [m, n] = new Random().Next(0, 10);
        }
    }    
}
void PrintArray(int[,] matr)
{
    
    for (int m = 0; m < matr.GetLength(0); m++) // Строка 
    {
        Console.Write("[");

        for (int n = 0; n < matr.GetLength(1); n++) // Столбцы
        {
            Console.Write(matrix[m, n] + " ");
        }
    Console.WriteLine("]");
    }
}
void PrintSredneeArifmetichStolbca(int[,] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int o = 1;
    int z = 0;
    while (z < j)
    {
        int sum_1 = 0;
    for (int m = 0; m < i; m++) // Строка 
    {
        for (int n = 0 + z; n < (j+o) - j; n++) // Столбцы
        {
            sum_1 = sum_1 + matrix[m,n];
        }
    }
    double sredneeArifmetich = sum_1 / (float) i; // используем (float) чтобы деление производилось с остатком
    Console.Write(sredneeArifmetich + "; ");
    z++;
    o++;
    }  
}
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintSredneeArifmetichStolbca(matrix);

