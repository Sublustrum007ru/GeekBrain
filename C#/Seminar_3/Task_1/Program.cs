bool IsPalindrome(int number, int limit){
    int length = number.ToString().Length;
    if (length == limit){
        int lastdigit, newnumber = 0;   //lastdigit последняя цифра, newnumber новое число
        int temp = number;   //temp временная переменная
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
        Console.WriteLine($"Число не {limit}-значное");
        return false;
    }

}

Console.Write("Введите пятизначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
int limit = 5;
bool result = IsPalindrome(input, limit);  //Вызов метода(функции) с аргументами input и limit
Console.WriteLine(result);
