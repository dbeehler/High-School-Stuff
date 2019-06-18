package Excercises;

import java.util.Random;

public class MathTest {
    public static void main(String[] args){
        char d = 'D';
        int woops = 71;
        Random rand = new Random();
        print("The square root of 37 is... ", Math.sqrt(37));
        print("Cosine of 300... ", Math.cos(300));
        print("Sine of 300... ", Math.sin(300));
        print("Floor of 22.8 ", Math.floor(22.8));
        print("Ceiling of 22.8 ", Math.ceil(22.8));
        print("Round of 22.8 ", Math.round(22.8));
        print("Min of D and 71... ", Math.min(d, woops));
        print("Max of D and 71... ", Math.max(d, woops));
        System.out.println("Random number from 0 to 20... " + rand.nextInt(20));
    }

    private static void print(String words, double num){
        System.out.println(words + num);
    }
}
