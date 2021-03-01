using System;
using System.IO;
using System.Collections;

public abstract class Media
{
    
    
    int id;
    string title;

    public abstract void Display();
}
    
    public class Movie : Media{
        ArrayList movies = new ArrayList();
        String listGenres = "Genres";
        
        public void  addMovie( int id, String title, String[] genres){
            
            for(int i = 0; i < genres.Length; i++){
                listGenres = listGenres + "|" + genres[i]; 
            }
            movies.Add(id + " || " + title + " || " + listGenres);
            listGenres = "Genres";
        }
        
        public override void Display(){
            System.Console.WriteLine("----------Movies----------");
            foreach(String mvie in movies){
                Console.WriteLine(mvie);
            }
            movies.Clear();
        }
    
    }

    public class Show : Media{
        ArrayList shows = new ArrayList();
        int season;
        int episodes;
        String listWriters = "Writers";

        
        public void addShow( int id, String title, int season, int episode, String[] writer){
            
            
            for(int i = 0; i < writer.Length; i++){
                listWriters = listWriters + "|" + writer[i]; 
            }
            this.season = season;
            this.episodes = episode;
            shows.Add(id + " || " + title + " || " + this.season + " || " + episodes + " || " + listWriters);
            listWriters = "Writers";
        }
        
        public override void Display(){
            System.Console.WriteLine("----------Shows----------");
            foreach(String show in shows){
                Console.WriteLine(show);
            }
            shows.Clear();
        }
    
    }

    public class Video : Media{
        ArrayList videos = new ArrayList();
        String listRegions = "Regions";
        
        public void addVideos( int id, String title, String format, int runTime, String[] regions){
            
            for(int i = 0; i < regions.Length; i++){
                listRegions = listRegions + "|" + regions[i]; 
            }
            
            videos.Add(id + " || " + title + " || " + format + " || " + runTime + "minutes || " + listRegions);
            listRegions = "Regions";
        }
        
        public override void Display(){
            System.Console.WriteLine("----------Videos----------");
            foreach(String video in videos){
                Console.WriteLine(video);
            }
            videos.Clear();
        }
    
    }
    


