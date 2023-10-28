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
        result[i] = new Random().Next(0, length);
    }
    return result;
}

void PrintArray(int[] arg1){
    Console.WriteLine("[{0}]", string.Join(",", arg1));
}

string str_1 = Promt("Введите желаемую длинну массива: ");
int[] arr = CreateArray(str_1);

PrintArray(arr);