public static class MoreOrLess{
    /// <summary>
    /// Сравнение
    /// </summary>
    /// <param name="array">Числовой массив</param>
    /// <returns>Колличесвто числ больше нуля</returns>
    public static int Comparison(double[] array){
        int count = 0;
        for ( int i = 0; i < array.Length; i++){
            if ( array[i] > 0){
                count = count + 1;
            }
        }
        return count;
    }
}