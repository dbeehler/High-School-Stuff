package ColorGuesser;

import javax.swing.JOptionPane;

public class Menustuff {

	public static void menu(){
		JOptionPane.showMessageDialog(null, "Welcome to Color guesser");
	}
	
	public static void instructions(){
		int n = JOptionPane.showConfirmDialog(null, "Do you need to know how to play?", "Instructions", JOptionPane.YES_NO_OPTION);
		if (n == JOptionPane.YES_OPTION) {
			JOptionPane.showMessageDialog(null, "A word comes up and you guess the color of the word, not the acutal word");
			JOptionPane.showMessageDialog(null, "If you guess the wrong number you lose.");
			JOptionPane.showMessageDialog(null, "Remember to type the color of the word, and not the word itself");
		}
	}
}
