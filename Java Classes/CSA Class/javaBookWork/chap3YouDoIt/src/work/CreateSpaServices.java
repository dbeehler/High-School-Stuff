package work;

import java.util.Scanner;
public class CreateSpaServices {
    public static void main(String[] args){
        spaService firstService = new spaService();
        spaService secondService = new spaService();

        firstService = getData(firstService);
        secondService = getData(secondService);

        System.out.println("First service details:");
        System.out.println(firstService.getServiceDescription() + " $" + firstService.getPrice());
        System.out.println("Second service details:");
        System.out.println(secondService.getServiceDescription() + " $" + secondService.getPrice());
    }

    public static spaService getData(spaService s){
        String service;
        double price;
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Enter Service >> ");
        service = keyboard.nextLine();
        System.out.println("Enter price >>");
        price = keyboard.nextDouble();
        keyboard.nextLine();

        s.setServiceDescription(service);
        s.setPrice(price);
        return s;
    }
}
