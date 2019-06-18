import java.util.Random;

//authors Dusty and Michael

public class SciFiName   
{
    private static String firstName, lastName, city, school, relativeOne, relativeTwo;
    public static void main()
    {
        System.out.println("If you provide me some information I will provide a Science Fiction name for you.");
        System.out.println("Please have all responses  be at least three characters long.");
        System.out.println("For best results, user lowercase letters with no spaces.\n");

        // notice this methd (print) does not print a newline
        System.out.print("Enter your first name: ");
        firstName = UserInput.getString();
        System.out.print("Enter your last name: ");
        lastName = UserInput.getString();
        System.out.print("Enter the city where you or one of your parents were born: ");
        city = UserInput.getString();
        System.out.print("Enter the name of your grammar school: ");
        school = UserInput.getString();
        System.out.print("Enter the first name of a sibling or other relative: ");
        relativeOne = UserInput.getString();
        System.out.print("Enter the first name of a second sibling or relative: ");
        relativeTwo = UserInput.getString();

        String firstThreeLetters, lastTwoLetters, scienceName;
        firstThreeLetters = firstName.substring(0, 3);
        lastTwoLetters = lastName.substring(0, 2);
        scienceName = firstThreeLetters + lastTwoLetters;
        
        String firstTwoLetters, firstSchool, scienceNameLast;
        firstTwoLetters = city.substring(0, 2);
        firstSchool = school.substring(0,3);
        scienceNameLast = firstTwoLetters + firstSchool;
        
        int relativeOneLength, relativeTwoLength;
        String lastOne, lastTwo;
        Random rand = new Random();
        
        lastOne = relativeOne.substring(rand.nextInt(relativeOne.length()), relativeOne.length());
        lastTwo = relativeTwo.substring(rand.nextInt(relativeTwo.length()), relativeTwo.length());
        String scienceCity = lastOne + lastTwo;
        
        System.out.println("Hello " + scienceName + " " + scienceNameLast + " of " + scienceCity + ". Welcome!");
    }
}
