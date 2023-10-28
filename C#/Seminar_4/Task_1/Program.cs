Console.Clear();
string Promt(string str){
    Console.Write($"Введите число {str}: ");
    string result = Console.ReadLine();
    return result;
}

int Degree(int arg1, int arg2){
    int result = arg1; 
    for (int i = 0; i < arg2 - 1; i++){   
        result = result * arg1;
    }
    return result;
    
}

int a = Convert.ToInt32(Promt("A"));
int b = Convert.ToInt32(Promt("B"));
Console.WriteLine(Degree(a, b));