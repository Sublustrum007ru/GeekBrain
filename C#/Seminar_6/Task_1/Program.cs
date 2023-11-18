Console.Write("Введите элементы массива через запятую: ");
string enter = Console.ReadLine();
string[] str = enter.Split(",");
double[] array = CreateArray.Create(str);

Console.WriteLine($"Колличество чисел больше 0 равно = {MoreOrLess.Comparison(array)}");