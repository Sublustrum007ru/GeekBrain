using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}"+"\t");
        }
        Console.WriteLine();
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n, m];
      int currectValue = 1;
      for(int i = 0; i < n; i++)
      {
        for(int j = 0; j < m; j++)
        {
            matrix[i, j] = currectValue;
            currectValue = currectValue + k;
        }
      }
      return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine($"The averages in columns are:");
      for(int i = 0; i < list.Length; i++){
        Console.Write($"{list[i].ToString("0.00")}\t");
      }
      Console.WriteLine();


    }

    static double[] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] list = new double[matrix.GetLength(1)]; //Создали новый массив длинной в колличество колонок в матрице
      for(int column = 0; column < matrix.GetLength(1); column++){ 
        for(int row = 0; row < matrix.GetLength(0); row++){
            list[column] = list[column] + matrix[row, column];
        }
        list[column] = list[column] / matrix.GetLength(0);
       }
      return list;
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3; //Колличество строк в матрице
           m = 4; //Колличесвто столбцов в матрице
           k = 2; //Число на которое увеличивается каждый новый элемент матрицы
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
        // FindAverageInColumns(result);
    }
}