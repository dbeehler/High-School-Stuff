package RandomWork;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class timer3D {
	public static void main(String[] args) {
		final int WIDTH = 400, HEIGHT = 400;
		boolean running = true;
		int milliseconds = 1;
		int seconds = 0;
		int minutes = 0;
		int hours = 0;
		JFrame frame = new JFrame("Timer3D");
		JLabel timer = new JLabel("00:00:00");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		frame.add(timer);
		timer.setHorizontalAlignment(SwingConstants.CENTER);
		frame.setSize(WIDTH, HEIGHT);
		frame.setVisible(true);
		
		while(running) {
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
		timer.setText(hours + ":" + minutes + ":" + seconds + "." + milliseconds);
		}
	}
	public static void sleep() {
		try {
			Thread.sleep(100);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	
}
