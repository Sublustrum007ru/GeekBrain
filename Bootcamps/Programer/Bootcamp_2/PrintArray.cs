/// <summary>
/// Вывод маасива
/// </summary>
public static class PrintArray
{
    public static string Print(this int[] array)
    {
        string str = $"[{string.Join(' ', array)}]";
        Console.WriteLine(str);
        return str;
    }
}