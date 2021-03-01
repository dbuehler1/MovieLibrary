using System;
using System.IO;


public class MovieMenu{
    
    public MovieMenu(){
        displayMenu();
    }

    public void displayMenu(){
        int userInput = 0;
        while(!(userInput > 4)){
            Console.WriteLine("[1] List Movies \n[2] List Shows \n[3] List Videos ");
            userInput = Int32.Parse(Console.ReadLine());
            testInput(userInput);
        }
        
    }

    public void testInput(int userInput){
        MovieProcess movieOptions = new MovieProcess();
        MediaCenter mc = new MediaCenter();
            
            
        if(userInput > 0 && userInput < 4){
            switch(userInput){
                case 1:
                    mc.readFile("movies.csv", "MOVIE");
                break;
                case 2:
                    mc.readFile("shows.csv", "SHOW");
                break;
                case 3:
                    mc.readFile("videos.csv", "VIDEO");
                break;
            }
        }
        
        
    }


}