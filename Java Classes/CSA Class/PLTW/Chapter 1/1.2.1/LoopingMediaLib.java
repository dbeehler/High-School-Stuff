
/**
 * Write a description of class LoopingMediaLib here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class LoopingMediaLib
{
    public static void main()
    {
        //for(int x = 0; x < Song.numSongsInLibrary - 1; x++){
        //System.out.println(MediaFile.readString());
        //}
        while(MediaFile.readString() != null){
            System.out.println(MediaFile.readString());
        }
    }
}
