package RandomWork;

import javax.swing.JOptionPane;

public class vowelCounter {

	public static void main(String[] args) {
		String input, restart;
		do {
			int totalVowel = 0, totalA = 0, totalE = 0, totalI = 0, totalO = 0, totalU = 0;
			input = JOptionPane.showInputDialog(null, "enter a word!");
			
			for (int i = 0; i < input.length(); i++){
				if (input.charAt(i) == 'a')
					totalA++;
				if (input.charAt(i) == 'e')
					totalE++;
				if (input.charAt(i) == 'i')
					totalI++;
				if (input.charAt(i) == 'o')
					totalO++;
				if (input.charAt(i) == 'u')
					totalU++;
			}
			totalVowel = totalA + totalE + totalI + totalO + totalU;
			JOptionPane.showMessageDialog(null, "the word had " + totalVowel + " vowel(s)");
			restart = JOptionPane.showInputDialog(null, "would you like to enter another word?");
		} while (restart.equals("yes"));
		JOptionPane.showMessageDialog(null, "have a great day!");
	}
}
