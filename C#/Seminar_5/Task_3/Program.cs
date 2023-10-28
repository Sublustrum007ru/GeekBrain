Console.Clear();

void PrintArray(double[] array){
    int length = array.Length;
    for (int i = 0; i < length - 1; i++){
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine(array[length -1]);
}

double FindMax(double[] array){
    double max = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max){
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array){
    double min = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
        }
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array){
    double result = FindMax(array) - FindMin(array);
    return result;
}










double[] array = new double[] { 3, 7.4, 22.3, 2, 78 };
Console.WriteLine("Массив:");
PrintArray(array);
double diff = CalcDifferenceBetweenMaxMin(array);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");