/*
//Вид 1 - Метод(функция) которая не принимает и не возвращает данные.
void Method1(){
    Console.WriteLine("Автор: Sublustrum007");
}

// Method1();

//Вид 2 - Метод)функция) которая принимает, но ничего не возвращает
void Method2(string msg){
    Console.WriteLine(msg);
}

// Method2(msg: "Текст сообщения"); //Используется именованный аргумент "msg"

void Method21(string msg, int count){
    int i = 0;
    while(i < count){
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст сообщения", 4);
// Method21(count: 4, msg: "Новый текст"); //именнованные аргументы не обязательно писать по порядку

//Вид 3 - Что то возвращает, но ни чего не принимает на вход

int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);
*/

// int Method4(int count, string text){
//     int i = 0;
//     string result = String.Empty;
//     while(i < count){
//         result = result + text;
//         i++;
//     }
//     return result;

// }

// string Method4(int count, string text){
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;

// }

// string res = Method4(count: 10, text: "qwerty");
// Console.WriteLine(res);

//====== Работа с текстом =======//
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue){
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++){
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '/');
//новая переменная = Вызов метода(аргумент с тексом, второй аргумент, третий аргумент)
//в данном случае первый аргумент это сам текс, второй аргумент, какой символ мы будем искать, третий аргумент на что менять
// Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/
/*
int[] arr = {8, 5, 6, 4, 2, 1, 7, 3, 1, 1, 9};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPosition]){
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
int[] arr = {8, 5, 6, 4, 2, 1, 7, 3, 1, 1, 9};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++){
        Console.WriteLine("[{0}]", string.Join(", ", array));
    }
    Console.WriteLine();
}
void SelectionSort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] > array[maxPosition]){
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);