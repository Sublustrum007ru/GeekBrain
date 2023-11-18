public static class CreateArray{
    /// <summary>
    /// Созданеи числового массива из строкового массива.
    /// </summary>
    /// <param name="str">Стоковой массив</param>
    /// <returns>Числовой массив</returns>
    public static double[] Create(string[] str){
        double[] array = new double[str.Length];
        for ( int i = 0; i < str.Length; i++){
            array[i] = Convert.ToDouble(str[i]);
        }
        return array;
    }
}