public static class Promt{
    public static double Output(string str){
        Console.Write($"Введите точку {str}: ");
        double result = Convert.ToDouble(Console.ReadLine());
        return result;
    }
}