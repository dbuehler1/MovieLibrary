using System;
using System.IO;
public class MovieMenu{
    
    public MovieMenu(){
        displayMenu();
    }

    public void displayMenu(){
        int userInput = 0;
        while(!(userInput == 3)){
            Console.WriteLine("[1] List Movies \n[2] Add Movie \n[3] Exit ");
            userInput = Int32.Parse(Console.ReadLine());
            testInput(userInput);
        }
        
    }

    public void testInput(int userInput){
        MovieProcess movieOptions = new MovieProcess();
            
            
        if(userInput > 0 && userInput < 4){
            switch(userInput){
                case 1:
                    movieOptions.listMovies();
                break;
                case 2:
                    movieOptions.addMovies(movieOptions.listMovies());
                break;
                case 3:

                break;
            }
        }
        
        
    }


}