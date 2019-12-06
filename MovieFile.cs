using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PA5
{
    class MovieFile
    {
        static int count = 0;

        Movie m = new Movie();

        public static void setCount(int temp)
        {
            count = temp;
        }

        public static int getCount()
        {
            return count;
        }
        

        //opens text file, reads in the contents of the text file and loads it into the myMovie array  
        public static Movie[] GetAllMovies()
        {
            Movie[] myMovie = new Movie[500];
            StreamReader inFile = new StreamReader("movieinventory.txt");

            String input = inFile.ReadLine();
            while(input != null)
            {
                String[] temp = input.Split('#');
                myMovie[MovieFile.getCount()] = new Movie(temp[0], int.Parse(temp[1]), temp[2], int.Parse(temp[3]), temp[4]);
                MovieFile.setCount(MovieFile.getCount() + 1);
                input = inFile.ReadLine();
            }
            inFile.Close();

            return myMovie;
        }

        //opens the text file, loops through the myMovie array, & loads the contents of the array into the text file
        public static void SaveMovie(Movie[] myMovie)
        {
            StreamWriter outFile = new StreamWriter("movieinventory.txt");
            
            for (int i = 0; i < MovieFile.getCount(); i++)
            {                
                outFile.WriteLine(myMovie[i].getMovieTitle() + "#" + myMovie[i].getMovieID() + "#" + myMovie[i].getMovieGenre() + "#" + myMovie[i].getReleaseYear() +"#" + myMovie[i].getStock());
                Console.WriteLine(myMovie);
                
            }
            outFile.Close();
        }
    }
}

    
