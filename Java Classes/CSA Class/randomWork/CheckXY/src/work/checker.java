package work;

import java.util.Scanner;

public class checker {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter string: ");
        String input = scan.nextLine();
        System.out.println(balanced(input));
    }

    private static boolean balanced(String s){
        int xcount = 0, ycount = 0;

        for(int x = 0; x < s.length(); x++){
            if(s.charAt(x) == 'x' || s.charAt(x) == 'X'){
                xcount += 1;
            }
            else if(s.charAt(x) == 'y' || s.charAt(x) == 'Y') {
                ycount += 1;
            }
        }
        if (xcount == ycount)
            return true;
        else
            return false;
    }
}
