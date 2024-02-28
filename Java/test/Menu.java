package test;
import java.util.Scanner;

class Menu{
    public static void main(String[] args){
        Scanner input = new Scanner (System.in);
        int numb = input.nextInt();
        System.out.println(numb);
        input.close();
    }
}