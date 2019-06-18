package main;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Scanner;

public class arraylists {

    public static void main(String[] args) {
        createNames();
    }

    public static void display(ArrayList<String> names) {
        System.out.println(names);
    }

    public static void createNames(){
        ArrayList<String> names =  new ArrayList<String>();
        names.add("Bobby");
        names.add("Todd");
        names.add("Josh");
        names.add(0, "Sam");
        names.remove(3);
        display(names);

        Scanner scan = new Scanner(System.in);

        System.out.println("Enter 5 names");
        for(int x = 0; x < 5; x++){
            names.add(scan.nextLine());
        }

        names.add("Chase");
        System.out.println("What name would you like to delete?");
        display(names);
        String remove = scan.nextLine();
        int nameIndex = names.indexOf(remove);
        names.remove(nameIndex);
        System.out.println("Name deleted...");
        display(names);
    }


}