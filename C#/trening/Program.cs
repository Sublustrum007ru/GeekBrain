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
Console.WriteLine("Введите число:");
string input = Console.ReadLine();

//Выполнение проверки ввода данных
if (int.TryParse(input, out int number)){
    //Вывод если true
    Console.WriteLine($"Вы ввели число: `{number}`");
}
    
else{
    //Вывод если false
    Console.WriteLine("Ошибка: вы должны ввести число.");
}