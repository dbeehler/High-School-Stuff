package challenges;

import java.util.Scanner;

public class PoliticalFever {
	
	public static int delegates;
	public static float percentofCand1, percentofCand2, percentofCand3, totalPercentofCand123, 
	leftOverPercentHalf1, leftOverPercentHalf2, delgatesof1, delegatesof2, delegatesof3;
	
	public static void main(String[] args){
		Scanner s = new Scanner(System.in);
		final float TOTAL_PERCENT = 100;
		print("enter the total Delegates");
		delegates = s.nextInt();
		print("Enter percentage of candidate 1");
		percentofCand1 = s.nextFloat();
		print("Enter percentage of candidate 2");
		percentofCand2 = s.nextFloat();
		percentofCand3 = TOTAL_PERCENT - (percentofCand1 + percentofCand2);
		if (percentofCand1 > 50 || percentofCand2 > 50 || percentofCand3 > 50){
			fiftyPercent();
		}
		else{
			fifteenPercent();
			delegateFinder();
			everythingElse();
		}
		s.close();
	}
	
	public static void fifteenPercent(){
		if (percentofCand1 < 15){
			print("candidate 1 has gotten " + percentofCand1 + "% he/she is non-viable");
			leftOverPercentHalf1 = percentofCand1 / 2;
			leftOverPercentHalf2 = percentofCand1/ 2;
			print("candidate 2 gets " + leftOverPercentHalf1 + "% more percent");
			percentofCand2 = percentofCand2 + leftOverPercentHalf1;
			print("candidate 3 gets " + leftOverPercentHalf2 + "% more percent");
			percentofCand3 = percentofCand3 + leftOverPercentHalf2;
		}
		if (percentofCand2 < 15){
			print("candidate 2 has gotten " + percentofCand2 + "% he/she is non-viable");
			leftOverPercentHalf1 = percentofCand2 / 2;
			leftOverPercentHalf2 = percentofCand2/ 2;
			print("candidate 2 gets " + leftOverPercentHalf1 + "% more percent");
			percentofCand1 = percentofCand1 + leftOverPercentHalf1;
			print("candidate 3 gets " + leftOverPercentHalf2 + "% more percent");
			percentofCand3 = percentofCand3 + leftOverPercentHalf2;
		}
		if (percentofCand3 < 15){
			print("candidate 3 has gotten " + percentofCand3 + "% he/she is non-viable");
			leftOverPercentHalf1 = percentofCand1 / 2;
			leftOverPercentHalf2 = percentofCand2/ 2;
			print("candidate 2 gets " + leftOverPercentHalf1 + "% more percent");
			percentofCand2 = percentofCand2 + leftOverPercentHalf1;
			print("candidate 3 gets " + leftOverPercentHalf2 + "% more percent");
			percentofCand1 = percentofCand1 + leftOverPercentHalf2;
		}
	}
	public static void fiftyPercent(){
		if (percentofCand1 > 50){
			print("candidate 1 has gotten " + percentofCand1 + "% he/she wins!");
		}
		else if (percentofCand2 > 50){
			print("candidate 2 has gotten " + percentofCand2 + "% he/she wins!");
		}
		else if (percentofCand3 > 50){
			print("candidate 3 has gotten " + percentofCand3 + "% he/she wins!");
		}
	}
	public static void everythingElse(){
		if (percentofCand1 < 51 && percentofCand1 > 15){
			print("candidate 1 gets " + delgatesof1 + " of delegates");
		}
		if (percentofCand2 < 51 && percentofCand2 > 15){
			print("candidate 2 gets " + delegatesof2 + "% delegates");
		}
		if (percentofCand3 < 51 && percentofCand3 > 15){
			print("candidate 3 gets " + delegatesof3 + "% delegates");
		}
	}
	public static void print(String str){
		System.out.println(str);
	}
	public static void delegateFinder(){
		delgatesof1 = delegates / percentofCand1;
		delegatesof2 = delegates / percentofCand2;
		delegatesof3 = delegates / percentofCand3;
	}
}
