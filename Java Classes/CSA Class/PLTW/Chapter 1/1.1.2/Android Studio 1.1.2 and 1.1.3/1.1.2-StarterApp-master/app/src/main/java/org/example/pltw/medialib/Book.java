package org.example.pltw.medialib;

public class Book
{
    private int rating;
    private String title;


    public Book(String title, int rating){
        this.title = title;
        this.rating = rating;
    }


    public Book(){
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
