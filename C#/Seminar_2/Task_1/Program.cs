Console.Clear();
Console.Write("Введите число: ");
string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number)) // Проверка введенных данных, если число то Yes, если нет то No
{
    int[] arrInt = new int[input.Length];
    int length = input.Length;
    int i = 0;
    while (i < length){
        arrInt[i] = int.Parse(input[i]+ "");
        i = i + 1;
    }

    if (length == 3){
        Console.WriteLine(arrInt[1]);
    }

    else {
        Console.WriteLine("Введено не корректное число!!");
    }
}
else
{
    Console.WriteLine("Ошибка: вы должны ввести число.");
}
