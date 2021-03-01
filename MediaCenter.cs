using System;
using System.IO;
using System.Collections;

public class MediaCenter{
    
        public void readFile(String file, String MediaType){
            Movie MovieList = new Movie();
            
            Show ShowList = new Show();
            
            Video VideoList = new Video();
        using (StreamReader reader = new StreamReader(file))
        {
            
            var line = reader.ReadLine();
            
            
            while(!reader.EndOfStream){
                
                var details = line.Split(",");
                line = reader.ReadLine();
                
                if(MediaType.Equals("MOVIE")){
                    MovieList.addMovie(Int32.Parse(details[0]), details[1], details[2].Split("|"));
                }
                else if(MediaType.Equals("SHOW")){
                    ShowList.addShow(Int32.Parse(details[0]), details[1], Int32.Parse(details[2]), Int32.Parse(details[3]), details[4].Split("|"));
                }
                else{
                    VideoList.addVideos(Int32.Parse(details[0]), details[1], details[2], Int32.Parse(details[3]), details[4].Split("|"));
                }
            
            }
        }
        if(MediaType.Equals("MOVIE")){
            MovieList.Display();
            
        }
        else if(MediaType.Equals("SHOW")){
            ShowList.Display(); 
        }
        else{
            VideoList.Display();            
        }
        
    }
}
