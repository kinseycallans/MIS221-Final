using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PA5 
{
    class Movie
    {
        int movieID;
        string movieTitle;
        string movieGenre;
        int releaseYear;
        string inStock;

        //No-Arg Constructor for the Movie Class
        public Movie ()
        {
        }

        //Data Shadowing Constructor for the Movie Class
        public Movie (string movieTitle, int movieID, string movieGenre, int releaseYear, string inStock)
        {
            this.movieID = movieID;
            this.movieTitle = movieTitle;
            this.movieGenre = movieGenre;
            this.releaseYear = releaseYear;
            this.inStock = inStock;
        }

        //Below are all Get and Set methods  for the Movie Class
   
        public void setMovieID (int temp)
        {
            movieID = temp;
        }

        public int getMovieID ()
        {
            return movieID;
        }

        public void setMovieTitle (string temp)
        {
            movieTitle = temp;
        }

        public string getMovieTitle ()
        {
            return movieTitle;
        }

        public void setMovieGenre (string temp)
        {
            movieGenre = temp;
        }

        public string getMovieGenre ()
        {
            return movieGenre;
        }

        public void setReleaseYear (int temp)
        {
            releaseYear = temp;
        }

        public int getReleaseYear()
        {
            return releaseYear;
        }
        public void setStock (string temp)
        {
            inStock = temp;
        }
        
        public string getStock()
        {
            return inStock;
        }

        //To String method for the Movie Class
        /*
        public string ToString()
        {
           Console.WriteLine("Hello World!");
        }
        */
        /*
        public static void addMovie(string movieTitle, string movieId, string movieGenre, string releaseYear)
        {
       
        }

        public void removeMovie(string movieTitle)
        {
            Console.WriteLine(movieTitle);
        }
        */
    }
}
