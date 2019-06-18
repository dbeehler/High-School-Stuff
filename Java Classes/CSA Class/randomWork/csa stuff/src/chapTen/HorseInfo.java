package chapTen;

import java.util.Random;
import java.util.Scanner;

public class HorseInfo {

    public static void main(String[] Args){
        String name, color, day;
        int races;
        Horse horse = new Horse();
        RaceHorse raceHorse = new RaceHorse();
        print("Enter your horses age");
        Scanner scan = new Scanner(System.in);
        day = scan.nextLine();
        horse.setBirthday(day);
        print("Enter your horses color");
        color = scan.nextLine();
        horse.setColor(color);
        print("Enter your horses name");
        name = scan.nextLine();
        horse.setName(name);
        print("Enter how many races your horses has been in");
        races = scan.nextInt();
        raceHorse.setNumOfRaces(races);

        System.out.println(horse.getName() + " is " + horse.getColor() + " and is " + horse.getBirthday() + " years old." + " It has been in " + raceHorse.getNumOfRaces() + " races.");
    }

    private static void print(String prn){
        System.out.println(prn);
    }
}
