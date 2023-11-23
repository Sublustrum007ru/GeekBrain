Console.Write("Введите перве число: ");
string firstnumber = Console.ReadLine();
int a = Convert.ToInt32(firstnumber);
Console.Write("Введите второе число: ");
string secondnumber = Console.ReadLine();
int b = Convert.ToInt32(secondnumber);
Console.Write("Введите третье число: ");
string thirdnumber = Console.ReadLine();
int c = Convert.ToInt32(thirdnumber);
int max = 0;


if (a>max){
    max = a;
}
if (b>max){
    max = b;
}
if (c>max){
    max = c;
}
Console.WriteLine("Максимальное число " + max);