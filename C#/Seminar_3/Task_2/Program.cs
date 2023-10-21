//Написать метод, который на вход принимает координаты двух точек pointA и PountB, в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

//A(3,6,8); B(2,1,-7) -> 15.84
//A(7,-5,0); B(1,-1,9) -> 11.53

//pointA(xa ya za) pointB(xb yb zb)
Console.Clear();
double Length(int[] pointA, int[] pointB){
    double result = Math.Sqrt((Math.Pow((pointB[0]-pointA[0]),2))+(Math.Pow((pointB[1]-pointA[1]),2))+(Math.Pow((pointB[2]-pointA[2]),2)));
    //double result = Math.Sqrt(pointA[0]);  // Вычисления корня из числа
    //double result = Math.Pow((pointA[0]-pointA[1]), 2);  // Возведение в степень
    return result;
}

Console.Write("Введите координату x1 точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 точки A: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x3 точки A: ");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1 точки B: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y3 точки B: ");
int y3 = Convert.ToInt32(Console.ReadLine());

//double result = Math.Round((Length(new int []{x1, x2, x3}, new int[] {y1, y2, y3})), 2);
double result = Length(new int []{x1, x2, x3}, new int[] {y1, y2, y3});

Console.WriteLine($"Координаты точки А: {x1} {x2} {x3}");
Console.WriteLine($"Координаты точки B: {y1} {y2} {y3}");
Console.WriteLine(result);
Console.WriteLine($"{result:F2}");