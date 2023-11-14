public static class ReversArray
{
    public static double[] Revers(double[] array)
    {
        int length = array.Length;
        int lastindex = length - 1;
        for (int i = 0; i < length / 2; i++)
        {
            double temp = array[i];
            array[i] = array[lastindex];
            array[lastindex] = temp;
            lastindex = lastindex - 1;
        }
    return array;
    }
}