/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/


int[,] getRandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 5);
        }
    }
    return result;
}

void printArray(int[,] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write((arrayToPrint[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы А: ");
int aRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int aCol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы В: ");
int bRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int bCol = Convert.ToInt32(Console.ReadLine());

int[,] randomArrayA = getRandomArray(aRow, aCol);
Console.WriteLine("Матрица А");
printArray(randomArrayA);
int[,] randomArrayB = getRandomArray(bRow, bCol);
Console.WriteLine();
Console.WriteLine("Матрица В");
printArray(randomArrayB);

Console.WriteLine();
if (aCol != bRow)
{
    Console.WriteLine($"Количество столбцов Матрицы А ({aCol}) не равно количеству строк Матрицы В ({bRow})!");
    Console.WriteLine($"Нахождение произведения данных матриц невозможно!");
}
else
{
    Console.WriteLine($"Произведение матриц возможно. Получим Матрицу С [{aRow},{bCol}].");
    int cRow = aRow;
    int cCol = bCol;
    int[,] arrayC = new int[cRow, cCol];
    //    printArray(arrayC);
    {
        for (int i = 0; i < arrayC.GetLength(0); i++)
        {
            for (int j = 0; j < arrayC.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < randomArrayA.GetLength(1); k++)
                {
                    sum = randomArrayA[i, k] * randomArrayB[k, j];
                    arrayC[i, j] = arrayC[i, j] + sum;
                }
            }
        }
    }
    printArray(arrayC);
}



//printArray(randomArray);