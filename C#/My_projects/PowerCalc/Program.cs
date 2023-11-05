Console.Clear();
void PrintWarning(){
    Console.WriteLine();
    Console.WriteLine("ОШИБКА!!!!");
    Console.WriteLine("Вы должны ввести число");
    Console.WriteLine();
}

/*double InputVoltage(){
    double voltage;
    bool output;
    do{
        Console.WriteLine();
        Console.Write("Вветите номинальное напряжение: ");
        output = double.TryParse(Console.ReadLine(), out voltage);
        if(output == false){
            PrintWarning();
        }
    }while(output == false);
    return voltage;

}*/

double InputPower(){
    double power;
    bool output;
    do{
        Console.WriteLine();
        Console.Write("Введите максимально возможную мощьность: ");
        output = double.TryParse(Console.ReadLine(), out power);
        if(output == false){
            PrintWarning();
        }
    }while(output == false);
    return power;
}

double InputAmper(){
    double amper;
    bool output;
    do{
        Console.WriteLine();
        Console.Write("Введите номинал автомата: ");
        output = double.TryParse(Console.ReadLine(), out amper);
        if( output == false){
            PrintWarning();
        }
    }while (output == false);
    return amper;
}

double SearchPower220(int voltage, double amper){
    double result = voltage * amper;
    return result;

}

double SearchAmper220(double power, int voltage){
    double result = power / voltage;
    return result;
}

double SearchAmper380(double power, int voltage){
    double result = (power / 1000) * 1.52;
    return result;
}

double SearchPower380(int voltage, double amper){
    double cosf = 0.95;
    double result = voltage * amper * cosf * 1.74;
    return result;

}

Input:
Console.WriteLine("Выберите для какой сети произвести расчет.");
Console.WriteLine();
Console.WriteLine("1. Если номинально напряжение сети 220 Вольт.");
Console.WriteLine("2. Если номинальное напряжение сети 380 Вольт.");
Console.WriteLine();
Console.Write("Ввод: ");
switch(Console.ReadLine()){
    case "1":
        Console.WriteLine("220 Вольт");
        Console.WriteLine();
        Console.WriteLine("1. Мощьность.");
        Console.WriteLine("2. Амперы.");
        Console.WriteLine();
        Console.Write("Ввод: ");
        string input = Console.ReadLine();
        if(input == "1"){
            Console.WriteLine($"Ответ: {SearchPower220(220, InputAmper())} Ватт");
        }
        else if (input == "2"){
            Console.WriteLine($"Ответ: {Math.Round(SearchAmper220(InputPower(), 220), 2)} A");
        }
        else{
            Console.WriteLine();
            Console.WriteLine("ОШИБКА!!!!");
            Console.WriteLine("Выдерете из списка ниже!!!!");
            Console.WriteLine();
        }
        goto Input;
    case "2":
        Console.WriteLine("380 Вольт");
        Console.WriteLine();
        Console.WriteLine("1. Мощьность.");
        Console.WriteLine("2. Амперы.");
        Console.WriteLine();
        Console.Write("Ввод: ");
        string input = Console.ReadLine();
        if(input == "1"){
            Console.WriteLine($"Ответ: {SearchPower380(380, InputAmper())} Ватт");
        }
        else if (input == "2"){
            Console.WriteLine($"Ответ: {Math.Round(SearchAmper380(InputPower(), 380), 2)} A");
        }
        else{
            Console.WriteLine();
            Console.WriteLine("ОШИБКА!!!!");
            Console.WriteLine("Выдерете из списка ниже!!!!");
            Console.WriteLine();
        goto Input;
    default:
        Console.WriteLine();
        Console.WriteLine("ОШИБКА!!!!");
        Console.WriteLine("Выдерете из списка ниже!!!!");
        Console.WriteLine();
        goto Input;
}