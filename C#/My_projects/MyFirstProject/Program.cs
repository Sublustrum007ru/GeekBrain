Console.Clear();
void PrintWarning(){
    Console.WriteLine();
    Console.WriteLine("ОШИБКА!!!!");
    Console.WriteLine("Вы должны ввести число!!!");
    Console.WriteLine();
}

double InputFirstNumb(){
    double firstnumb;
    bool output;
    do{
        Console.Write("Введите первое число: ");
        output = double.TryParse(Console.ReadLine(), out firstnumb);
        if (output == false){
            PrintWarning();
        }
    }while(output == false);
    return firstnumb;
}

double InputSecondNumb(){
    double secondnumb;
    bool output;
    do{
        Console.Write("введите второе число: ");
        output = double.TryParse(Console.ReadLine(), out secondnumb);
        if(output == false){
            PrintWarning();
        }

    }while(output == false);
    return secondnumb;
}

double Adding(double firstnumb, double secondnumb){
    double result = firstnumb + secondnumb;
    return result;
}

double Subtract(double firstnumb, double secondnumb){
    double result = firstnumb - secondnumb;
    return result;
}

double Multiply(double firstnumb, double secondnumb){
    double result = firstnumb * secondnumb;
    return result;
}

double Dividing(double firstnumb, double secondnumb){
    double result = firstnumb / secondnumb;
    return result;
}

double Degree(double firstnumb, double secondnumb){
    double result = firstnumb;
    for (int i = 0; i < secondnumb - 1; i++){
        result = result * firstnumb;
    }
    return result;
}

Input:
Console.WriteLine("Введите желаемое действие.");
Console.WriteLine("1. Сложение.");
Console.WriteLine("2. Вычетание.");
Console.WriteLine("3. Умножение.");
Console.WriteLine("4. Деление.");
Console.WriteLine("5. Возведение в степень.");
//Console.WriteLine("6. ");
//Console.WriteLine("7. ");
Console.WriteLine();
Console.Write("Ввод: ");
switch(Console.ReadLine()){
    case "1":
        Console.Clear();
        Console.WriteLine("Сложение.");
        Console.WriteLine($"Ответ: {Adding(InputFirstNumb(), InputSecondNumb())}");
        goto Input;
    case "2":
        Console.Clear();
        Console.WriteLine("Вычетание.");
        Console.WriteLine($"Ответ: {Subtract(InputFirstNumb(), InputSecondNumb())}");
        goto Input;
    case "3":
        Console.Clear();
        Console.WriteLine("Умножение.");
        Console.WriteLine($"Ответ: {Multiply(InputFirstNumb(), InputSecondNumb())}");
        goto Input;
    case "4":
        Console.Clear();
        Console.WriteLine("Деление.");
        Console.WriteLine($"Ответ: {Dividing(InputFirstNumb(), InputSecondNumb())}");
        goto Input;
    case "5":
        Console.Clear();
        Console.WriteLine("Возведение в степень.");
        Console.WriteLine($"Ответ: {Degree(InputFirstNumb(), InputSecondNumb())}");
        goto Input;
    default:
        Console.WriteLine("ОШИБКА!!!");
        Console.WriteLine("Выберите из списка ниже!!!");
        Console.WriteLine();
        goto Input;
}