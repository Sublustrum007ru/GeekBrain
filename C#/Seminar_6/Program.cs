using static CreateArray;
using static PrintArray;
using static ReversArray;

Console.Clear();

double[] array = CreateArray.Create(10);
Console.WriteLine("Прямой массив:");
PrintArray.Print(array);
double[] revers = ReversArray.Revers(array);
Console.WriteLine("Онже но развернутый");
PrintArray.Print(revers);
