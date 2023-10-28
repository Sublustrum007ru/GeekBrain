Console.Clear();
string Promt(string str){
    Console.Write(str);
    string result = Console.ReadLine();
    return result;
}

void PrintArray(int[] array){
    int length = array.Length;
    Console.WriteLine("Массив:");
    for (int i = 0; i < length - 1; i++){
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine(array[length - 1]);
}

int[] CreateArray(string str){
    int length = Convert.ToInt32(str);
    int[] result = new int[length];
    for (int i = 0; i < length; i++){
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

int SumOddElements(int[] array){
    int length = array.Length;
    int summ = 0;
    for (int i = 1; i < length; i++){
        if (i %2 != 0){
        summ = summ + array[i];
        }
    }
    return summ;

}

// string str = Promt("Введите количество элементов массива: ");
// int[] array = CreateArray(str);
int[] array = new int[] { 18, 76, 11};
PrintArray(array);
int sumOdd = SumOddElements(array);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");