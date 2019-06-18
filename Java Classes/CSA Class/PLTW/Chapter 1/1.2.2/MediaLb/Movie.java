
/**
 * Write a description of class Movie here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Movie
{
    private static int rating, duration, hours, minutes;
    private String title;
    
    public Movie(){
         rating = 0;
    }
    
    public Movie(String title, int rating, int duration){
        this.title = title;
        this.rating = rating;
        this.duration = duration;
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
    
    public static String returnDur(){
        hours = duration / 60;
        minutes = duration % 60;
        return "hours: " + hours + " and minutes: " + minutes;
    }
}
