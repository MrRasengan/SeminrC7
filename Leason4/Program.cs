// // Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
MainDiagNum(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
}

void MainDiagNum(int[,] userArray)
{
    int sumDiag = 0;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            if (i == j )
            {
               sumDiag += userArray[i,j];
            }
        }
    }
    Console.WriteLine($"Сумму элементов, находящихся на главной диагонали {sumDiag}");
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ") ;
        }
        Console.WriteLine();
    }
}

