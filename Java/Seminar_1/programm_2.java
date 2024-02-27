class Answer {
    public void printPrimeNums(){
        // Напишите свое решение ниже
        for (int i = 2; i < 1000; i++){
            if(checkSimmple(i))
                System.out.println(i);
        }
    }
    public static boolean  checkSimmple(int i){
        if (i == 1)
            return false;
        else if (i <= 3)
            return true;
        else if (i % 2 == 0 || i % 3 == 0)
            return false;
        int temp = 5;
        while ( temp * temp <= i){
            if ( i % temp == 0 || i % (temp  + 2) == 0)
                return false;
            temp = temp + 6;
        }
        return true;
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
    public static void main(String[] args) { 
      
      Answer ans = new Answer();      
      ans.printPrimeNums();
    }
}