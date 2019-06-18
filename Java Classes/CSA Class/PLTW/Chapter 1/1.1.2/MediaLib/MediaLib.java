
/**
 * Write a description of class MediaLib here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class MediaLib
{
    public static Song song1 = new Song("hi", .99, 10);
    public static Movie movie1 = new Movie();
    public static Book book1 = new Book();
    
    public static void main(String[] args){
        System.out.println("Welcome to your Media Library");
        movie1.setTitle("wow");
        book1.setTitle("Why BlueJ is soooo bad");
        System.out.println(song1.getTitle());
        System.out.println(song1.getRating());
        System.out.println(song1.getPrice());
        System.out.println(movie1.getTitle());
        System.out.println(movie1.getRating());
        System.out.println(book1.getTitle());
        System.out.println(book1.getRating());
    }
}
