
/**
 * Write a description of class MediaLib here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class MediaLib
{
    public static Song song1 = new Song("hi", .99, 1);
    public static Song song2 = new Song("greetings", 1.29, 2);
    public static Song song3 = new Song("hey", .99, 3);
    public static Song song4 = new Song("sup", 1.29, 4);
    public static Song song5 = new Song("howdy", .99, 5);
    public static Song song6 = new Song("hello", 1.29, 6);
    public static Song song7 = new Song("salutations", .99, 7);
    public static Song song8 = new Song("I hate BlueJay", 1.29, 10);
    public static Movie movie1 = new Movie("Commuter", 5, 134);
    public static Book book1 = new Book();
    
    public static void main(String[] args){
        System.out.println("Welcome to your Media Library");
        System.out.println(Song.totalPrice);
        System.out.println(Song.numSongs);
        System.out.println(Song.totalRate);
        System.out.println(Song.getAvgCost());
        System.out.println(Song.getAvgRate());
        System.out.println(Movie.returnDur());
        ArrayMediaLib.main();
    }
}
