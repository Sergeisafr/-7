// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте колличество строк двумерного массива");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колличество столбцов двумерного массива");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];

void FillArrayRandomNumbers(int[,] matrix)
{
    
    for (int m = 0; m < matrix.GetLength(0); m++) // Строка 
    {
        for (int n = 0; n < matrix.GetLength(1); n++) // Столбцы
        {
            matrix [m, n] = new Random().Next(10, 99);
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
void PrintElementMatrix()
{
Console.WriteLine("Введите двузначную позицию элемента массива для его вывода:");
int size = Convert.ToInt32(Console.ReadLine());

int line = size / 10;
int column = size % 10;
if (line < i && column < j )
{
    Console.Write("Значение указанного элемента: " + matrix[line, column]);
}
else
{
     Console.Write(size + "=> Элемента с такой позицией в массиве нет");
}
}
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
PrintElementMatrix();

