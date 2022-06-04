/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
 будет находить строку с наименьшей суммой элементов.
*/

int[,] getRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    {
        for (var i = 0; i < rowNumber; i++)
        {
            for (var j = 0; j < colNumber - 1; j++)
            {
                result[i, j] = new Random().Next(1, 20);
            }
        }

        for (var k = 0; k < rowNumber; k++) //Заполнение последней колонки, расчет суммы.
        {
            for (var n = 0; n < colNumber - 1; n++)
            {
                result[k, colNumber - 1] = result[k, colNumber - 1] + result[k, n];
            }
        }

        int minSum = result[0, colNumber - 1];

        {
            for (var i = 0; i < result.GetLength(0) - 1; i++)
            {
                if (result[i, colNumber - 1] < minSum)
                {
                    minSum = result[i, colNumber - 1];
                }
            }
        }

        Console.WriteLine("Суммы по строкам выведены в последней колонке.");
        Console.WriteLine($"Минимальная сумма по строкам = {minSum}.");
    }
    return result;
}

void result(int[,] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (j == arrayToPrint.GetLength(1) - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ResetColor();
            }
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()) + 1;

int[,] randomArray = getRandomArray(raws, columns);
result(randomArray);

