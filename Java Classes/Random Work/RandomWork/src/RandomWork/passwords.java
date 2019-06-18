package RandomWork;

import java.util.Date;
import java.util.Random;

public class passwords {
	static char[] letters = "abcdefghijklmnopqrstuvwxyz".toCharArray();
	
	public static void main(String[] args) throws InterruptedException {
		Random rand = new Random();
		String secret;
		
		boolean running = true;
		int randLetterNumber = rand.nextInt(letters.length) + 0;
		int random = rand.nextInt(99999999) + 10000000;
		long startTime = System.currentTimeMillis();
		long elapsedTime = 0L;
		
		secret =  "" + random + letters[randLetterNumber];

		while(running) {
			String guess;
			int randLetterNumberLoop = rand.nextInt(letters.length) + 0;
			
			random = rand.nextInt(99999999) + 10000000;
			guess = "" + random + letters[randLetterNumberLoop];
			elapsedTime = ((new Date()).getTime() - startTime);
			
			if (guess.equals(secret)) {
				System.out.println("\n\n\n\n\n\n\n\n\n\n\n");
				System.out.println("Password was " + secret);
				System.out.println("Guess was " + guess);
				System.out.println("time took " + (elapsedTime / 1000) + " seconds");
				running = false;
			}
		}
	}
}
