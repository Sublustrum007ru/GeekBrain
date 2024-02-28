package test;

import java.util.Scanner;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;

public class test {
    private static HashMap<String, ArrayList<Integer>> myPhoneBook = new HashMap<>();

    public static void print(String args) {
        System.out.println(args);
    }

    public static void menu() {
        boolean flag = false;
        String[] str = { "1. Добавить запись",
                "2. Изменить запись",
                "3. Удалить запись",
                "4. Вывести всю книгу",
                "5. Выход"
        };
        for (int i = 0; i < str.length; i++) {
            System.out.println(str[i]);
        }
        do{
            System.out.print("Введите команду: ");
            Scanner input = new Scanner(System.in);
            int cmd = input.nextInt();
            switch (cmd) {
                case 1:
                    add();
                    flag = true;
                    break;
                case 2:
                    edit();
                    flag = true;
                    break;
                case 3:
                    del();
                    flag = true;
                    break;
                case 4:
                    getPhoneBook();
                    flag = true;
                    break;
                case 5:
                    System.out.println("Exit");
                    flag = true;
                    break;
                default:
                    System.out.println("Неверная команда");
                    break;
            }
            input.close();

        }

        while (!flag);

    }

    public static void add() {
        System.out.println("Здесь будет создание записей");
        menu();
    }

    public static void edit() {
        System.out.println("Здесь будет редактирование записей");
        menu();
    }

    public static void del() {
        System.out.println("Здесь будет удаление записей");
        menu();
    }

    public static void getPhoneBook() {
        System.out.println(myPhoneBook);
        menu();
    }

    public static void main(String[] args) {
        String str;
        str = "~ My name Sublustrum007 ~";
        print(str);
        str = "~ This is my PhoneBook ~";
        print(str);
        System.out.println();
        menu();
    }
}