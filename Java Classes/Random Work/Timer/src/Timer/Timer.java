package Timer;

import java.util.Scanner;

public class Timer {
public static boolean running = true;
	
	public static void main(String[] args){	
		String count;
		int milliseconds = 1;
		int seconds = 0;
		int minutes = 0;
		int hours = 0;
		Scanner scan = new Scanner(System.in);
		System.out.println("Would you like to count up or down?");
		count = scan.nextLine();
		
		if(count.equalsIgnoreCase("up")){
			while(running){
				sleep();
				++milliseconds;
			if(milliseconds > 9){
				milliseconds = 0;
				++seconds;
			}
			if(seconds > 59){
				seconds = 0;
				++minutes;
			}
			if(minutes > 59){
				minutes = 0;
				++hours;
			}
			if(hours > 24)
				break;
			clearScreen();
				System.out.println(hours + ":" + minutes + ":" + seconds + "." + milliseconds);
			}
		}
		else if (count.equalsIgnoreCase("down")){
			
				System.out.println("How many hours? : ");
				hours = scan.nextInt();
				System.out.println("How many minutes? : ");
				minutes = scan.nextInt();
				System.out.println("How many seconds? :");
				seconds = scan.nextInt();
				milliseconds = 0;
				while(running){
					sleep();
					--milliseconds;
					if (milliseconds == 0 && seconds == 0 && minutes == 0 && hours == 0){
						running = false;
					}
					if (milliseconds < 0){
						--seconds;
						milliseconds = 9;
					}
					if (seconds < 0){
						seconds = 59;
						--minutes;
					}
					if (minutes < 0){
						minutes = 60;
						--hours;
					}
					clearScreen();
					System.out.println(hours + ":" + minutes + ":" + seconds + "." + milliseconds);
				}
				System.out.println("All done!");
		}
		scan.close();
	}
	
	public static void clearScreen(){
		System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
	}
	public static void sleep(){
		try {
			Thread.sleep(100);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
}
