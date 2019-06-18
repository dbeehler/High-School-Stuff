package org.example.pltw.medialib;

import android.app.ListActivity;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class MainActivity extends ListActivity {
    private Song[] songs;
    private ListView songListView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Greeter greeter = new Greeter();
        ArrayList songLibrary = new ArrayList<Song>();
        for (int i = 0; i < songs.length; i++) {
            songLibrary.add(songs[i]);
        }
        SongListAdapter adapter = new SongListAdapter(this, songLibrary);
        setListAdapter(adapter);
    }

    /**
     * This method is called when the Show Contents button is clicked
     **/
    public void showMedia(View v) {
        TextView outputText = (TextView) findViewById(R.id.mediaLibText);


        Song song1 = new Song("hi", .99, 1);
        Song song2 = new Song("greetings", 1.29, 2);
        Song song3 = new Song("hey", .99, 3);
        Song song4 = new Song("sup", 1.29, 4);
        Song song5 = new Song("howdy", .99, 5);
        Song song6 = new Song("hello", 1.29, 6);
        Song song7 = new Song("salutations", .99, 7);
        Song song8 = new Song("I hate BlueJay", 1.29, 10);
        Movie movie1 = new Movie("Commuter", 5, 134);
        Book book1 = new Book("why is android studio a dodo", 10);
        outputText.setText("MOVIES: ");
        outputText.append((movie1.getTitle()));
        outputText.append("\n");
        outputText.append("SONGS: ");
        outputText.append((song1.getTitle()));
        outputText.append("\n");
        outputText.append("BOOKS: ");
        outputText.append((book1.getTitle()));
        outputText.append("\n");
    }
}

