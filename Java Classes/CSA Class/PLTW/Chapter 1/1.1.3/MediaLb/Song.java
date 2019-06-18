
/**
 * Write a description of class Song here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Song
{
    private int rating;
    private double price = 0.0;
    private String title;
    private boolean favorite = false;
    public static double totalPrice = 0, avgCost;;
    public static int numSongs, totalRate, avgRate;
    
    public Song(){
         rating = 0;
    }
    
    public Song(String title, double price) {
    this.title = title;
    this.price = price;
    }
    
    public Song(String title, double price, int rating) {
    this.title = title;
    this.price = price;
    this.rating = rating;
    this.totalPrice += price;
    this.numSongs += 1;
    this.totalRate += rating;
    }
    
    public static double getAvgCost(){
        avgCost = totalPrice / numSongs;
        return avgCost;
    }
    
    public static int getAvgRate(){
        avgRate = totalRate / numSongs;
        return avgRate;
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
    
    public double getPrice(){
        return price;
    }
    
    public void setPrice(double wow){
        price = wow;
    }
    
    public void addToFavorites(){
        favorite = true;
    }
}
