Console.Clear();

string Promt(string str){
    Console.Write(str);
    string result = Console.ReadLine();
    return result;
}

int[] CreateArray(string arg1){
    int length = arg1.Length;
    int[] array = new int[length];
    for (int i = 0; i < length; i++){       
        array[i] = int.Parse(arg1[i] + "");
    }
    return array;
}
int SummArrayNumb(int[] arg1, string arg2){
    int length = arg2.Length;
    int summ = 0;
    for (int i = 0; i < length; i++){
        summ = summ + arg1[i];
    }
    return summ;

}

void PrintArray(int[] array){
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

string str1 = Promt("Введите первое число: ");

int[] arr = CreateArray(str1);
Console.WriteLine(SummArrayNumb(arr, str1));

