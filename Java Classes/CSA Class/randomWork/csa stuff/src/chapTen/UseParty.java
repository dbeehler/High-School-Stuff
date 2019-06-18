package chapTen;

import java.util.Scanner;

public class UseParty {
    public static void main(String[] Args){
        int guests;
        int choice;

        Party aParty = new Party();
        DinnerParty aDinnerParty = new DinnerParty();
        Scanner scan = new Scanner(System.in);

        System.out.println("Enter the number of guests");
        guests = scan.nextInt();
        aParty.setGuests(guests);
        System.out.println("The party has " + aParty.getGuests() + " guests");
        System.out.println("Enter menu option -- 1 for chicken or 2 for beef");
        choice =  scan.nextInt();
        aDinnerParty.setDinnerChoice(choice);
        System.out.println("Menu option " + aDinnerParty.getDinnerChoice() + " will be served");
        aParty.displayInvite();
    }
}
