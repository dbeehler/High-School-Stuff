package org.example.pltw.medialib;

public class Song
{
    private int rating;
    private double price = 0.0;
    private String title;
    private boolean favorite = false;

    public Song(){
        rating = 0;
    }

    public Song(String title, double price) {
        this.title = title;
        this.price = price;
    }

    public Song(String title, double price, int rating) {
        this.title = title;
        this.price = price;
        this.rating = rating;
    }

    public int getRating(){
        return rating;
    }

    public String getTitle(){
        return title;
    }

    public void setTitle(String t){

        title = t;
    }

    public double getPrice(){
        return price;
    }

    public void setPrice(double wow){
        price = wow;
    }

    public void addToFavorites(){
        favorite = true;
    }
}

