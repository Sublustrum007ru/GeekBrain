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

//Метод должен проверить является ли число рятизначным, в противном случае вывести 
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