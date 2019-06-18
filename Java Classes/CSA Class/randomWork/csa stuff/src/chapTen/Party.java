package chapTen;

public class Party {
    private int guests;

    public int getGuests(){
        return guests;
    }

    public void setGuests(int numGuests){
        guests = numGuests;
    }

    public void displayInvite(){
        System.out.println("Please come to the party!");
    }
}
