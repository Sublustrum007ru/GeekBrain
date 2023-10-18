Console.Clear();
Console.Write("Введите число: ");

string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))  // Проверка введенных данных, если число то Yes, если нет то No
{
    int i = Convert.ToInt32(input);

    if (i >= 1 && i <= 5){
        Console.WriteLine("Этот день недели не выходной");
    }

    else if (i == 6 || i == 7){
        Console.WriteLine("Этот день недели выходной");
    }

    else{
        Console.WriteLine("Вы ввели не корректное число");
    }
}
else{
    Console.WriteLine("Ошибка: вы должны ввести число.");
}