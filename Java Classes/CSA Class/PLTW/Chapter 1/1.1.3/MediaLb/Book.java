
/**
 * Write a description of class Book here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Book
{
    private int rating;
    private String title;
    
    public Book(){
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
