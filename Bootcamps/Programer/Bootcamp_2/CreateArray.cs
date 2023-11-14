/// <summary>
/// Это класс, отвечающий за создание массива
/// </summary>
public static class CreateArray
{
    /// <summary>
    /// Метод создание массива
    /// </summary>
    /// <param name="n">Колличесвто элементов</param>
    /// <returns>Новый массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = new Random(seed);
        return array = array.Select(item => random.Next(min, max)).ToArray();
    }
}