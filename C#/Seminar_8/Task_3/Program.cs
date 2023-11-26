using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if(matrixA.GetLength(1) != matrixB.GetLength(0)){
            Console.Write($"It is impossible to multiply.");
        }
        else{
            PrintMatrix(MatrixMultiplication(matrixA, matrixB));
        }

       }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
        int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        //matixA  matrixB      (0,0 * 0,0 + 0,1 * 1,0) , (0,0 * 0,1 + 0,1 * 1,1) 
        //[1, 2]  [5, 6]      [( 1  *  5  +  2  *  7 ) , ( 1  *  6  +  2  *  8 )]
        //                 =
        //                     (1,0 * 0,0 + 1,1 * 1,0) , (1,0 * 0,1 + 1,1 * 1,1)
        //[3, 4]  [7, 8]      [( 3  *  5  +  4  *  7 ) , ( 3  *  6  +  4  *  8 )]
        for(int row = 0; row < matrixA.GetLength(0); row++){
            for(int column = 0; column < matrixA.GetLength(1); column++){
                for(int x = 0; x < matrixA.GetLength(1); x++){
                    result[row, column] = result[row, column] + matrixA[row, x] * matrixB[x, column];
                }
            }
        }
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
       for(int row = 0; row < matrix.GetLength(0); row++){//Создаем цикл для перебора строк
           for(int column = 0; column < matrix.GetLength(1); column++){//Создаем ццикл для перебора столбцов
               Console.Write($"{matrix[row, column]}\t");//Выводим в строку числа из матрицы
       }//Не забываем про пустую строку, для переключения вывода новой строки матрици
       Console.WriteLine();
       }
    }
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
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

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}