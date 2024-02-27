import java.util.ArrayList;
import java.util.HashMap;

class PhoneBook {
    private static HashMap<String, ArrayList<Integer>> phoneBook = new HashMap<>();

    public void add(String name, Integer phoneNum) {

      // Введите свое решение ниже
        String key = name;
        if(phoneBook.containsKey(key) == false){
          ArrayList<Integer> value = new ArrayList<>();
          value.add(phoneNum);
          phoneBook.put(key, value);
        }else{
          ArrayList<Integer> value = new ArrayList<>();
          value = phoneBook.get(name);
          value.add(phoneNum);
          phoneBook.replace(key, value);
          
        }
        
    }

    public ArrayList<Integer> find(String name) {
    // Введите свое решение ниже
    ArrayList<Integer> value = new ArrayList<>();
        if(phoneBook.containsKey(name)){
          value = phoneBook.get(name);
          return value;
        }
        value.clear();
        return value;   

    }

    public static HashMap<String, ArrayList<Integer>> getPhoneBook() {
    // Введите свое решение ниже
      return phoneBook;

    }
}
// Не удаляйте этот класс - он нужен для 

public class programm_1 {
    public static void main(String[] args) {
        String name1;
        String name2;
        int phone1;
        int phone2;
        int phone3;

        if (args.length == 0) {
            name1 = "Ivanov";
            name2 = "Petrov";
            phone1 = 123456;
            phone2 = 654321;
            phone3 = 369852;
        } else {
            name1 = args[0];
            name2 = args[1];
            phone1 = Integer.parseInt(args[2]);
            phone2 = Integer.parseInt(args[3]);
            phone3 = Integer.parseInt(args[2]);
        }

        PhoneBook myPhoneBook = new PhoneBook();
        myPhoneBook.add(name1, phone1);
        myPhoneBook.add(name1, phone2);
        myPhoneBook.add(name2, phone3);

        System.out.println(myPhoneBook.find(name2));
        System.out.println(PhoneBook.getPhoneBook());
        System.out.println(myPhoneBook.find("Me"));
    }
}