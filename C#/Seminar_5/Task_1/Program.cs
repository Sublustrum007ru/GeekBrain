Console.Clear();

string Promt(string str){
    Console.Write(str);
    string result = Console.ReadLine();
    return result;
}

int[] CreateArray(string str){
    int length = Convert.ToInt32(str);
    int[] result = new int[length];
    for (int i = 0; i < length; i++){
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int CountEvenElements(int[] array, string str){
    int count = 0;
    int length = Convert.ToInt32(str);
    for (int i = 0; i < length; i++ ){
        if (array[i] % 2 == 0){
            count = count + 1;
        }
    }
    return count;
}

void PrintArray(int[] array){
    int length = array.Length;
    Console.WriteLine("Массив:");
    for (int i = 0; i < length - 1; i++){
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine(array[length - 1]);
}

string str = Promt("Введите количество элементов массива: ");
int[] array = CreateArray(str);
PrintArray(array);
// Console.WriteLine(EvenNumb(array, str));
switch (CountEvenElements(array, str)){
    case int i when ((CountEvenElements(array, str)) == 1):
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} чётное число");
        break;
    case < 5:
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} чётных числа");
        break;
    case int i when (((CountEvenElements(array, str)))%10== 0):
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} чётных чисел");
        break;
    default:
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} чётных числа");
        break;
}
