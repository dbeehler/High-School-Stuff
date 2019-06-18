import java.util.List;
import java.util.ArrayList;
/**
 * Write a description of class FavoriteMediaLib here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class FavoriteMediaLib
{  
    public static void main(){
        List<String> data = new ArrayList<String>();
        List<Integer> favs = new ArrayList<Integer>();
        List<String> listOfFavs = new ArrayList<String>();
        int placeOfBracket = 0;
        
        for(int x = 0; x < Song.numSongsInLibrary - 1; x++){
            String input = MediaFile.readString();
            placeOfBracket = input.indexOf("|");
            data.add(input.substring(0, placeOfBracket));
            favs.add(Integer.parseInt(input.substring(placeOfBracket + 1, input.length())));
        }
        
        for(int x = 0; x < data.size(); x++){
            if(favs.get(x) > 7){
                listOfFavs.add(data.get(x));
            }
        }
        System.out.println("My favorite songs are...");
        System.out.println(listOfFavs);
    }
}
