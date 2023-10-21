void ShowCube(int N){
    int count = 1;
    while(count <= N){
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
    return;
}


Console.Write("Введите число `N`: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowCube(N);  //Вызов метода 
