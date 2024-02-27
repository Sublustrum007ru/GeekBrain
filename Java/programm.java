import java.util.Arrays;
import java.util.ArrayList;

class Answer{
    public static void analyzeNumbers(Integer[] arr){
        Integer[] sortArr = sortArray(arr);
        ArrayList<Integer> array = new ArrayList<>();
        for(int i = 0; i < sortArr.length; i++){
            array.add(sortArr[i]);
        }
        System.out.println(array);
        int minArr = minArr(arr);
        System.out.println("Minimum is " + minArr);
        int maxArr = maxArr(arr);
        System.out.println("Maximum is " + maxArr);
        double averageArr = averageArr(arr);
        System.out.println("Average is = " + averageArr);
    }
    public static Integer[] sortArray(Integer[] arr){
        for(int i = 0; i < arr.length; i++){
            for(int j = 0; j < arr.length; j++){
                if(arr[i] < arr[j]){
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        return arr;
    }
    public static int minArr(Integer[] arr){
        int min = arr[0];
        for(int i = 1; i < arr.length; i++){
            if(arr[i] < min){
                min = arr[i];
            }
        }
        return min;
    }
    public static int maxArr(Integer[] arr){
        int max = arr[0];
        for(int i = 1; i < arr.length; i++){
            if(arr[i] > max){
                max = arr[i];
            }
        }
        return max;
    }
    public static double averageArr(Integer[] arr){
        double summ = 0;
        for(int i = 0; i < arr.length; i++){
            summ = summ + arr[i];

        }
        double average = summ / arr.length;
        return average;
    }
}

public class programm{
    public static void main(String[] args) { 
      Integer[] arr = {};
      
      if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
        arr = new Integer[]{-2, -1, 0, 1, 2, 3, 4, 5};
      }
      else{
        arr = Arrays.stream(args[0].split(", "))
                        .map(Integer::parseInt)
                        .toArray(Integer[]::new);
      }     
      
      Answer ans = new Answer();      
      ans.analyzeNumbers(arr);
    }

}