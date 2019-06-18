package org.example.pltw.medialib;

public class Movie
{
    private int rating;
    private String title;
    private double price;

    public Movie(String title, double price, int rating){
        this.title = title;
        this.rating = rating;
        this.price = price;
    }

    public Movie(){
        rating = 0;
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
}
