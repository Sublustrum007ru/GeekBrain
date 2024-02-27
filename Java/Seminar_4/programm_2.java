public class programm_2{
    public static void main(String[] args){
        String name1;
        String name2;
        int phone1;
        int phone2;

        if(args.length == 0){
            name1 = "Ivanov";
            name2 = "Petrov";
            phone1 = 123456;
            phone2 = 654321;
        } else{
            name1 = args[0];
            name2 = args[1];
            phone1 = Integer.parseInt(args[2]);
            phone2 = Integer.parseInt(args[3]);
        }
        PhoneBook myPhoneBook = new PhoneBook();
    }
}