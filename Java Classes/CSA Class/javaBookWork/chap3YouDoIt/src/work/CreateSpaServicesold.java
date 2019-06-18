package work;

import java.util.Scanner;

public class CreateSpaServicesold {
    //old file for "documentation"
    //for a grade
    public static void main(String[] args){
        String service;
        double price;
        spaService firstService = new spaService();
        spaService secondService = new spaService();
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Enter Service >> ");
        service = keyboard.nextLine();
        System.out.println("Enter Price >> ");
        price = keyboard.nextDouble();

        firstService.setServiceDescription(service);
        firstService.setPrice(price);
        keyboard.nextLine();
        System.out.print("Enter Service >> ");
        service = keyboard.nextLine();
        System.out.print("Enter Price >> ");
        price = keyboard.nextDouble();
        secondService.setServiceDescription(service);
        secondService.setPrice(price);

        System.out.println("First service details:");
        System.out.println(firstService.getServiceDescription() + " $" + firstService.getPrice());
        System.out.println("Second service details:");
        System.out.println(secondService.getServiceDescription() + " $" + secondService.getPrice());
    }
}
