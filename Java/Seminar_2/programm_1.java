class Answer {  
    public static StringBuilder answer(String QUERY, String PARAMS){
        // Напишите свое решение ниже
      PARAMS = PARAMS.replace("\"","").replace("{","").replace("} ","");
      String[] arg = PARAMS.split(",");

      String[] array[] = new String[arg.length][];
      
      for(int i = 0; i < arg.length; i++){
        array[i] = arg[i].split(":");
      }
      
      StringBuilder result = new StringBuilder();
      result.append(QUERY);
      StringBuilder sb = new StringBuilder();
      for( int i = 0; i < array.length; i++){
        if(!array[i][array[i].length - 1].equals("null}")){       
          if(sb.toString().equals("")){
            sb.append(array[i][0] + "=" + "'" + array[i][1] + "'" + "");
          }
        else{
          sb.append(" and" + array[i][0] + "=" + "'" + array[i][1] + "'" + "");

        }
      }
    }
    return result.append(sb);
  }
}

 
// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
	public static void main(String[] args) { 
      String QUERY = "";
      String PARAMS = "";
      
      if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
        QUERY = "select * from students where ";
	    PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
      }
      else{
        QUERY = args[0];
        PARAMS = args[1];
      }     
      
      Answer ans = new Answer();      
      System.out.println(ans.answer(QUERY, PARAMS));
	}
}