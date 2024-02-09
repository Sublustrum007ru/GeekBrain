/*Первая задача автотеста
class Answer {
    public int countNTriangle(int n){
        if (n < 1){
            n = 1;
            return n;
        }
        return (n * (n + 1)) / 2;
    }
}


public class programm{
    
    static public void main(String[] args){
        int n = 0;
      
        if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
            n = 4;
        }
        else{
            n = Integer.parseInt(args[0]);
        }     
      
        // Вывод результата на экран
        Answer ans = new Answer(); 
        int itresume_res = ans.countNTriangle(n);     
        System.out.println(itresume_res);
    }
}
*/