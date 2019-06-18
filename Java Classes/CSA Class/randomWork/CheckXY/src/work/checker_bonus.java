package work;

import java.util.Scanner;

public class checker_bonus {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter string: ");
        String input = scan.nextLine();
        System.out.println(balanced_bonus(input));
    }
    private static boolean balanced_bonus(String s){
            char[] listOfLetters = new char[s.length()];
            boolean equal = false;

            for (int x = 0; x < s.length(); x++){
                if(x == 0){
                    listOfLetters[x] = s.charAt(x);
                }
                else if (listOfLetters[x] != s.charAt(x)){
                    listOfLetters[x] = s.charAt(x);
                }
            }
            int[] counts = new int[listOfLetters.length];

            for(int x = 0; x < listOfLetters.length; x++) {
                for(int y = 0; y < s.length(); y++){
                    if (listOfLetters[x] == s.charAt(y)) {
                        counts[x] += 1;
                    }
                }
            }

            for(int x = 0; x < counts.length; x++){
                if(x == 0){
                    if(counts[x] == counts[x+1])
                        equal = true;
                    else{
                        equal = false;
                        break;
                    }
                }
                else{
                    if(counts[x] == counts[x-1])
                        equal = true;
                    else{
                        equal = false;
                        break;
                    }
                }
            }
            return equal;
    }
}
