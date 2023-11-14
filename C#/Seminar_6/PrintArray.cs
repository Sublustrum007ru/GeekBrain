public static class PrintArray
{
    public static void Print(double[] array)
    {
    string str = $"[{string.Join(',', array)}]";
    Console.WriteLine(str);
    // return str;
    }
}