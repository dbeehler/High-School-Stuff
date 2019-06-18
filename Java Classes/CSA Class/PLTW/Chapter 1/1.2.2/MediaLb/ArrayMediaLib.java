
/**
 * Write a description of class ArrayMediaLib here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class ArrayMediaLib
{
    public static void main(){
        Song[] topTenSongs = {new Song("The Twist"), new Song("Smooth"), new Song("Mack The Knife"), new Song("How Do I Live"), new Song("Party Rock Anthem"),
                                new Song("I Gotta Feeling"), new Song("Macarena"), new Song("Physical"), new Song("You Light Up My Life"), new Song("Hey Jude")
        };
        
        for (Song s: topTenSongs){
            System.out.println(s.getTitle());
        }
    }
    
    public static String help(){
        // change the array
        return "help";
    }
}
