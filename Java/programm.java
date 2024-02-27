import java.util.Arrays;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class programm{ 
    public static int [] mergeSort(int[] a) {
        int length = a.length;
        if(length < 2) {
            return a;
        }

        int[] arrayB = new int[length / 2];
        int[] arrayC = new int[length - arrayB.length];
        
        System.arraycopy(a, 0, arrayB, 0, length / 2);
        System.arraycopy(a, length / 2, arrayC, 0, length - arrayB.length);
        
        arrayB = mergeSort(arrayB);
        arrayC = mergeSort(arrayC);

        return merge(arrayB, arrayC);
    }

    public static int[] merge(int[] arrayA, int[] arrayB){
        int positionA = 0;
        int positionB = 0;
        int[] arrayC = new int[arrayA.length + arrayB.length];
        int i = 0;
        
        while(positionA < arrayA.length && positionB < arrayB.length){
            if(arrayA[positionA] < arrayB[positionB]){
                arrayC[i] = arrayA[positionA];
                positionA++;
                i++;
            }else{
                arrayC[i] = arrayB[positionB];
                positionB++;
                i++;
            }
        }
        while(positionA < arrayA.length){
            arrayC[i] = arrayA[positionA];
            positionA++;
            i++;
        }
        while(positionB < arrayB.length){
            arrayC[i] = arrayB[positionB];
            positionB++;
            i++;
        }

        return arrayC;
    }
    public static void main(String[] args) { 
        int[] a;

        if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = new int[]{5, 1, 6, 2, 3, 4, -76, -7, 76, 653, 123};
        } else {
            a = Arrays.stream(args[0].split(", ")).mapToInt(Integer::parseInt).toArray();
        }

        // MergeSort answer = new MergeSort();
        String itresume_res = Arrays.toString(mergeSort(a));
        System.out.println(itresume_res);
    }
}