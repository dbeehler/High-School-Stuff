package work;

public class DogTriathalonParticipant {
    private final int NUM_EVENTS;
    private static int totalCumulativeScore;

    private String name;
    private int obedienceScore, conformationScore, agilityScore, total;
    private double avg;

    public DogTriathalonParticipant(String name, int numEvents, int score1, int score2, int score3){
        this.name = name;
        NUM_EVENTS = numEvents;
        obedienceScore = score1;
        conformationScore = score2;
        agilityScore = score3;
        total = obedienceScore + conformationScore + agilityScore;
        avg = total / numEvents;
        totalCumulativeScore += total;
    }

    public void display(){
        System.out.println(name + " participated in " + NUM_EVENTS + " events and has an average score of " + avg);
        System.out.println(" " + name + " has a total score of " + total + " bringing the total score to " + totalCumulativeScore);
    }
}
