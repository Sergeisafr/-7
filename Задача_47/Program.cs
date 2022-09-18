// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m, n];

void FillArrayRandomNumbers(double[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++) // Строка 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбцы
        {
            matrix [i, j] = Convert.ToDouble(new Random().Next(0, 100)) / 10.0;
        }
    }    
}

void PrintArray(double[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++) // Строка 
    {
        Console.Write("[");

        for (int j = 0; j < matr.GetLength(1); j++) // Столбцы
        {
            Console.Write(matrix[i, j] + " ");
        }
    Console.WriteLine("]");

    }

}

FillArrayRandomNumbers(matrix);
PrintArray(matrix);
