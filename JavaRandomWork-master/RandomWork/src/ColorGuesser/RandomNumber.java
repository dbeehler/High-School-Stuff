package ColorGuesser;

import java.util.Random;

public class RandomNumber {

	public static int colorNum(){
		int colorNum;
		Random rand = new Random();
		colorNum =  rand.nextInt(8) + 0;
		return colorNum;
	}
	
	public static int wordNum(){
		int wordNum;
		Random rand = new Random();
		wordNum =  rand.nextInt(9) + 0;
		return wordNum;
	}

}
