package main;

import java.util.*;

public class arrayAdd {
    private static ArrayList<Integer> scores = new ArrayList<Integer>();

    public static void main(String[] Args){
        Scanner scan = new Scanner(System.in);

        int input = 0;


        while(input != 999){
            System.out.println("Enter a number: ");
            input = scan.nextInt();
            if(input == 999){
                break;
            }
            else {
                addNum(input);
            }
        }
        display();
    }

    public static void addNum(int number){
        scores.add(number);
    }

    public static void display(){

        int total = 0;
        System.out.println("Here are your scores");

        for(int x = 0; x < scores.size(); x++){
            System.out.println(scores.get(x));
            total += scores.get(x);
        }
        System.out.println("Average is " + (total/scores.size()));
        System.out.println("Total is " + total);
    }
}
