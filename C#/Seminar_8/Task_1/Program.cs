using System;

public class Answer{
/// <summary>
/// Вывод матрицы в консоль
/// </summary>
/// <param name="matrix">На вход получаем матрицу целочисленных чисел</param>
    public static void PrintMatrix(int[,] matrix)
    {
    // Введите свое решение ниже
        for(int row = 0; row < matrix.GetLength(0); row++){
            for(int column = 0; column < matrix.GetLength(1); column++){
                Console.Write($"{matrix[row, column]}\t");
            }
            Console.WriteLine();
        }
    }

/// <summary>
/// Сортировка чисел в строке от максимального к наименьшему
/// </summary>
/// <param name="matrix">На вход получаем матрицу целочисленных чисе</param>
    public static void SortRowsDescending(int[,] matrix)
    {
        for(int row = 0; row < matrix.GetLength(0); row++){
            for(int column = 0; column < matrix.GetLength(1); column++){
                int max = matrix[row, column];
                int x = column;
                for(int y = column; y < matrix.GetLength(1); y++){
                    if(matrix[row, y] > max){
                        max = matrix[row, y];
                        x = y;
                    }
                }
                int temp = matrix[row, column];
                matrix[row, column] = max;
                matrix[row, x] = temp;
                }
            }
        }
    //     public static void SortRowsDescending(int[,] matrix)
    // {
    //     int j = 0;
    //     int k = 0;
    //     for (int i = 0; i < matrix.GetLength(0); i++)               //checking all rows
    //     {
    //         for (j = 0; j < matrix.GetLength(1); j++)                //Starting from each element in column
    //         {
    //             int max = j;
    //             for (k = j; k < matrix.GetLength(1); k++)            // checking if any number is greater than in j-position
    //             {
    //                 if (matrix[i, max] < matrix[i, k])                         // if new max if found remeber its position                                          
    //                 {
    //                     max = k;
    //                 }
    //             }
    //             var temp = matrix[i, max];                      // Swap max and current j-position
    //             matrix[i, max] = matrix[i, j];
    //             matrix[i, j] = temp;
    //         }
    //     }
    // }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {1, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}