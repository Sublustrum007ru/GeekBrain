public static class CreateArray
{
    public static double[] Create(int length)
    {
        double[] array = new double[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }

        return array;
    }
}