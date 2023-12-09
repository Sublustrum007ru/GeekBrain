using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using Microsoft.Win32.SafeHandles;

Console.Clear();

// Random generateNumber = new Random();
// int number = generateNumber.Next(10,1000);
// Console.WriteLine(number);
// int a = number / 100; // Находим первую цифру трёхзначного рандомного числа
// int b = number % 10;  // Деление с остатком //Находим последнюю цифру трёхзначного рандомного числа

// Console.WriteLine(a);
// Console.WriteLine(b);

// Console.Write("Введите первое число: ");
// string inputA = Console.ReadLine();
// int a = Convert.ToInt32(inputA);

// Console.Write("Введите второе число: ");
// string inputB = Console.ReadLine();
// int b = Convert.ToInt32(inputB);

// if (a % b == 0){
//     Console.WriteLine("Кратно");
// }
// else{
//     Console.WriteLine("Не кратно, остаток " + (a % b));
// }

// Console.Write("Введите число: ");
// string inputA = Console.ReadLine();
// int number = Convert.ToInt32(inputA);
// int a = 7;
// int b = 23;

// if (number % a == 0 && number % b == 0){  // Проверка на кратность числа number числу a и b одновременно
// }
// else {
//     Console.WriteLine("No");
// }

/* Проверка что введено именно число(int)

Console.WriteLine("Введите число:");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))  // Проверка что введеннное значение целое число(int)
{
    Console.WriteLine($"Вы ввели число: {number}");  //Если true Выполнить оператор
}
else
{
    Console.WriteLine("Ошибка: вы должны ввести число."); //Если false выполнить оператор
}

*/
//Ввод данных
// Console.WriteLine("Введите число:");
// string input = Console.ReadLine();

// //Выполнение проверки ввода данных
// if (int.TryParse(input, out int number)){
//     //Вывод если true
//     Console.WriteLine($"Вы ввели число: `{number}`");
// }
    
// else{
//     //Вывод если false
//     Console.WriteLine("Ошибка: вы должны ввести число.");
// }
// Console.Write("Введите пятизнаяное число: ");
// string input = Console.ReadLine();

// int length = input.Length;

// int[] array = new int[length];
// for (int i = 0; i < length; i++){
//     array[i] = int.Parse(input[i]+ "");
// }
// Console.Write("Мой массив: ");
// Console.WriteLine("[{0}]", string.Join(", ", array));

// Console.WriteLine();

// int newarray (int arg1, string arg2){
//     int [] result = new int[arg1];
//     for (int i = 0; i < arg1; i++){
//         result[i] = int.Parse(arg2[i]+ "");
//     }
//     Console.Write("Мой массив: ");
//     Console.WriteLine("[{0}]", string.Join(", ", result));
//     string resulttest = string.Join(", ", result);
//     return resulttest;
// }
// var array2 = newarray(length, input);
// Console.Write("Второе число в моем массиве: ");
// Console.WriteLine(array2);

//Метод должен проверить является ли число пятизначным, в противном случае вывести 
//"Число не пятизначное" и "False" на следующей строке

//Дла остальных чисел вернуть "True" или "False"

// 14212 -> False
// 12821 -> True
//234322 -> Число не пятизначное
//              False

/*

bool findlengthnumb(string arg1){
    int length = arg1.Length;
    if (length == 5){
        return true;
    }
    else {
        return false;
    }
}
bool inpolindrom(string arg1){
    int length = arg1.Length;
    int[] array = new int[length];
        for (int i = 0; i < length; i++){
            array[i] = int.Parse(arg1[i]+"");
        }
        //Проверяем является и число полиндромом
        if (array[0] == array[4] && array[1] == array[3]){
            return true;
        }
        else{
            return false;
        }
}

Console.Write("Введите пятизначное чсило: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number)){

    if (findlengthnumb(input) == true){
        if (inpolindrom(input) == true){
            Console.WriteLine("True");
        }
        else if (inpolindrom(input) == false){
            Console.WriteLine("False");
        }
    }
    else if (findlengthnumb(input) ==  false){
        Console.WriteLine("Число не пятизначное");
        Console.WriteLine("False");
    }
}
else{
    Console.WriteLine("Ошибка: Вы должны ввести число!!");
}
*/

/* Переворот строки

string str = "Rewer ME";
string str = Console.ReadLine();
string str2 = ReverseArrayFramework(str);
static string ReverseArrayFramework(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}
if (str == str2){
    Console.WriteLine("True");
}
else {
    Console.WriteLine("False");
}

*/
/*
bool findlengthnumb(string arg1){
    int length = arg1.Length;
    if (length == 5){
        return true;
    }
    else {
        return false;
    }
}

bool IsPalindrome(string number, int limit){
    int length = number.Length;
    if (length == limit){
        int[] array = new int[5];
            for (int i = 0; i < length; i++){
                array[i] = int.Parse(number[i]+"");
            }
        //Проверяем является и число полиндромом
            if (array[0] == array[4] && array[1] == array[3]){
                return true;
            }
            else{
                return false;
            }
    }
    else {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}

Console.Write("Введите пятизначное чсило: ");
string input = Console.ReadLine();
int limit = 5;
bool number = IsPalindrome(input, limit);
Console.WriteLine($"{number}");
*/
/*
bool IsPalindrome(int number){
    int length = number.ToString().Length;
    if (length == 5){
        int lastdigit, newnumber = 0; //lastdigit последняя цифра, newnumber новое число
        int temp =  number; //temp временная переменная
        while(number > 0){
          lastdigit = number % 10;
          newnumber = (newnumber * 10) + lastdigit;
          number = number / 10;
        }
        if (temp == newnumber){
          return true;
        }
        else{
           return false;
        }
    }
    else{
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}
*/
// int SummNumber (int number){
//     int result = 0;
//     for (int i = 1; i <= number; i++){
//         result = result + i;
//     }
//     return result;
// }

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = SummNumber(number);
// Console.WriteLine(sum);

// string Promt(){
//     Console.Write("Введите число: ");
//     string result = Console.ReadLine();
//     return result;
// }

// int Sublustrum007(string str){
//     int result = Convert.ToInt32(str);
//     int length = str.Length;
//     for (int i = 1; i <= length; i++){
//         result = result * i;
//     }

//     return result;

// }

// string a = Promt();
// int b = Sublustrum007(a);
// Console.WriteLine($"Колличество цифр в числе {a} равное {b}");

/*
string Promt(){
    Console.Write("Введите число N: ");
    string result = Console.ReadLine();
    return result;
}

int Sublustrum007(string str){
    int N = Convert.ToInt32(str);
    int result = 1;
    for(int i = 1; i <= N; i++){
        result = result * i;
    }
    return result;
}

// string a = Promt();
// // int b = Sublustrum007(a);
Console.WriteLine(Sublustrum007(Promt()));
*/

/*
string Promt(){
    Console.Write("Введите число: ");
    string result = Console.ReadLine();
    return result;

}

int Sublustrum007(int number){
    string a = Convert.ToString(number);
    int result = a.Length;
    return result;
}

string input = Promt();

if (int.TryParse(input, out int output)){
    if (output > 0){
        Console.WriteLine(Sublustrum007(output));
    }
    else {
        output = output * -1;
        Console.WriteLine(Sublustrum007(output));
    }
}
else{
    Console.WriteLine("Вы должны ввечти число!!");
}
*/

/*
string Promt(){
    Console.Write("Введите колличесвто элементов массива: ");
    string result = Console.ReadLine();
    return result;
}

int[] GeneratArray(string arg1){
    Console.Write("Введите начальную цифру: ");
    int arg2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечную цифру: ");
    int arg3 = (Convert.ToInt32(Console.ReadLine())) + 1;
    int length = Convert.ToInt32(arg1);
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(arg2, arg3);
        i++;
    }
    return array;
}

void PrintArray(int[] array){
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// PrintArray(Promt());
// CreateArray();

string input = Promt();
// PrintArray(input);
int[] arr = GeneratArray(input);
PrintArray(arr);
*/

/*
string Promt(string str){
    Console.Write(str);
    string result = Console.ReadLine();
    return result;
}

string str1 = Promt("Введите первое число: ");
string str2 = Promt("Введите второе число: ");

if (int.TryParse(str1, out int test1) && int.TryParse(str2, out int test2)){
    Console.WriteLine("Yes");
}
else {
    Console.WriteLine("No");
}
*/

/*
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
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} положительное число");
        break;
    case < 5:
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} положительных числа");
        break;
    case int i when (((CountEvenElements(array, str)))%10== 0):
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} положительных чисел");
        break;
    default:
        Console.WriteLine($"В массие, {CountEvenElements(array, str)} положительных числа");
        break;
}
*/

/*
void PrintArray(double[] array)
{
    string str = $"[{string.Join(',', array)}]";
    Console.WriteLine(str);
}

double[] CreateArray(int length)
{
    double[] array = new double[length];
    Console.WriteLine("Генерация массива!!");
    Console.Write("Введите нижную границу массива: ");
    int LowElement = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нижную границу массива: ");
    int HighElement = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(LowElement, HighElement);
    }
    return array;
}

double[] ReversArray(double[] array)
{
    int length = array.Length;
    int lastindex = length - 1;
    for (int i = 0; i < length / 2; i++)
    {
        double temp = array[i];
        array[i] = array[lastindex];
        array[lastindex] = temp;
        lastindex = lastindex - 1;
    }

    return array;
}

Console.Write("Введите колличество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(numb);
Console.WriteLine();
Console.WriteLine("Получился такой вот массив:");
PrintArray(array);
Console.WriteLine();
double[] rewers = ReversArray(array);
Console.WriteLine();
Console.WriteLine("А это расзернутый массив:");
PrintArray(rewers);
*/

/*
Console.Write("Введите число: ");
string enter = Console.ReadLine();
double numb = Convert.ToDouble(enter);

bool MoreOrLess(double numb){
    if (numb > 0){
        return true;
    }
    else{
        return false;
    }
}

Console.WriteLine(MoreOrLess(numb));
*/

/*
double[] CreateArray(string[] str){
    double[] array = new double [str.Length];
    for ( int i = 0; i < str.Length; i++){
        array[i] = Convert.ToDouble(str[i]);
    }
    return array;
}

int MoreOrLess(double[] array){
    int count = 0;
    for( int i = 0; i < array.Length; i++ ){
        if (array[i] > 0){
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Please enter numbers: ");
string enter = Console.ReadLine();
string[] str = enter.Split(",");
double[] array = CreateArray(str);
Console.WriteLine(MoreOrLess(array));
*/

/*
void PromtStr(string str){
    Console.Write(str);
    Console.WriteLine();
}

int PromtInt(string str){
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            array[i, j] = k;
        }
    }

    return array;
}

int[,] FindAndEdit(int[,] array, int m, int n){
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            array[i, j] = k;
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = PromtInt("Введите значение m:");
int n = PromtInt("Введите значение n:");
Console.Clear();
PromtStr($"Вы вввели значение m = {m} и n = {n}");
Console.WriteLine();
int[,] array = CreateArray(m, n);
PrintArray(array);
*/

/*
void PromtStr(string str){
    Console.Write(str);
    Console.WriteLine();
}

int PromtInt(string str){
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            array[i, j] = k;
        }
    }
    return array;
}

int[,] FindAndEdit(int[,] array, int m, int n){
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            if(i % 2 != 0 && j % 2 != 0){
                k = array[i, j] * array[i, j];
            }
            array[i, j] = k;
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = PromtInt("Введите значение m:");
int n = PromtInt("Введите значение n:");
Console.Clear();
PromtStr($"Вы вввели значение m = {m} и n = {n}");
Console.WriteLine();
int[,] array = CreateArray(m, n);
PromtStr("Массив до изменения.");
PrintArray(array);
int[,] newarray = FindAndEdit(array, m, n);
PromtStr("Массив после изменения.");
PrintArray(newarray);
*/
/*
void PromtStr(string str){
    Console.Write(str);
    Console.WriteLine();
}

int PromtInt(string str){
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            array[i, j] = k;
        }
    }

    return array;
}

int Summ(int[,] array, int m, int n){
    int x = 0;
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            int k = i+j;
            if(i == j){
                x = x + array[i, j];
            }
            array[i, j] = k;
        }
    }
    return x;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = PromtInt("Введите значение m:");
int n = PromtInt("Введите значение n:");
Console.Clear();
PromtStr($"Вы вввели значение m = {m} и n = {n}");
Console.WriteLine();
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine($"Суума элементов, находящихся на главной диагонале равно {Summ(array,  m, n)}");
*/
/* Рекурсия выков функции в самой себе

int m = 5;
int n = 1;

void Range(int m, int n){
    if (m == n){
        Console.Write(m + " ");
        return;
    }
    Console.Write(m + " ");
    Range(m - 1, n);
}
Range(m, n);
*/
/*
int m = 1;
int n = 15;
int summ = 0;

void Range(int m, int n){
    if (m > n){
        Console.Write($"{summ}");
        return;
    }
    summ = summ + m;
    Range(m + 1, n);
}
Range(m, n);
*/
/*
int A(int m, int n){
    if(m == 0){
        return n + 1;
    }
    else{
        if((m != 0) && (n == 0)){
            return A(m - 1, 1);
        }
        else{
            return A(m - 1, A(m, n - 1));
        }
    }
}
int m = 3;
int n = 2;    
int result = A(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
*/

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

/*
void PrintArray(string str, int[,] array){
    Console.WriteLine($"{str}");
    for(int row = 0; row < array.GetLength(0); row++){
        for(int column = 0; column < array.GetLength(1); column++){
            Console.Write($"{array[row, column]}\t");
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int[4,4]{
    {3,8,5,1},
    {14,15,6,4},
    {37,81,92,10},
    {654,3,64,6}
};
string str = "Исходная матрица";
PrintArray(str, matrix);
// int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
for(int row = 0; row < matrix.GetLength(0); row++){
    for(int column = 0; column < matrix.GetLength(1) - 1; column++){
        int min = column;
        for(int x = column + 1; x < matrix.GetLength(1); x++){
            if(matrix[row, x] < matrix[row, min]){
                min = x;
            }
        }
        int temp = matrix[row, column];
        matrix[row, column] = matrix[row, min];
        matrix[row, min] = temp;
    }
}
string newstr = "Должна быть новая матрица";
PrintArray(newstr, matrix);

/*
void PrintArray(int[] array){
    for(int column = 0; column < array.Length; column++){
        Console.Write($"{array[column]} ");
    }
    Console.WriteLine();
}

int[] array = {654,9861,5,465,9,8};
int[] newarray = new int[array.Length];
PrintArray(array);

for(int column = 0; column < array.Length - 1; column++){
    int min = column;
    for(int j = column + 1; j < array.Length; j++){
        if(array[j] < array[min]){
            min = j;
        }
    }
    int temp = array[column];
    array[column] = array[min];
    array[min] = temp;
}

Console.WriteLine();
PrintArray(array);
*/

/*
double Fibonacci(int n){
    if( n == 1 || n ==2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for(int i = 1; i < 50; i++){
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}

*/
void DrawText(string text, int left, int top){
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

string caption = "Intensice C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

// DrawText(caption, screenWidthPosition, screenHeightPosition); //Вариант 1
DrawText(  // Вариант 2
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);