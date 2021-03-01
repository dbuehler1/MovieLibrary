using System;
using System.IO;
using System.Collections;
//----------------------------------------------------
//Disregard this file, I decided to make a new set of classes
//For the assignment
//----------------------------------------------------
public class MovieProcess{
    ArrayList movies = new ArrayList();
    private Int32 counter = 0;
    private String file = "movies.csv";
    public MovieProcess(){
        if(!File.Exists(file)){
            throw new FileNotFoundException();
        }
    }
    public Int32 listMovies(){
        
        using (StreamReader reader = new StreamReader("movies.csv"))
        {
            var line = reader.ReadLine();
            
            Console.WriteLine("Start");
            while(!reader.EndOfStream){
                counter++;
                var movie = line.Split(",");
                movies.Add(movie[1] + "," + movie[2] + "," + movie[0]);
                line = reader.ReadLine();
            }
            
            counter++;
            //Last line in the csv
            var lastLine = line.Split(",");
            movies.Add(lastLine[1] + "," + lastLine[2] + "," + lastLine[0]);

            //sort movies in alphabetical order
            movies.Sort();

            reader.Close();
            foreach(String movie in movies){
                var testMovie = movie.Split(",");
                Console.WriteLine(testMovie[2] + "------" + testMovie[0] + "------" + testMovie[1]);
            }
            return counter;
        }
    }
    
    
   
        
    

    public void addMovies(Int32 count){
        

        using (StreamWriter writer = File.AppendText("movies.csv"))
            {
                Console.WriteLine("Enter Movie Title: ");
                String title = Console.ReadLine();
                String genre = "";
                String userInput = "";
                String newLine = (count + 8) + "," + title + ",";
                
                do{
                    Console.WriteLine("Add genre: ");
                    genre = Console.ReadLine();
                    Console.WriteLine("Add another genre? (Y or N): ");
                    userInput = Console.ReadLine();
                    newLine = newLine + genre + "|";

                }while(userInput.ToUpper().Equals("Y"));
                bool testDuplicate = false;
                foreach(String movie in movies){
                    if(movie.ToUpper().Contains(title.ToUpper())){
                        testDuplicate = true;
                        break;
                    }
                }
                if(testDuplicate == false){
                    writer.WriteLine(newLine.Substring(0,newLine.Length-1));
                }
                else{
                    Console.WriteLine("Duplicate Movie!");
                }

                

                //writer.WriteLine(newLine.Substring(0,newLine.Length-1));
                writer.Close();
                
            }
    }




}