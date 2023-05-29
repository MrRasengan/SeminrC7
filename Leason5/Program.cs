// Задать два массива, перемножить их между собой 
//и вывести в новый массив

Console.Write("Введите количество строк массивов: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массивов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Массив №1: ");
int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);
MainDiagPosSum(array1);
Console.WriteLine("Массив №2: ");
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);
MainDiagPosSum(array2);
Console.WriteLine("Произведение массивов: ");
int[,] arrayProd = ProductBothArrays(array1, array2);
PrintArray(arrayProd);
MainDiagPosSum(arrayProd);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void MainDiagPosSum(int[,] userArray)
{
    int sumMainDiag = 0;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            if (i == j)
            {
                sumMainDiag += userArray[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов на главной диагонали: {sumMainDiag}");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductBothArrays(int[,] arr1, int[,] arr2)
{
    int[,] productArr = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            productArr[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return productArr;
}