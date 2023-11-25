using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
    // Введите свое решение ниже
        int summofrow = 0;
        for(int i = 0; i < matrix.GetLength(1); i++){
            summofrow = summofrow + matrix[row, i];
        }
        return summofrow;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
    // Введите свое решение ниже
        int[] min = new int[2];
        for(int x = 0; x < matrix.GetLength(1); x++){
            min[1] = min[1] + matrix[0, x];  // Примим сумму чисел первой строки как самое минимальное
        }
        //Создадим цикл для перебора строк
        //создадим цикл для перебора колонок
        //Подщитаем в каждой строке сумму
        // Сравним с минимальным каждую строку, и если она будет меньше запишем ее в минимальную
        for(int row = 0; row < matrix.GetLength(0); row++){
            int summofrow = 0; // Создажим сбрасываемое при каждой новой строчке, переменное 
            for(int column = 0; column < matrix.GetLength(1); column++){
                summofrow = summofrow + matrix[row, column];
            }
            if(summofrow < min[1]){ // Прозводим сравнение
                min[1] = summofrow; // Если "summofrow" меньше чем "min[1]", то присвоим "min[1]" "summofrow"
                min[0] = row;       // Так же "min[0]" присвоим номер строки "row"
             }
        }
        return min;
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {5, 2, 9},  // 16
                {8, 1, 4},  // 13
                {6, 7, 3}   // 16
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

        int rowToSum = 1; 
        int sum = SumOfRow(matrix, rowToSum);
        Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
    }
}