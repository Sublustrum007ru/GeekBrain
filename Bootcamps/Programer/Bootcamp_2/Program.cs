// using static CreateArray;
// using static PrintArray;
// using static MathArray;
using System.Diagnostics;

Console.Clear();

int[] array = CreateArray.Create(10_000_000).Fill(1, 10, 100_000);
PrintArray.Print(array);


int time;
Stopwatch sw = new Stopwatch();
sw.Start();
time = MathArray.BadGetSum(array);
sw.Stop();
Console.WriteLine($"BadGetSum: {time} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
time = MathArray.BadGetSum(array);
sw.Stop();

Console.WriteLine($"GoodGetSum: {time} => {sw.ElapsedMilliseconds}");

Console.WriteLine(MathArray.BadGetSum(array));
Console.WriteLine(MathArray.GoodGetSum(array));