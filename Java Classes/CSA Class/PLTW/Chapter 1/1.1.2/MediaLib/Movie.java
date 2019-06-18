
/**
 * Write a description of class Movie here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Movie
{
    private int rating;
    private String title;
    
    public Movie(){
         rating = 0;
    }
    
    public int getRating(){
        return rating;
    }
    
    public String getTitle(){
        return title;
    }
    
    public void setTitle(String t){
        title = t;
    }
}
