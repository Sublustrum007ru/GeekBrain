//Мое решение
using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n , m];
      int temp = 1;
      for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            if(i == 0 && j == 0){
                matrix[i, j] = 1;
            }
            else{
                matrix[i, j] = temp;
            }
            temp = temp + k;
        }
      }
      return matrix;
    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
        // Введите свое решение ниже
        int[] result = new int[2];
        if(rowPosition <= matrix.GetLength(0) && columnPosition <= matrix.GetLength(1)){
            result[0] = matrix[rowPosition, columnPosition];
            result[1] = 0;
            return result;
        }
        result[0] = 0;
        result[1] = 0;
        return result;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y){
      // Введите свое решение ниже
      if(results[0] != 0){
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
      }
      else{
        Console.WriteLine($"There is no such index");
      }
    }
    

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;  //Колличество трок в матрице
           m = 5;  //Колличесвто столбцов в матрице
           k = 3;  //Число на которе увеличивается каждый новый элемент
           x = 2;
           y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}


/*//Эталонное решение GeekBrain
using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                Console.Write($"{matrix[i,j]}"+"\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] newMatrix = new int[n,m];
        int currentValue = 1;
        for (int i=0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                newMatrix[i,j] = currentValue;
                currentValue += k;
            }
        }
        return newMatrix;
    }

      public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        int[] number = { 0, -1 };
        if (rowPosition >= 0 && rowPosition < matrix.GetLength(0) && columnPosition >= 0 && columnPosition < matrix.GetLength(1))
        {
            number[1] = 0;
            number[0] = matrix[rowPosition, columnPosition];
        }
        return number;
    }
  public static void PrintCheckIfError (int[] results, int X, int Y)
    {
        if (results[1]==-1){Console.WriteLine("There is no such index");}
        else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}

*/