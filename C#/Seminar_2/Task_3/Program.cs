Console.Clear();
Console.Write("Введите число: ");

string input = Console.ReadLine();

if (int.TryParse(input, out int number))  // Проверка введенных данных, если число то Yes, если нет то No
{
    if (number >= 1 && number <= 5){
        Console.WriteLine("Этот день недели не выходной");
    }

    else if (number == 6 || number == 7){
        Console.WriteLine("Этот день недели выходной");
    }

    else{
        Console.WriteLine("Вы ввели не корректное число");
    }
}
else{
    Console.WriteLine("Ошибка: вы должны ввести число.");
}