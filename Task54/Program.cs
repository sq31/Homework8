/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

int[,] getRandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 20);
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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = getRandomArray(m, n);
printArray(randomArray);

Console.WriteLine();
Console.WriteLine("Упорядочим элементы массива по убыванию:");

for (var i = 0; i < randomArray.GetLength(0); i++)
{
    for (var j = 0; j < randomArray.GetLength(1); j++)
    {
        int min = randomArray[i, j];
        for (var k = j + 1; k < randomArray.GetLength(1); k++)
        {
            if (randomArray[i, k] < min)
            {
                min = randomArray[i, k];
                int temp = randomArray[i, j];
                randomArray[i, j] = min;
                randomArray[i, k] = temp;
            }
        }
    }
}

printArray(randomArray);