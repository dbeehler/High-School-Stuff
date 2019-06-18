package ColorGuesser;

import java.awt.Color;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

public class ColorGuesser {
	public static int seconds;
	
		public static void main(String[] args) {
			boolean gameOver = false;
			String input, name, again = "yes";
			int score = 0;
			
			name = Name.NameFinder();
			Menustuff.menu();
			Menustuff.instructions();
			do { 
				int colorNum = RandomNumber.colorNum();
				int wordNum = RandomNumber.wordNum();
				String[] colors = new String[] { "green", "blue", "red", "yellow", "purple", "black", "orange", "gray"};
				String[] words = new String[] { "green", "blue", "red", "yellow", "purple", "pink", "black", "orange", "brown", };
				final String wordColor = colors[colorNum];
				final String wordWord = words[wordNum];
				final JLabel label = new JLabel(wordWord, JLabel.CENTER);
				label.setForeground(Color.RED);
				input = JOptionPane.showInputDialog(null,"<html><h><font color = '"+wordColor+"'>"+wordWord+"</font> Your score is " + score,"ColorGusser", JOptionPane.INFORMATION_MESSAGE);
				if (input.equalsIgnoreCase("grey")){
					input  = "gray";
				}
				if (input.equalsIgnoreCase(wordColor)) {
					++score;
				} 
				else{
					JOptionPane.showMessageDialog(null, "You lost " + name + "! your score was " + score + ". The word you were supposed to type was " + wordColor );
					again = JOptionPane.showInputDialog(null, "Would you like to play again?", "Confirmation", JOptionPane.INFORMATION_MESSAGE);
					if(again.equalsIgnoreCase("yes")){
						gameOver = false;
						score = 0;
					}
					else{
						gameOver = true;
					}
				}
			} while (!gameOver || again.equalsIgnoreCase("yes"));
		}
}

