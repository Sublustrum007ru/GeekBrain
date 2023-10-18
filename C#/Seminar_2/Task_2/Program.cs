Console.Clear();
Console.Write("Введите число: ");

string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))  // Проверка введенных данных, если число то Yes, если нет то No
{
    int[] arrInt = new int[input.Length];

    for (int n = 0; n < input.Length; ++n){
        arrInt[n] = int.Parse(input[n]+ "");
    }
    
    if (input.Length >= 3){
        Console.WriteLine(arrInt[2]);
    }
    else if (input.Length < 3) {
        Console.WriteLine("Третьей цифры нет");
    }
}
else
{
    Console.WriteLine("Ошибка: вы должны ввести число.");
}