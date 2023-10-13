Console.Write("Введите первое число: ");
string firstnumber = Console.ReadLine();
int a = Convert.ToInt32(firstnumber);
Console.Write("Введите второе число: ");
string secondnumber = Console.ReadLine();
int b = Convert.ToInt32(secondnumber);

if (a>b){
    Console.WriteLine("Первое число "+"'"+a+"' "+"больше чем второе число "+"'"+b+"'");
}
else {
    Console.WriteLine("Первое число "+"'"+a+"'"+"меньше чем второе число "+"'"+b+"'");
}